using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_los_8_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 

            if (int.TryParse(textBox1.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
