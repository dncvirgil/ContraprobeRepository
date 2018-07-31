using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contraprobe.Models
{
    public class UserModel
    {
        public int ID { get; set;}

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [Display(Name = "Nume")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu")]
        [Display(Name = "Prenume")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Campul Departament este obligatoriu")]
        [Display(Name = "Departament")]
        public string Department { get; set; }


        [Required(ErrorMessage = "Emailul este obligatoriu")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Parola este obligatorie")]
        [StringLength(100, ErrorMessage = "Parola trebuie sa contina minim 6 caractere!", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma parola")]
        [Compare("Password", ErrorMessage = "Parola nu este identica")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Are rol de administrator?")]
        public bool IsAdministrator { get; set; }
    }
}