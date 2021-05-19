using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities {
    public class Kolcsonzes {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("Olvaso")]
        public int OlvasoId { get; set; }
        public Olvaso Olvaso { get; set; }
        [ForeignKey("Konyv")]
        public int KonyvId { get; set; } 
        public Konyv Konyv { get; set; } 
    }
}
