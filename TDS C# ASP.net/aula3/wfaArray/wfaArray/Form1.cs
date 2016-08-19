using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] DiasSemana = new string[7];
            DiasSemana[0] = "Domingo";
            DiasSemana[1] = "Segunda";
            DiasSemana[2] = "Terça";
            DiasSemana[3] = "Quarta";
            DiasSemana[4] = "Quinta";
            DiasSemana[5] = "Sexta";
            DiasSemana[6] = "Sabado";

            MessageBox.Show(DiasSemana[1]);

            string[] DiaSemana2 = { "Domingo","Segunda ", "...", "Sabado" };

            for (int i = 0; i < DiasSemana.Length; i++)
            {
                listBox1.Items.Add("Dia " + DiasSemana[i]);
            }
        }
    }
}
