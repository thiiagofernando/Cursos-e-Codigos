using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModel.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Credito { get; set; }

        public string usuario { get; set; }
    }
}