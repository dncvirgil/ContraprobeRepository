using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contraprobe.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Denumirea produsului este obligatorie")]
        [Display(Name = "Denumire produs")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tipul produsului este obligatoriu")]
        [Display(Name = "Tip produs")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Modul de ambalare")]
        [Display(Name = "Modul de ambalare")]
        public string Packaging { get; set; }


        [Display(Name = "Descriere")]
        public string Description { get; set; }
    }
}