using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;

namespace Wallet.Controllers
{
    public class CategoriaController : AppController
    {
        dbWalletEntities db = new dbWalletEntities();
        // GET: Categoria
        public ActionResult Index()
        {

            var categoria = db.Categoria.Where(c => c.IDUsuario == CurrentUser.IdUsuario).ToList();
            return View(categoria);
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

        public ActionResult Delete(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction("Index");
            }

            var categoria = db.Categoria.Find(Id);
            if(categoria != null)
            {
                db.Categoria.Remove(categoria);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}