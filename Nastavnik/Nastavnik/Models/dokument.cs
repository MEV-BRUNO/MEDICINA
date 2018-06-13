using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nastavnik.Models
{
    public class dokument
    {
        [Required]
        public long id_dokument { get; set; }
        [Required]
        public int id_pedagog { get; set; }
        [Required]
        public int vrsta { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        public string putanja { get; set; }
    }
}