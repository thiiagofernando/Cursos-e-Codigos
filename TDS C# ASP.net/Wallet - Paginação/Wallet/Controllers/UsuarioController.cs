using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;

namespace Wallet.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UsuarioController : AppController
    {
        private dbWalletEntities db = new dbWalletEntities();
        //metodo para alterar a foto
        [Authorize(Roles = "cliente")]
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

        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = db.Usuario.Include(u => u.Grupo);
            return View(usuario.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.IDGrupo = new SelectList(db.Grupo, "IDGrupo", "Descricao");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Create([Bind(Include = "IDUsuario,Nome,Email,Senha,IDGrupo,Foto")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDGrupo = new SelectList(db.Grupo, "IDGrupo", "Descricao", usuario.IDGrupo);
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDGrupo = new SelectList(db.Grupo, "IDGrupo", "Descricao", usuario.IDGrupo);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public ActionResult Edit([Bind(Include = "IDUsuario,Nome,Email,Senha,IDGrupo,Foto")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDGrupo = new SelectList(db.Grupo, "IDGrupo", "Descricao", usuario.IDGrupo);
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
       
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
