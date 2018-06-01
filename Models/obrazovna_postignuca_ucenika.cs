using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nastavnik.Models
{
    public class obrazovna_postignuca_ucenika
    {
        [Required]
        public long id_pracenje { get; set; }
        [Required]
        public int godina { get; set; }
        [Required]
        public int razred { get; set; }
        [Required]
        public string napomena { get; set; }
    }
}