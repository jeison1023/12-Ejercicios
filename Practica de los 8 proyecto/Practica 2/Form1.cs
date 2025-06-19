using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
         int segundos = 0;

        public int segundosTotales { get; private set; }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minutos) &&
         int.TryParse(textBox2.Text, out int segundos) &&
         minutos >= 0 && segundos >= 0 && segundos < 60)
            {
                segundosTotales = minutos * 60 + segundos;

                if (segundosTotales > 0)
                {
                    timer1.Start();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            segundos = 0;
            label1.Text = "00:00";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (segundosTotales > 0)
            {
                segundosTotales--;
                TimeSpan tiempo = TimeSpan.FromSeconds(segundosTotales);
                label1.Text = tiempo.ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                label1.Text = "00:00";
                MessageBox.Show("¡Tiempo terminado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
