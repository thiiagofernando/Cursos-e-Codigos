using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaHeranca
{
    class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public string Titular { get; set; }

        public double Limite { get; set;}

        public int Tipo { get; set; }

        public virtual void Sacar (double valor)
        {
                this.Saldo -= valor;
        }

        public void Depositar ( double valor )
        {
            this.Saldo += valor;
        }
    }
}
