using MvcModel.Models;
using MvcModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModel.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cli = new Cliente
            {
                Codigo = 400,
                Nome = "Thiago Fernando",
                Credito = 245.09,
                usuario = "Administrador"
            };

            //string usuario = "Administrador";

            ClienteViewModel ClienteVM = new ClienteViewModel();
            ClienteVM.Codigo = cli.Codigo.ToString();
            ClienteVM.Nome = cli.Nome.ToString();
            ClienteVM.Credito = cli.Credito.ToString("C");
            ClienteVM.Usuario = cli.usuario;

            if(cli.Credito > 1000)
            {
                ClienteVM.Cor = "red";
            }
            else
            {
                ClienteVM.Cor = "green";
            }
            return View(ClienteVM);
        }
    }
}