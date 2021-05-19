using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryDAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Konyvek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kolcsonozve = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konyvek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Olvasok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Szul = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olvasok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kolcsonzesek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlvasoId = table.Column<int>(type: "int", nullable: false),
                    KonyvId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolcsonzesek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kolcsonzesek_Konyvek_KonyvId",
                        column: x => x.KonyvId,
                        principalTable: "Konyvek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kolcsonzesek_Olvasok_OlvasoId",
                        column: x => x.OlvasoId,
                        principalTable: "Olvasok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Konyvek",
                columns: new[] { "Id", "Cim", "Iro", "Kolcsonozve" },
                values: new object[,]
                {
                    { 1, "Egri csillagok", "Gárdonyi Géza", true },
                    { 3, "A láthatatlan ember", "Gárdonyi Géza", false },
                    { 2, "Az ember tragédiája", "Madách Imre", false },
                    { 4, "Az arany ember", "Jókai Mór", true },
                    { 5, "Romeó és Júlia", "William Shakespeare", false },
                    { 6, "Pál utcai fiúk", "Molnár Ferenc", true }
                });

            migrationBuilder.InsertData(
                table: "Olvasok",
                columns: new[] { "Id", "Nev", "Szul" },
                values: new object[,]
                {
                    { 1, "Nagy Anna", new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Kis Tamás", new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Közepes Béla", new DateTime(2002, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Kolcsonzesek",
                columns: new[] { "Id", "Datum", "KonyvId", "OlvasoId" },
                values: new object[] { 1, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Kolcsonzesek",
                columns: new[] { "Id", "Datum", "KonyvId", "OlvasoId" },
                values: new object[] { 2, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.InsertData(
                table: "Kolcsonzesek",
                columns: new[] { "Id", "Datum", "KonyvId", "OlvasoId" },
                values: new object[] { 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Kolcsonzesek_KonyvId",
                table: "Kolcsonzesek",
                column: "KonyvId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolcsonzesek_OlvasoId",
                table: "Kolcsonzesek",
                column: "OlvasoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kolcsonzesek");

            migrationBuilder.DropTable(
                name: "Konyvek");

            migrationBuilder.DropTable(
                name: "Olvasok");
        }
    }
}
