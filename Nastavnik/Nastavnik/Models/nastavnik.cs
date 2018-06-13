using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class nastavnik
    {
        [Required]
        public long id_ucenik { get; set; }
        [Required]
        public int id_skola { get; set; }
        [Required]
        public string ime_prezime { get; set; }
        [Required]
        public int titula { get; set; }

    }
}