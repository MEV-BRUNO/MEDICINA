using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class protokol_pracenja_ucenika
    {
        [Required]
        public long id_pracenje { get; set; }
        [Required]
        public int id_pedagog { get; set; }
        [Required]
        public long id_ucenik { get; set; }
        [Required]
        public int godina { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public string vrijeme { get; set; }
        [Required]
        public int id_odjel { get; set; }
        [Required]
        public string soc_eko { get; set; }
        [Required]
        public string cilj { get; set; }
        [Required]
        public string sposobnost { get; set; }
        [Required]
        public string prilagodljivost { get; set; }
        [Required]
        public string odnos { get; set; }
        [Required]
        public string doprinos { get; set; }
        [Required]
        public string opis { get; set; }
        [Required]
        public string zakljucak { get; set; }
    }
}