using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TDSClientes.Models
{
    public class Cliente
    {
        [Key]
        public int Codigo { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Limite de Compra")]
        public double LimiteCompras { get; set; }

    }
}