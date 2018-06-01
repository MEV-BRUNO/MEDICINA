using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class tijek_napredovanja_ponav_uc //tijek napredovanja ponavljaca
    {
        [Required]
        public long id_napredovanje { get; set; }
        [Required]
        public long id_tijek { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public string sadrzaj { get; set; }
        [Required]
        public string dogovor { get; set; } 
    }
}