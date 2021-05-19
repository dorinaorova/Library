using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryDAL.Migrations
{
    public partial class kapcsolatok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KolcsonzesId",
                table: "Konyvek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Konyvek",
                keyColumn: "Id",
                keyValue: 1,
                column: "KolcsonzesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Konyvek",
                keyColumn: "Id",
                keyValue: 4,
                column: "KolcsonzesId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Konyvek",
                keyColumn: "Id",
                keyValue: 6,
                column: "KolcsonzesId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KolcsonzesId",
                table: "Konyvek");
        }
    }
}
