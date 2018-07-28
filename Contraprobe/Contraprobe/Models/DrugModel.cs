using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contraprobe.Models
{
    public class DrugModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Denumirea produsului este obligatorie")]
        [Display(Name ="Denumire produs")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Seria produsului este obligatorie")]
        [Display(Name = "Serie produs")]
        public string Series { get; set; }

        [Required(ErrorMessage = "Tipul produsului este obligatoriu")]
        [Display(Name = "Tip produs")]
        public string ProductType { get; set; }

        [Required(ErrorMessage = "Data fabricatiei este obligatorie")]
        [Display(Name = "Data fabricatiei")]
        public DateTime ProductionDate { get; set; }

        [Required(ErrorMessage = "Data expirarii este obligatorie")]
        [Display(Name = "Data expirarii")]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "Cantitatea este obligatorie")]
        [Display(Name = "Cantitate")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Locatia este obligatorie")]
        [Display(Name = "Locatie")]
        public string Location { get; set; }
    }
}