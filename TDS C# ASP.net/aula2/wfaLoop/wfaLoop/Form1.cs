using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string frase = txtFrase.Text;

            int copia = Convert.ToInt32(txtCopia.Text);
            
           

            while (copia > 0)
            {
               // copia++;
                listBox1.Items.Add(copia.ToString() + " - " + frase);
                copia--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Valor de i:  " + i.ToString());
            }
        }
    }
}
