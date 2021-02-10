using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityOneToMore.Migrations
{
    public partial class init_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osztaly",
                columns: table => new
                {
                    osztalyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    osztalyNev = table.Column<string>(maxLength: 10, nullable: false),
                    osztalyFonok = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osztaly", x => x.osztalyId);
                });

            migrationBuilder.CreateTable(
                name: "Tanulo",
                columns: table => new
                {
                    tanuloId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tanuloNev = table.Column<string>(maxLength: 50, nullable: false),
                    szuletesiDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanulo", x => x.tanuloId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osztaly");

            migrationBuilder.DropTable(
                name: "Tanulo");
        }
    }
}
