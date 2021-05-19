using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClient {
  
        public class Konyv {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("cim")]
            public string cim { get; set; }
            [JsonProperty("iro")]
            public string iro { get; set; }
            [JsonProperty("kolcsonozve")]
            public bool kolcsonozve { get; set; }
            [JsonProperty("kolcsonzesId")]
            public int kolcsonzesId { get; set; }
            [JsonProperty("kolcsonzek")]
            public Kolcsonzes kolcsonzes { get; set; }

            public override string ToString() {
            string kolcs = "";
            if (kolcsonozve) kolcs = " +";
            return $"{iro} - {cim}"+kolcs;
            }
        }

        public class Kolcsonzes {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("datum")]
        public DateTime Datum { get; set; }
        [JsonProperty("olvasoId")]
        public int OlvasoId { get; set; }
        [JsonProperty("olvaso")]
        public Olvaso Olvaso { get; set; }
        [JsonProperty("konyvId")]
        public int KonyvId { get; set; }
        [JsonProperty("konyv")]
        public Konyv Konyv { get; set; }

        public override string ToString() {
            return $" {Konyv.iro} - {Konyv.cim} ({Konyv.kolcsonzesId}): {Datum.Year}.{Datum.Month}.{Datum.Day}.";
        }
    }

        public class Olvaso {
        [JsonProperty("nev")]
        public string Nev { get; set; }
        [JsonProperty("szul")]
        public DateTime Szul { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("kolcsonzesek")]
        public ICollection<Kolcsonzes> Kolcsonzesek { get; } = new List<Kolcsonzes>();
        public override string ToString() {
            return $"{Nev} ({(DateTime.Now-Szul).Days/365})";
        }
    }

    
}
