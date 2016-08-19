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
    public class MonitorController : Controller
    {
        private PerifericosEntities db = new PerifericosEntities();

        // GET: Monitor
        public ActionResult Index()
        {
            var monitor = db.Monitor.Include(m => m.Departamento).Include(m => m.Marca);
            return View(monitor.ToList());
        }

        // GET: Monitor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitor.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            return View(monitor);
        }

        // GET: Monitor/Create
        public ActionResult Create()
        {
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao");
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao");
            return View();
        }

        // POST: Monitor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDMonitor,NrPatrimonio,IDDepartamento,Tamanho,IDMarca")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                db.Monitor.Add(monitor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", monitor.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", monitor.IDMarca);
            return View(monitor);
        }

        // GET: Monitor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitor.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", monitor.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", monitor.IDMarca);
            return View(monitor);
        }

        // POST: Monitor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDMonitor,NrPatrimonio,IDDepartamento,Tamanho,IDMarca")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monitor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", monitor.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", monitor.IDMarca);
            return View(monitor);
        }

        // GET: Monitor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitor monitor = db.Monitor.Find(id);
            if (monitor == null)
            {
                return HttpNotFound();
            }
            return View(monitor);
        }

        // POST: Monitor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monitor monitor = db.Monitor.Find(id);
            db.Monitor.Remove(monitor);
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
