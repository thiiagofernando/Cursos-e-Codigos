using MvcModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModel.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            string usuario = "Thiago";
            ViewBag.usuario = usuario;

            List<Produto> produtos = new List<Produto>();
            Produto produto1 = new Produto
            {
                Codigo = 100,
                Descricao = "Iphone 6s Plus",
                Valor = 4500.00
            };

            Produto produto2 = new Produto
            {
                Codigo = 200,
                Descricao = "Iphone 5s Plus",
                Valor = 1500.00
            };

            Produto produto3 = new Produto
            {
                Codigo = 300,
                Descricao = "Iphone 4s Plus",
                Valor = 500.00
            };

            produtos.Add(produto1);
            produtos.Add(produto2);
            produtos.Add(produto3);

            return View("Index", produtos);
        }
    }
}