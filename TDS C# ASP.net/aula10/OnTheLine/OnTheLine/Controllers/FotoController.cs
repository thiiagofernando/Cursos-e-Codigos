using OnTheLine.Models.BD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTheLine.Controllers
{
    public class FotoController : Controller
    {
        private BdLoja db = new BdLoja();
        // GET: Foto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(int AlbumID, string descricao, HttpPostedFileBase foto)
        {
            string uploadPatch = Server.MapPath("~/Imagens");
            var arquivo = foto.FileName;
            var ext = Path.GetExtension(foto.FileName);

            Random rnd = new Random();
            string strRandom = rnd.Next(1, 1000).ToString();
            strRandom = strRandom.PadLeft(4, '0');

            string dataHora = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");

            string novoNome = dataHora + strRandom + ext;

            foto.SaveAs(Path.Combine(uploadPatch, novoNome));

            Foto ft = new Foto();
            ft.Descricao = descricao;
            ft.Caminho = "/Imagens/" + novoNome;
            ft.AlbumID = AlbumID;

            db.Foto.Add(ft);
            db.SaveChanges();
            return RedirectToAction("Index", "Album");
        }
    }
}