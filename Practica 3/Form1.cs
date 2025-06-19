using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Practica_3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Metros", "Centimetros", "Pulgadas" });
            comboBox2.Items.AddRange(new string[] { "Metros", "Centimetros", "Pulgadas" });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                double resultado = Convertir(valor, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                label1.Text = $"Resultado: {resultado:F2} {comboBox2.SelectedItem}";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double Convertir(double valor, string entrada, string salida)
        {
            switch (entrada)
                {
                case "Metros": break;
                case "Centímetros": valor /= 100; break;
                case "Pulgadas": valor *= 0.0254; break;
            }  
            switch (salida)
            {
                case "Metros": return valor;
                case "Centímetros": return valor * 100;
                case "Pulgadas": return valor / 0.0254;
                default: return 0;
            }
        }
    }
}
