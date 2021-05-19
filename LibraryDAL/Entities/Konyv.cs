using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities {
    public class Konyv {
        [Key]
        public int Id { get; set; }
        public string Cim { get; set; }
        public string Iro { get; set; }
        public bool Kolcsonozve { get; set; }
        [ForeignKey("Kolcsonzes")]
        public int KolcsonzesId { get; set; }
        public Kolcsonzes Kolcsonzes { get; }
    }
}
