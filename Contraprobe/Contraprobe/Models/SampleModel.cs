using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contraprobe.Models
{
    public class SampleModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Produsul este obligatorie")]
        [Display(Name ="Produs")]
        public string Product { get; set; }

        [Required(ErrorMessage = "Seria produsului este obligatorie")]
        [Display(Name = "Serie produs")]
        public string Series { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Data fabricatiei este obligatorie")]
        [Display(Name = "Data fabricatiei")]
        public DateTime ProductionDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Data expirarii este obligatorie")]
        [Display(Name = "Data expirarii")]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "Cantitatea este obligatorie")]
        [Display(Name = "Cantitate")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Locatia este obligatorie")]
        [Display(Name = "Locatie")]
        public string Location { get; set; }

        [Display(Name = "Data adaugarii")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Adaugat de")]
        public string UserName { get; set; }

        public string Status { get; set; }
    }
}