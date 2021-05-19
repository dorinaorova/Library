using System;
using System.Collections.Generic;

namespace LibraryBLL {
    public record Konyv {
        public int Id { get; set; }
        public string Cim { get; set; }
        public string Iro { get; set; }
        public bool Kolcsonozve { get; set; }
        public int KolcsonzesId { get; set; }
        public Kolcsonzes Kolcsonzes { get; }
    }
    public record Olvaso {
        public int Id { get; set; }
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public ICollection<Kolcsonzes> Kolcsonzesek { get; } = new List<Kolcsonzes>();
    }
    public record Kolcsonzes {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int OlvasoId { get; set; }
        public Olvaso Olvaso { get; set; }
        public int KonyvId { get; set; }
        public Konyv Konyv { get; set; }
    }
}