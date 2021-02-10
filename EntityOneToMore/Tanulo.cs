using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityOneToMore
{
    class Tanulo
    {
        // Több oldal
        [Key]
        public int tanuloId { get; set; }

        [StringLength(50)]
        [Required]
        public string tanuloNev { get; set; }

        public DateTime szuletesiDatum { get; set; }

        //Ez a 2 együtt a kapcsolat
        public Osztaly Osztaly { get; set; }
        public int? osztalyId { get; set; } //!KEll a név egyezés
    }
}
