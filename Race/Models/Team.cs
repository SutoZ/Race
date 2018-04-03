using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Race.Models
{
    [Table("Team")]    
    [ScaffoldTable(true)]
    public class Team
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Column(Order = 1)]
        [DataType(DataType.Date)]
        [Display(Name = "Alapítás éve")]
        public DateTime YearOfEstablishment { get; set; }

        [Column(Order = 2)]
        [Display(Name = "Megnyert világbajnokságok száma")]
        public int NumberOfWonChampionShip { get; set; }

        [Column(Order = 3)]
        [Display(Name = "Nevezési díj")]
        public bool EntryFee { get; set; }

    }
}