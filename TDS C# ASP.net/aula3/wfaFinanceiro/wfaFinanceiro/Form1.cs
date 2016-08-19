using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfaFinanceiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Conta>  contas = new List<Conta>();
        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.NumeroConta = Convert.ToInt32(txtNumeroConta.Text);
            conta.TitularConta = new Cliente { Nome = txtNomeCliente.Text };
            conta.Depositar(Convert.ToDouble(txtSaldo.Text));
            contas.Add(conta);
            listBox1.Items.Add("Conta do " + conta.TitularConta.Nome + " Criada" + " Com Saldo de " + conta.SaldoConta);
            

  

            /**
            Conta conta = new Conta();
            conta.Depositar(200);
            conta.TitularConta = new Cliente();

            conta.TitularConta.Nome = "Thiago";

            listBox1.Items.Add(conta.SaldoConta);


            Cliente cli = new Cliente { Nome = "Thiago",
                                        CPF = "123456789",
                                        Endereco = "Rua 110"};

            Cliente cli2 = new Cliente();
            cli2.Nome = "Thiago";
            cli2.CPF = "656565656";
            cli2.Endereco = "Rua 10"; **/


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double total = 0;
            foreach (var conta in contas)
            {
                total += conta.SaldoConta;
                listBox1.Items.Add(conta.TitularConta.Nome + " -> " + conta.SaldoConta);
            }
            listBox1.Items.Add("Total: " + total);
        }
    }
}
