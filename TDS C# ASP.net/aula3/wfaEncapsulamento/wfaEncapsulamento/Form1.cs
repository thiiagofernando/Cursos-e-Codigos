using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfaEncapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            func.SetNome("Thiago");
            func.matricula = "F01071986";
            //func.salario = 1000;
            double teste = func.salario;
            MessageBox.Show("Nome: "  + func.GetNome());
            MessageBox.Show("Matricula: " + func.matricula.ToString());
            MessageBox.Show("Salario : " + func.salario.ToString());

        }
    }
}
