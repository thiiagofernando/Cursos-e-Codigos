using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wallet.ViewModels;
using System.Security.Claims;
using Wallet.Models;

namespace Wallet.Controllers
{
    [AllowAnonymous]
    public class AuthController : AppController
    {
        dbWalletEntities db = new dbWalletEntities();
        // GET: Auth
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            if (ValidaLogin(model))
            {
                return RedirectToAction("Index", "Home");
            }

            

            ModelState.AddModelError("", "Login e senha Invalidos");
            return View();
        }

        private bool ValidaLogin(LoginModel loginModel)
        {
            var usuario = db.Usuario.Where(u => u.Email == loginModel.Email 
            && u.Senha == loginModel.Senha)
            .FirstOrDefault();
            if (usuario != null)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name , usuario.Nome),
                    new Claim(ClaimTypes.Email , usuario.Email),
                    new Claim(ClaimTypes.Role, usuario.Grupo.Descricao),
                    new Claim(ClaimTypes.Sid, usuario.IDUsuario.ToString())
                },
                "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return true;
            }
            return false;

        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignOut("ApplicationCookie");

            return RedirectToAction("Login");
        }

        public ActionResult Register(LoginModel model, string ConfirmaSenha)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.Mensagem = "Verifique os dados";
                return View("Login");
            }

            if(model.Senha != ConfirmaSenha)
            {
                ViewBag.Mensagem = "As senhas são diferentes";
                return View("Login");
            }

            if(VerificaEmailExistente(model.Email))
            {
                ViewBag.Mensagem = "Já existe uma conta com esse email";
                return View("Login");
            }
            Usuario user = new Usuario();
            user.Nome = model.Nome;
            user.Email = model.Email;
            user.Senha = model.Senha;

            // verificar  se o grupo 1 existe caso não exista criamos
            VerificaGrupo();
            user.IDGrupo = 1;
            //adicionar no db (entityFramwork)
            db.Usuario.Add(user);
            //Salvar alteracoes 
            db.SaveChanges();
            if(ValidaLogin(model))
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Mensagem = "Usuário Registrado com Sucesso";
            return View("Login");

            
            
            
        }
        private void VerificaGrupo()
        {
           var g = db.Grupo.Find(1);
            if(g == null)
            {
                Grupo grupo = new Grupo();
                grupo.IDGrupo = 1;
                grupo.Descricao = "cliente";

                db.Grupo.Add(grupo);
                db.SaveChanges();
            }
        }

        private bool VerificaEmailExistente(string email)
        {
            var exite = db.Usuario.Where(u => u.Email == email).FirstOrDefault();
            if(exite == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}