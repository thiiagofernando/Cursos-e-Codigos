using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroducaoMvc.Controllers
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Profissacao { get; set; }
    }
    public class TesteController : Controller
    {
        public ActionResult ListaCliente()
        {
            Cliente cli = new Cliente();
            cli.Nome = "Thiago";
            cli.Codigo = 123;
            cli.Profissacao = "Desenvolverdor";

            ViewData["Cliente"] = cli;
            

            var a = 1;
            if (a == 1)
            {
                return View("Funcionarios");
            }
            else
            {
                return View("ListaCliente");
            }
        }
        public string Ola()
        {
            return "Olá Mundo MVC";
        }

        [NonAction]
        public string Curso()
        {
            return "Curso Asp.Net MVC";
        }

    }
}