using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaExpressoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = (10 + 4) / 2;

            MessageBox.Show("Resultado da expressão: " + resultado.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double multiplica;
            multiplica = 4 * 2;

            MessageBox.Show("Resultado da Multiplicação : " + multiplica.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            double resultado = numero1 / numero2;
            
            MessageBox.Show("A Divisão é : " + resultado);
        }
    }
}
