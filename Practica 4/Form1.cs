using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text.ToLower().Replace(" ", "").Replace(",", "").Replace(".", ""); // Normaliza la entrada

            if (EsPalindromo(palabra))
            {
                MessageBox.Show($"'{textBox1.Text}' es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'{textBox1.Text}' NO es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool EsPalindromo (string palabra)
           
        {
            return palabra.SequenceEqual(palabra.Reverse());

        }
    }
}
