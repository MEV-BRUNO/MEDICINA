using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class roditelj_biljeske_mjesec
    {
        [Required]
        public long id_biljeske { get; set; }
        [Required]
        public string mjesec { get; set; }
        [Required]
        public string zakljucak { get; set; }
    }
}