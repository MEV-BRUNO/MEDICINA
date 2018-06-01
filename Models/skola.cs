using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nastavnik.Models
{
    public class skola
    {
        [Required]
        public int id_skola { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        public string adresa { get; set; }
        [Required]
        public string grad { get; set; }
        [Required]
        public string oib { get; set; }
        [Required]
        public string mail { get; set; }
        [Required]
        public string tel { get; set; }
        [Required]
        public string opis { get; set; }
    }
}