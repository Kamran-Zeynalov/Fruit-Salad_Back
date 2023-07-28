using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProperSalads.Migrations
{
    public partial class CreateFruitAndFruitSaladsRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vitamin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FruitSalads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitSalads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vitamin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FruitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitamin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vitamin_Fruits_FruitId",
                        column: x => x.FruitId,
                        principalTable: "Fruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaladAndFruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FruitSaladId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaladAndFruits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaladAndFruits_Fruits_FruitId",
                        column: x => x.FruitId,
                        principalTable: "Fruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaladAndFruits_FruitSalads_FruitSaladId",
                        column: x => x.FruitSaladId,
                        principalTable: "FruitSalads",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaladAndFruits_FruitId",
                table: "SaladAndFruits",
                column: "FruitId");

            migrationBuilder.CreateIndex(
                name: "IX_SaladAndFruits_FruitSaladId",
                table: "SaladAndFruits",
                column: "FruitSaladId");

            migrationBuilder.CreateIndex(
                name: "IX_Vitamin_FruitId",
                table: "Vitamin",
                column: "FruitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaladAndFruits");

            migrationBuilder.DropTable(
                name: "Vitamin");

            migrationBuilder.DropTable(
                name: "FruitSalads");

            migrationBuilder.DropTable(
                name: "Fruits");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
