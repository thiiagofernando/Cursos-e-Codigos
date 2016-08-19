using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDSClientes.DAL;
using TDSClientes.Models;
using System.Data.Entity;

namespace TDSClientes.Controllers
{
    public class ClienteController : Controller
    {
        private TDSERP db = new TDSERP();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        [HttpGet]
        public  ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Cliente cli)
        {
            db.Clientes.Add(cli);
            db.SaveChanges();
            return View();
            
        }
        public ActionResult Deletar(int Id)
        {
    
            Cliente cli = db.Clientes.Find(Id);
            db.Clientes.Remove(cli);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int ? Id)
        {
            // varifica se exite id
            if (Id == null)
            {
                return RedirectToAction("Index");
            }

            Cliente cli = db.Clientes.Find(Id);

            if (cli == null)
            {
                return RedirectToAction("Index");
            }

            //verificar se foi encontrado id


            return View(cli);

        }

        [HttpPost]
        public ActionResult Editar(Cliente cli)
        {
            db.Entry(cli).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
       
        }
    }
}