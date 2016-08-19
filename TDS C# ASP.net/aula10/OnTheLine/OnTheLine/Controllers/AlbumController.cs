using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnTheLine.Models.BD;
using System.IO;

namespace OnTheLine.Controllers
{
    public class AlbumController : Controller
    {
        private BdLoja db = new BdLoja();

        // GET: Album
        public ActionResult Index()
        {
            return View(db.Album.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string titulo, HttpPostedFileBase foto)
        {
         
            if(foto != null)
            {
                Album album = new Album();
                album.Titulo = titulo;

                // procedimento para ler a foto e salvar em um diretorio e salva caminho no  banco
                string uploadPatch = Server.MapPath("~/Imagens");
                var arquivo = foto.FileName;
                var ext = Path.GetExtension(foto.FileName);

                Random rnd = new Random();
                string strRandom = rnd.Next(1, 1000).ToString();
                strRandom = strRandom.PadLeft(4, '0');

                string dataHora = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");

                string novoNome = dataHora + strRandom + ext;

                foto.SaveAs(Path.Combine(uploadPatch, novoNome));

                album.Capa = "/Imagens/" + novoNome;

                db.Album.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Listar(int? Id)
        {
            if(Id != 0)
            {
                var fotos = db.Foto.Where(f => f.AlbumID == Id);
                ViewBag.AlbumID = Id;
                return View(fotos);
            }
            return RedirectToAction("Index");
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Album.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: Album/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlgumID,Titulo,Capa")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(album);
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Album.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: Album/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Album album = db.Album.Find(id);
            db.Album.Remove(album);
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
