using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProperSalads.Migrations
{
    public partial class DeleteVitaminprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vitamin",
                table: "Fruits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vitamin",
                table: "Fruits",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
