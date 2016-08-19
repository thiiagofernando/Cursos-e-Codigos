using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDeposito
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double valordepositado = Convert.ToDouble(txtValor.Text);
            realizarDeposito(valordepositado);
            

        }

        //metodo de deposito
        void realizarDeposito(double valor)
        {
            try
            {
                if (valor >= 1000)
                {
                    valor = valor * 1.15;
                }
                else
                {
                    valor = valor * 1.1;
                }
                lblSaldo.Text = valor.ToString();
                lblusuario.Text = txtNome.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na Operação " + ex.Message);
            }
        }
    }
}
