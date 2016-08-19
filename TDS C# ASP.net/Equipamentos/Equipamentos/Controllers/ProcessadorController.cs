using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Equipamentos;

namespace Equipamentos.Controllers
{
    public class ProcessadorController : Controller
    {
        private PerifericosEntities db = new PerifericosEntities();

        // GET: Processador
        public ActionResult Index()
        {
            return View(db.Processador.ToList());
        }

        // GET: Processador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processador processador = db.Processador.Find(id);
            if (processador == null)
            {
                return HttpNotFound();
            }
            return View(processador);
        }

        // GET: Processador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Processador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDProcessador,Descricao")] Processador processador)
        {
            if (ModelState.IsValid)
            {
                db.Processador.Add(processador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(processador);
        }

        // GET: Processador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processador processador = db.Processador.Find(id);
            if (processador == null)
            {
                return HttpNotFound();
            }
            return View(processador);
        }

        // POST: Processador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDProcessador,Descricao")] Processador processador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(processador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(processador);
        }

        // GET: Processador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processador processador = db.Processador.Find(id);
            if (processador == null)
            {
                return HttpNotFound();
            }
            return View(processador);
        }

        // POST: Processador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Processador processador = db.Processador.Find(id);
            db.Processador.Remove(processador);
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
