using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class roditelj_razgovor
    {
        [Required]
        public long id_razgovor { get; set; }
        [Required]
        public int id_pedagog { get; set; }
        [Required]
        public int id_odjel { get; set; }
        [Required]
        public long id_ucenik { get; set; }
        [Required]
        public int godina { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public string naslov { get; set; }
        [Required]
        public string ime_roditelja { get; set; }
        [Required]
        public string trazi { get; set; }
        [Required]
        public string razlog { get; set; }
        [Required]
        public string dolazak { get; set; }
        [Required]
        public string biljeske { get; set; }
        [Required]
        public string prijedlog_roditelj { get; set; }
        [Required]
        public string prijedlog_skola { get; set; }
        [Required]
        public string dogovor { get; set; }
        [Required]
        public string izvijestiti { get; set; }
        [Required]
        public string sljedeci_susret { get; set; }
    }
}