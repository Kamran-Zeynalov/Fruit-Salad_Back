using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProperSalads.Migrations
{
    public partial class AddProducttools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FruitSalads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "FruitSalads",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "FruitSalads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ckals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fruitSaladId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ckals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ckals_FruitSalads_fruitSaladId",
                        column: x => x.fruitSaladId,
                        principalTable: "FruitSalads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fruitSaladId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_FruitSalads_fruitSaladId",
                        column: x => x.fruitSaladId,
                        principalTable: "FruitSalads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fruitSaladId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_FruitSalads_fruitSaladId",
                        column: x => x.fruitSaladId,
                        principalTable: "FruitSalads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ckals_fruitSaladId",
                table: "Ckals",
                column: "fruitSaladId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_fruitSaladId",
                table: "Feedbacks",
                column: "fruitSaladId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_fruitSaladId",
                table: "Sizes",
                column: "fruitSaladId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ckals");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "FruitSalads");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "FruitSalads");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FruitSalads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
