using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;
using PagedList;

namespace Wallet.Controllers
{
    public class CategoriaController : AppController
    {
        dbWalletEntities db = new dbWalletEntities();
        // GET: Categoria
        public ActionResult Index(int? pagina)
        {
            var tamanhoPagina = 3;
            var numeroPagina = (pagina ?? 1);
            var categoria = db.Categoria.Where(c => c.IDUsuario == CurrentUser.IdUsuario).ToList();
            var cat = categoria.ToPagedList(numeroPagina, tamanhoPagina);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            categoria.IDUsuario = CurrentUser.IdUsuario;

            db.Categoria.Add(categoria);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult PageErro()
        {
            return View();
        }

        public ActionResult Delete(int? Id)
        {
            try
            {
                if (Id == null)
                {
                    return RedirectToAction("Index");
                }

                var categoria = db.Categoria.Find(Id);
                if (categoria != null)
                {
                    db.Categoria.Remove(categoria);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("PageErro");
            }
        }

    }
}