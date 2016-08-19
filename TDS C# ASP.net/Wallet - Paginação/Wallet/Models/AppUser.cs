using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Wallet.Models
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal) : base(principal)
        {

        }

        public string Nome
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }
        public string Email
        {
            get
            {
                return this.FindFirst(ClaimTypes.Email).Value;
            }
        }
        public string Role
        {
            get
            {
                return this.FindFirst(ClaimTypes.Role).Value;
            }
        }
        public int IdUsuario
        {
            get
            {
                return Convert.ToInt32(this.FindFirst(ClaimTypes.Sid).Value);
            }
        }
    }
}
