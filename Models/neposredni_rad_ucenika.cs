using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class neposredni_rad_ucenika
    {
        [Required]
        public long id_pracenje { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public string biljeska { get; set; }
    }
}