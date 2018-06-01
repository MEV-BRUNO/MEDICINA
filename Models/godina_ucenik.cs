using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class godina_ucenik
    {
        [Required]
        public long id_ucenik { get; set; }
        [Required]
        public int id_odjel { get; set; }
        [Required]
        public int id_skola { get; set; }
        [Required]
        public int godina { get; set; }
        [Required]
        public int id_razrednik { get; set; }
        [Required]
        public int ponavlja { get; set; }
        [Required]
        public int putnik { get; set; }
        [Required]
        public string zaduzenja { get; set; }
    }
}