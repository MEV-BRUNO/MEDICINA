using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class ispisani_ucenici
    {
        [Required]
        public long id_analiza { get; set; }
        [Required]
        public long id_ucenik { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public string razlog { get; set; }
        [Required]
        public string skola { get; set; }

    }
}