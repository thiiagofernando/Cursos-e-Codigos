using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Wallet.Models;
using Wallet.ViewModels;

namespace Wallet.ViewModels
{
    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
    {
        protected AppUser CurrentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }

    public abstract class AppViewPage : AppViewPage<dynamic>
    {

    }
}