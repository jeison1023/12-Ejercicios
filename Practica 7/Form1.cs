using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBox1.Text, out int inicio) && int.TryParse(textBox2.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El número de inicio debe ser menor o igual al número final.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                        listBox1.Items.Add(i);
                }

                if (listBox1.Items.Count == 0)
                    MessageBox.Show("No se encontraron números primos en este rango.", "Resultado");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para el rango.", "Error de entrada");
            }

        }
        private bool EsPrimo(int numero) 
        {
            if (numero == 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++) 
            {
                if (numero % i == 0)
                    return false;           
            }
            return true;
        }
    }
}
