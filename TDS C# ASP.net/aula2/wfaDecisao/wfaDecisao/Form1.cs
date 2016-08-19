using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDecisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro = Convert.ToDouble(textBox1.Text);
            bool coroa = true;


            if (dinheiro >= 50 && coroa)
            {
                
                MessageBox.Show("Bora Sair");
            }
            else
            {
                MessageBox.Show("Bora assistir netflix");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dia = 9;

            switch (dia)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda");
                    break;
                case 3:
                    MessageBox.Show("Terça");
                    break;
                case 4:
                    MessageBox.Show("Quarta");
                    break;
                case 5:
                    MessageBox.Show("Quinta");
                    break;
                case 6:
                    MessageBox.Show("Sexta");
                    break;
                case 7:
                    MessageBox.Show("Sabado");
                    break;

                default:
                    MessageBox.Show("Dia Invalido");
                    break;
                    
            }
        }
    }
}
