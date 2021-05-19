using LibraryDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL {
    public class KonyvtarContext : DbContext{

        public KonyvtarContext(DbContextOptions<KonyvtarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            Kolcsonzes k1 = new Kolcsonzes { Id = 1, KonyvId = 1, OlvasoId = 1, Datum = new DateTime(2021, 05, 14) };
            Kolcsonzes k2 = new Kolcsonzes { Id = 2, KonyvId = 4, OlvasoId = 1, Datum = new DateTime(2021, 05, 14) };
            Kolcsonzes k3 = new Kolcsonzes { Id = 3, KonyvId = 6, OlvasoId = 3, Datum = new DateTime(2021, 05, 17) };

            //tesztadatok felvetele
            modelBuilder.Entity<Konyv>().HasData(
                new Konyv { Id = 1, Cim = "Egri csillagok", Iro = "Gárdonyi Géza", Kolcsonozve = true, KolcsonzesId=1},
                new Konyv { Id = 3, Cim = "A láthatatlan ember", Iro = "Gárdonyi Géza", Kolcsonozve=false },
                new Konyv { Id = 2, Cim = "Az ember tragédiája", Iro = "Madách Imre", Kolcsonozve=false },
                new Konyv { Id = 4, Cim = "Az arany ember", Iro = "Jókai Mór", Kolcsonozve = true, KolcsonzesId = 2 },
                new Konyv { Id = 5, Cim = "Rómeó és Júlia", Iro = "William Shakespeare", Kolcsonozve = false },
                new Konyv { Id = 6, Cim = "Pál utcai fiúk", Iro = "Molnár Ferenc", Kolcsonozve = true, KolcsonzesId = 3 }
                );
            modelBuilder.Entity<Olvaso>().HasData(
                new Olvaso { Id=1, Nev="Nagy Anna", Szul = new DateTime(2000, 08, 08) },
                new Olvaso { Id=2, Nev="Kis Tamás", Szul = new DateTime(2003, 01, 12)},
                new Olvaso { Id=3, Nev="Közepes Béla", Szul = new DateTime(2002, 12, 01)}
                );
            modelBuilder.Entity<Kolcsonzes>().HasData(k1, k2, k3) ;

            modelBuilder.Entity<Kolcsonzes>().HasOne(ko => ko.Olvaso)
                                          .WithMany(o => o.Kolcsonzesek)
                                          .HasForeignKey(ko => ko.OlvasoId);
        }

        public DbSet<Konyv> Konyvek { get; set; }
        public DbSet<Olvaso> Olvasok { get; set; }
        public DbSet<Kolcsonzes> Kolcsonzesek { get; set; }
    }
}
