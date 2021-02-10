using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityOneToMore.Migrations
{
    public partial class UpdateModelCreatingFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Osztaly",
                columns: new[] { "osztalyId", "osztalyFonok", "osztalyNev" },
                values: new object[] { 1, "Józsi", "9A" });

            migrationBuilder.InsertData(
                table: "Osztaly",
                columns: new[] { "osztalyId", "osztalyFonok", "osztalyNev" },
                values: new object[] { 2, "Kowa", "13A" });

            migrationBuilder.InsertData(
                table: "Tanulo",
                columns: new[] { "tanuloId", "osztalyId", "szuletesiDatum", "tanuloNev" },
                values: new object[] { 1, 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Béla" });

            migrationBuilder.InsertData(
                table: "Tanulo",
                columns: new[] { "tanuloId", "osztalyId", "szuletesiDatum", "tanuloNev" },
                values: new object[] { 2, 1, new DateTime(2005, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cili" });

            migrationBuilder.InsertData(
                table: "Tanulo",
                columns: new[] { "tanuloId", "osztalyId", "szuletesiDatum", "tanuloNev" },
                values: new object[] { 3, 2, new DateTime(2003, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kata" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tanulo",
                keyColumn: "tanuloId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tanulo",
                keyColumn: "tanuloId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tanulo",
                keyColumn: "tanuloId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Osztaly",
                keyColumn: "osztalyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Osztaly",
                keyColumn: "osztalyId",
                keyValue: 2);
        }
    }
}
