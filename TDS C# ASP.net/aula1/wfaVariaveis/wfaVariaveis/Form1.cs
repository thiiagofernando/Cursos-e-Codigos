using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaVariaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly double taxa = 1.5;
        const double PI = 3.14;

        private void button1_Click(object sender, EventArgs e)
        {
           
            int idade;
            idade = 18;

            int nota = 9;

            int n1, n2;

            string nome = "Thiago Fernando";

            bool valido = false;

            double nota2 = 8.9;
            double nota3 = 8.9;
            double nota4 = 8.9;
            double nota5 = 8.9;
            
            lblResultado.Text = "Nome";
            MessageBox.Show(nome);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int raio = 5;

            double area = PI * raio * raio;
            lblResultado.Text = "Valor da Area ";
            MessageBox.Show("A Area é : " + area.ToString());
            
        }
    }
}
