using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(textBox1.Text);
            double nota2 = Convert.ToDouble(textBox2.Text);
            double nota3 = Convert.ToDouble(textBox3.Text);
            double nota4 = Convert.ToDouble(textBox4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;



            if (nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
            {
                lblStatus.Text = ("Nota não pode ser maior que 10");
                lblNota.Text = Convert.ToString(media);                
            }
            else if (media >= 7 && media <= 10)
            {
                lblStatus.Text = ("Aprovado");
                lblNota.Text = Convert.ToString(media); 
            }
            else if (media >= 5 && media < 7)
            {
                lblStatus.Text = ("Prova Final");
                lblNota.Text = Convert.ToString(media); 
            }
            else if (media < 5)
            {
                lblStatus.Text = ("Reprovado");
                lblNota.Text = Convert.ToString(media); 
            }
            else
            {
                lblStatus.Text = ("Nota não pode ser maior que 10");
                
            }


            //verifica a maior nota

            if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
            {
                lblMaiorNota.Text = Convert.ToString(nota1 + " - " + "Nota 1");
                
            }
            else if (nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
            {
                lblMaiorNota.Text = Convert.ToString(nota3 + " - " + "Nota 2");
            }
            else if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
            {
                lblMaiorNota.Text = Convert.ToString(nota3 + " - " + "Nota 3");
            }
            else if (nota4 > nota1 && nota4 > nota2 && nota4 > nota3)
            {
                lblMaiorNota.Text = Convert.ToString(nota4 + " - " + "Nota 4");
            }
            else
            {

                lblMaiorNota.Text = ("Existe mais de uma nota com o mesmo valor!!");
            }
        }
    }
}
