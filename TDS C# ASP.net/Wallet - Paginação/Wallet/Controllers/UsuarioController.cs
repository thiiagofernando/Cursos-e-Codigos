using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;


namespace Wallet.Controllers
{
    public class UsuarioController : AppController
    {
        // GET: Usuario
        dbWalletEntities db = new dbWalletEntities();

        public ActionResult AlteraFoto(HttpPostedFileBase Foto)
        {
           
            try
            {
                string uploadPatch = Server.MapPath("~/Imagens");
                var ext = Path.GetExtension(Foto.FileName);
                string nomeFoto = CurrentUser.Email + ext;
                Foto.SaveAs(Path.Combine(uploadPatch, nomeFoto));

                var usuario = db.Usuario.Find(CurrentUser.IdUsuario);

                usuario.Foto = nomeFoto;
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                
                return RedirectToAction("Index", "Home");
            }

        }
    }
}