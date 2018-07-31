using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contraprobe.Models
{
    public class LoginModel

    {
        [Required(ErrorMessage = "Username este obligatoriu")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola este obligatorie")]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Display(Name = "Tine-ma minte!")]
        public bool RememberMe { get; set; }
    }
}