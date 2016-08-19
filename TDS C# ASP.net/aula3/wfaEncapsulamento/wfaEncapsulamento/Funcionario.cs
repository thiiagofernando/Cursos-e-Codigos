using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEncapsulamento
{
    class Funcionario
    {
        private string nome;
        public string matricula { get; set }
        public double salario { get;  private set; }

        // metodo publico para alterar o salario. somente se o valor for maior que o salario atual
        public bool setSalario (double valor)
        {
            if(valor > this.salario)
            {
                this.salario = valor;
                return true;
            }
            return false;
        }
       

        public void SetNome(string nome)
        {
            this.nome = nome.ToUpper();
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void RegistrarPonto()
        {
            //Codigos
        }
    }
}
