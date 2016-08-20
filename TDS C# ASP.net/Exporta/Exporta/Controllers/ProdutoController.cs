using Exporta.DAO;
using Exporta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Exporta.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {

            return View(DAOProduto.ListaProdutos());
        }

        public void Exporta()
        {
            List<Produto> produtos = DAOProduto.ListaProdutos();

            WebGrid webgrid = new WebGrid(produtos);

            string gridData = webgrid.GetHtml(
                columns: webgrid.Columns(
                    webgrid.Column(columnName: "Codigo", header : "Codigo"),
                    webgrid.Column(columnName: "Descricao", header: "Descrição"),
                    webgrid.Column(columnName: "Valor", header: "Valor")
                    )).ToString();
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=Produtos.xls");
            Response.ContentType = "applicatio/excel";
            Response.Write(gridData);
            Response.End();
        }
    }
}