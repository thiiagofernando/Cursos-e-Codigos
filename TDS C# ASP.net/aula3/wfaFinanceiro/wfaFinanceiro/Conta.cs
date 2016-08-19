using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFinanceiro
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public double SaldoConta { get; private set; }
        public Cliente TitularConta { get; set; }

        public void Depositar(double valor)
        {
            this.SaldoConta += valor;
        }

        public void Sacar(double valor)
        {
            this.SaldoConta -= valor;
        }
    }
}
