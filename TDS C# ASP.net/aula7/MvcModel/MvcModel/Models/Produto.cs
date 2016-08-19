using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModel.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}