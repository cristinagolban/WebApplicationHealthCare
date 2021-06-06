using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddWardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ward",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_WardId",
                table: "Doctors",
                column: "WardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Wards_WardId",
                table: "Doctors",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Wards_WardId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_WardId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "Ward",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
