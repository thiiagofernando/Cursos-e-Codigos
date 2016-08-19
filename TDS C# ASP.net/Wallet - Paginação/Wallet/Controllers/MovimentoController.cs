using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Wallet.Models;
using PagedList;

namespace Wallet.Controllers
{
    public class MovimentoController : AppController
    {
        private dbWalletEntities db = new dbWalletEntities();

        [HttpGet]
        public ActionResult CadastrarDespesa(int? pagina)
        {

            var categorias = db.Categoria
                .Where(c => c.IDUsuario == CurrentUser.IdUsuario && c.Tipo == "Saida").ToList();

            ViewBag.Categorias = categorias;
            var tamanhoPagina = 4;
            var numeroPagina = (pagina ?? 1);
            var movimentos = db.Movimento.Where(m => m.IDUsuario == CurrentUser.IdUsuario && m.Categoria.Tipo == "Saida").ToList();
            var despesa = movimentos.ToPagedList(numeroPagina, tamanhoPagina);
            return View(despesa);
        }
        [HttpPost]
        public ActionResult CadastrarDespesa(Movimento movimento)
        {
            movimento.IDUsuario = CurrentUser.IdUsuario;
            movimento.DtLancamento = DateTime.Now;

            db.Movimento.Add(movimento);
            db.SaveChanges();

            return RedirectToAction("CadastrarDespesa");
        }

        public ActionResult ExcluirDespesa(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("CadastrarDespesa");
            }

            var movimento = db.Movimento.Find(Id);
            if (movimento != null)
            {
                db.Movimento.Remove(movimento);
                db.SaveChanges();
            }
            return RedirectToAction("CadastrarDespesa");
        }

        [HttpGet]
        public ActionResult CadastrarReceita(int? pagina)
        {

            var categorias = db.Categoria
                .Where(c => c.IDUsuario == CurrentUser.IdUsuario && c.Tipo == "Entrada").ToList();

            ViewBag.Categorias = categorias;
            var tamanhoPagina = 4;
            var numeroPagina = (pagina ?? 1);
            var movimentos = db.Movimento.Where(m => m.IDUsuario == CurrentUser.IdUsuario 
                                                && m.Categoria.Tipo == "Entrada").ToList();
            var receita = movimentos.ToPagedList(numeroPagina, tamanhoPagina);
            return View(receita);
        }
        [HttpPost]
        public ActionResult CadastrarReceita(Movimento movimento)
        {
            movimento.IDUsuario = CurrentUser.IdUsuario;
            movimento.DtLancamento = DateTime.Now;

            db.Movimento.Add(movimento);
            db.SaveChanges();

            return RedirectToAction("CadastrarReceita");
        }
        public ActionResult ExcluirReceita(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("CadastrarReceita");
            }

            var movimento = db.Movimento.Find(Id);
            if (movimento != null)
            {
                db.Movimento.Remove(movimento);
                db.SaveChanges();
                
            }
            return RedirectToAction("CadastrarReceita");
            
        }

        public ActionResult Extrato()
        {
            var movimentos = db.Movimento.Where(m => m.IDUsuario == CurrentUser.IdUsuario).ToList();
            return View(movimentos);

            
        }

        // GET: Movimento
        public ActionResult Index()
        {
          
            return RedirectToAction("Index", "Home");
        }

        // GET: Movimento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimento.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            return View(movimento);
        }

        // GET: Movimento/Create
        public ActionResult Create()
        {
            return RedirectToAction("Index", "Home");
        }

        // POST: Movimento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDMovimento,IDCategoria,IDUsuario,NrPeriodo,DtLancamento,Valor")] Movimento movimento)
        {
            if (ModelState.IsValid)
            {
                db.Movimento.Add(movimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCategoria = new SelectList(db.Categoria, "IDCategoria", "Descricao", movimento.IDCategoria);
            ViewBag.IDUsuario = new SelectList(db.Usuario, "IDUsuario", "Nome", movimento.IDUsuario);
            return View(movimento);

        }

        // GET: Movimento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimento.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCategoria = new SelectList(db.Categoria, "IDCategoria", "Descricao", movimento.IDCategoria);
            ViewBag.IDUsuario = new SelectList(db.Usuario, "IDUsuario", "Nome", movimento.IDUsuario);
            return View(movimento);
        }

        // POST: Movimento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDMovimento,IDCategoria,IDUsuario,NrPeriodo,DtLancamento,Valor")] Movimento movimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCategoria = new SelectList(db.Categoria, "IDCategoria", "Descricao", movimento.IDCategoria);
            ViewBag.IDUsuario = new SelectList(db.Usuario, "IDUsuario", "Nome", movimento.IDUsuario);
            return View(movimento);
        }

        // GET: Movimento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimento.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            return View(movimento);
        }

        // POST: Movimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movimento movimento = db.Movimento.Find(id);
            db.Movimento.Remove(movimento);
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
