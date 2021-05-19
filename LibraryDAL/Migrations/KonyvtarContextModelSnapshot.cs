﻿// <auto-generated />
using System;
using LibraryDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryDAL.Migrations
{
    [DbContext(typeof(KonyvtarContext))]
    partial class KonyvtarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryDAL.Entities.Kolcsonzes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KonyvId")
                        .HasColumnType("int");

                    b.Property<int>("OlvasoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KonyvId");

                    b.HasIndex("OlvasoId");

                    b.ToTable("Kolcsonzesek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Datum = new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KonyvId = 1,
                            OlvasoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Datum = new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KonyvId = 4,
                            OlvasoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Datum = new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KonyvId = 6,
                            OlvasoId = 3
                        });
                });

            modelBuilder.Entity("LibraryDAL.Entities.Konyv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Kolcsonozve")
                        .HasColumnType("bit");

                    b.Property<int>("KolcsonzesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Konyvek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cim = "Egri csillagok",
                            Iro = "Gárdonyi Géza",
                            Kolcsonozve = true,
                            KolcsonzesId = 1
                        },
                        new
                        {
                            Id = 3,
                            Cim = "A láthatatlan ember",
                            Iro = "Gárdonyi Géza",
                            Kolcsonozve = false,
                            KolcsonzesId = 0
                        },
                        new
                        {
                            Id = 2,
                            Cim = "Az ember tragédiája",
                            Iro = "Madách Imre",
                            Kolcsonozve = false,
                            KolcsonzesId = 0
                        },
                        new
                        {
                            Id = 4,
                            Cim = "Az arany ember",
                            Iro = "Jókai Mór",
                            Kolcsonozve = true,
                            KolcsonzesId = 2
                        },
                        new
                        {
                            Id = 5,
                            Cim = "Romeó és Júlia",
                            Iro = "William Shakespeare",
                            Kolcsonozve = false,
                            KolcsonzesId = 0
                        },
                        new
                        {
                            Id = 6,
                            Cim = "Pál utcai fiúk",
                            Iro = "Molnár Ferenc",
                            Kolcsonozve = true,
                            KolcsonzesId = 3
                        });
                });

            modelBuilder.Entity("LibraryDAL.Entities.Olvaso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Szul")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Olvasok");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nev = "Nagy Anna",
                            Szul = new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Nev = "Kis Tamás",
                            Szul = new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Nev = "Közepes Béla",
                            Szul = new DateTime(2002, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LibraryDAL.Entities.Kolcsonzes", b =>
                {
                    b.HasOne("LibraryDAL.Entities.Konyv", "Konyv")
                        .WithMany()
                        .HasForeignKey("KonyvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryDAL.Entities.Olvaso", "Olvaso")
                        .WithMany("Kolcsonzesek")
                        .HasForeignKey("OlvasoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Konyv");

                    b.Navigation("Olvaso");
                });

            modelBuilder.Entity("LibraryDAL.Entities.Olvaso", b =>
                {
                    b.Navigation("Kolcsonzesek");
                });
#pragma warning restore 612, 618
        }
    }
}