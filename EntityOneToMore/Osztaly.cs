using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityOneToMore
{
    class Osztaly
    {
        // Egy oldal
        [Key]
        public int osztalyId { get; set; }

        [StringLength(10)]
        [Required]
        public string osztalyNev { get; set; }

        public string osztalyFonok { get; set; }

        public ICollection<Tanulo> Tanulok { get; set; }
    }
}
