using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "000000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if(EsPerfecto(numero))
                {
                    MessageBox.Show(Text = $"{numero} es un numero perfecto.", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} No es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool EsPerfecto(int numero)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    sumaDivisores += i;
            }
            return sumaDivisores == numero;
        
        }
    }
}
