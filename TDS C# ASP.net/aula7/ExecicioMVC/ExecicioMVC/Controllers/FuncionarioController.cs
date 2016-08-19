using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExecicioMVC.Controllers
{
    public class Funcionario
        {
            public string Nome { get; set; }
            public int Matricula { get; set; }
            public double Salario { get; set; }
        }
    public class FuncionarioController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Info()
        {
            Funcionario func = new Funcionario();
            func.Nome = "Thiago";
            func.Matricula = 12345;
            func.Salario = 12333.555;

            ViewData["Funcionario"] = func;
            return View("Info");
        }
        // GET: Funcionario
        public string GetFuncionario()
        {

            Funcionario func = new Funcionario();
            func.Nome = "Thiago";
            return func.Nome;
        }
    }
}