using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;

namespace Wallet.Controllers
{
    public abstract class AppController : Controller
    {
        // GET: App
        public AppUser CurrentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }
}