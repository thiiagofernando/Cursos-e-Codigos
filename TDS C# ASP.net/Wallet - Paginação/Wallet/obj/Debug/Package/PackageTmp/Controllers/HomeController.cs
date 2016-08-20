using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;

namespace Wallet.Controllers
{
    public class HomeController : AppController
    {
        // GET: Home
        dbWalletEntities db = new dbWalletEntities();
        public ActionResult Index()
        {
            var usuario = db.Usuario.Find(CurrentUser.IdUsuario);
            return View(usuario);
        }

        public ActionResult PageErro()
        {
            return View();
        }
    }
}