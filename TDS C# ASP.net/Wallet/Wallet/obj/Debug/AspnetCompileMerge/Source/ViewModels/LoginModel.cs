using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Wallet.ViewModels
{
    public class LoginModel
    {
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [HiddenInput]
        [Display(Name = " ")]
        public string ReturnUrl { get; set; }
    }
}