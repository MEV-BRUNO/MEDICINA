using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nastavnik.Models
{
    public class razrednik_profil
    {
        [Required]
        public long id_profil { get; set; }
        [Required]
        public int id_pedagog { get; set; }
        [Required]
        public long id_nastavnik { get; set; }
        [Required]
        public int id_odjel { get; set; }
        [Required]
        public int godina { get; set; }
        [Required]
        public DateTime datum { get; set; }
        [Required]
        public int br_ucenika { get; set; }
        [Required]
        public string ponavljaci { get; set; }
        [Required]
        public string putnici { get; set; }
        [Required]
        public string novi_ucenici { get; set; }
        [Required]
        public string pucenik_bez_jednog { get; set; }
        [Required]
        public string ucenik_bez_oba { get; set; }
        [Required]
        public decimal uspjeh_prosjek { get; set; }
        [Required]
        public string ucenici_izdvojeni { get; set; }
        [Required]
        public string uucenici_slabi_uspjeh { get; set; }
        [Required]
        public string aktivnost { get; set; }
        [Required]
        public string ucenik_izvanskolske { get; set; }
        [Required]
        public string ucenik_los_uspjeh { get; set; }
        [Required]
        public string ucenik_opravdani { get; set; }
        [Required]
        public string ucenik_neopravdani { get; set; }
        [Required]
        public string ucenik_nedisciplina { get; set; }
        [Required]
        public string procjena_suradnje { get; set; }
        [Required]
        public string roditelji_neredoviti{ get; set; }
        [Required]
        public string upotreba_ukljucivanja { get; set; }
        [Required]
        public string nastavnici_klima { get; set; }
        [Required]
        public string suradnja_vijece { get; set; }
        [Required]
        public string prijedlozi { get; set; }


    }
}