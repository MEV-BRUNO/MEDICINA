using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class nastavni_program
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public string naziv { get; set; }
    }
}