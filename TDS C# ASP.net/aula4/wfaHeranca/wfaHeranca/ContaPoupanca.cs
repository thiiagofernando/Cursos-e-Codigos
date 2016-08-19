using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaHeranca
{
    class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            this.Saldo -=(valor * 1.10);
        }

        public void Aplicacao(double valor)
        {
            //implementação
        }
    }
}
