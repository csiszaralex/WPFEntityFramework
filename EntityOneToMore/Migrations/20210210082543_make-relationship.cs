using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityOneToMore.Migrations
{
    public partial class makerelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "osztalyId",
                table: "Tanulo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tanulo_osztalyId",
                table: "Tanulo",
                column: "osztalyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tanulo_Osztaly_osztalyId",
                table: "Tanulo",
                column: "osztalyId",
                principalTable: "Osztaly",
                principalColumn: "osztalyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanulo_Osztaly_osztalyId",
                table: "Tanulo");

            migrationBuilder.DropIndex(
                name: "IX_Tanulo_osztalyId",
                table: "Tanulo");

            migrationBuilder.DropColumn(
                name: "osztalyId",
                table: "Tanulo");
        }
    }
}
