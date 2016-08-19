using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTratamentodeErro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(textBox1.Text);
                double numero2 = Convert.ToDouble(textBox2.Text);

                double resultado = numero1 / numero2;

                MessageBox.Show("Resultado : " + resultado.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Informe Somente Numeros, " + ex.Message);

            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Divisão por zero " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("valor invalido : " + ex.Message);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(textBox1.Text);
                double numero2 = Convert.ToDouble(textBox2.Text);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro");
            }
            finally
            {
                MessageBox.Show("Entrou no finally");
            }
        }

        
    }

}
