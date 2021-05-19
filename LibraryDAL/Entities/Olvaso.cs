using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities {
    public class Olvaso {
        [Key]
        public int Id { get; set; }
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public ICollection<Kolcsonzes> Kolcsonzesek { get; set; } = new List<Kolcsonzes>();
    }
}
