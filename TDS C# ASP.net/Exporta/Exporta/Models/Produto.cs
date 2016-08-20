using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exporta.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Grupo { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}