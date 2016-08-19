using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaClasses
{
    enum TipoResidencia : int  {Apartamento, Sobrado, Flat, Casa};
    class Residencia
    {
       public TipoResidencia tipo;
       public int numeroQuatos;
       public bool aguaQuente;
       public bool temGaragem;

        //Criando Construtro para Classe

        public Residencia()
        {
            
        }

        public Residencia(TipoResidencia tipo)
        {
            this.tipo = tipo;
        }

        public Residencia(TipoResidencia tipo, bool aguaQuente)
        {
            this.aguaQuente = aguaQuente;
        }
        
        //Calcular o Preço de Venda 
        public int CalculaVenda()
        {
            return 1;
        }
        
        }
    }

