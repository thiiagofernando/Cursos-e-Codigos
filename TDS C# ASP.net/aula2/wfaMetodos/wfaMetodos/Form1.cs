using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exibir("Olá C#");
            Exibir("Olá Java");
            Exibir("Olá PHP");
        }

        void Exibir(string texto)
        {
            MessageBox.Show(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);

            Somar(n1, n2);
            Exibir("Multiplicação: " + Multiplicar(n1, n2).ToString());
        }

        void Somar(double x, double y)
        {
            double soma = x + y;
            Exibir("A Soma " + soma.ToString());
        }

        double  Multiplicar(double x,  double y)
        {
            double resultado = x * y;
            return resultado;
        }
    }
}
