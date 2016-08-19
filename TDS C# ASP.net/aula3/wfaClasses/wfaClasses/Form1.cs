using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Residencia residencia = new Residencia(TipoResidencia.Apartamento);

            residencia.aguaQuente = true;
            residencia.numeroQuatos = 2;


            Residencia residencia2 = new Residencia(TipoResidencia.Casa, false);
            residencia.tipo = TipoResidencia.Casa;
            residencia.temGaragem = true;

            int precovenda = residencia2.CalculaVenda();


        }
    }
}
