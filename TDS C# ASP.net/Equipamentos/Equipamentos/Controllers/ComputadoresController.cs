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
    public class ComputadoresController : Controller
    {
        private PerifericosEntities db = new PerifericosEntities();

        // GET: Computadores
        public ActionResult Index()
        {
            var computadores = db.Computadores.Include(c => c.Departamento).Include(c => c.Marca).Include(c => c.Processador).Include(c => c.Tipo);
            return View(computadores.ToList());
        }

        // GET: Computadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computadores computadores = db.Computadores.Find(id);
            if (computadores == null)
            {
                return HttpNotFound();
            }
            return View(computadores);
        }

        // GET: Computadores/Create
        public ActionResult Create()
        {
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao");
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao");
            ViewBag.IDProcessador = new SelectList(db.Processador, "IDProcessador", "Descricao");
            ViewBag.IDTipo = new SelectList(db.Tipo, "IDTipo", "Descricao");
            return View();
        }

        // POST: Computadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDComputador,NrPratrimonio,IDDepartamento,IDTipo,IDMarca,IDProcessador,Memoria,Disco")] Computadores computadores)
        {
            if (ModelState.IsValid)
            {
                db.Computadores.Add(computadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", computadores.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", computadores.IDMarca);
            ViewBag.IDProcessador = new SelectList(db.Processador, "IDProcessador", "Descricao", computadores.IDProcessador);
            ViewBag.IDTipo = new SelectList(db.Tipo, "IDTipo", "Descricao", computadores.IDTipo);
            return View(computadores);
        }

        // GET: Computadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computadores computadores = db.Computadores.Find(id);
            if (computadores == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", computadores.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", computadores.IDMarca);
            ViewBag.IDProcessador = new SelectList(db.Processador, "IDProcessador", "Descricao", computadores.IDProcessador);
            ViewBag.IDTipo = new SelectList(db.Tipo, "IDTipo", "Descricao", computadores.IDTipo);
            return View(computadores);
        }

        // POST: Computadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDComputador,NrPratrimonio,IDDepartamento,IDTipo,IDMarca,IDProcessador,Memoria,Disco")] Computadores computadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(computadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDDepartamento = new SelectList(db.Departamento, "IDDepartamento", "Descricao", computadores.IDDepartamento);
            ViewBag.IDMarca = new SelectList(db.Marca, "IDMarca", "Descricao", computadores.IDMarca);
            ViewBag.IDProcessador = new SelectList(db.Processador, "IDProcessador", "Descricao", computadores.IDProcessador);
            ViewBag.IDTipo = new SelectList(db.Tipo, "IDTipo", "Descricao", computadores.IDTipo);
            return View(computadores);
        }

        // GET: Computadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computadores computadores = db.Computadores.Find(id);
            if (computadores == null)
            {
                return HttpNotFound();
            }
            return View(computadores);
        }

        // POST: Computadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Computadores computadores = db.Computadores.Find(id);
            db.Computadores.Remove(computadores);
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
