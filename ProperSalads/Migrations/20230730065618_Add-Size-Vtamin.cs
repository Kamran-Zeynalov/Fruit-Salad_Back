using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProperSalads.Migrations
{
    public partial class AddSizeVtamin : Migration
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
                    Ckal = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitSalads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vitamin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitamin", x => x.Id);
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
                name: "SaladAndFruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitId = table.Column<int>(type: "int", nullable: false),
                    FruitSaladId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FruitSaladSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitSaladId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitSaladSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FruitSaladSizes_FruitSalads_FruitSaladId",
                        column: x => x.FruitSaladId,
                        principalTable: "FruitSalads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FruitSaladSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FruitSaladVitamins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitId = table.Column<int>(type: "int", nullable: false),
                    VitaminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitSaladVitamins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FruitSaladVitamins_Fruits_FruitId",
                        column: x => x.FruitId,
                        principalTable: "Fruits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FruitSaladVitamins_Vitamin_VitaminId",
                        column: x => x.VitaminId,
                        principalTable: "Vitamin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_fruitSaladId",
                table: "Feedbacks",
                column: "fruitSaladId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitSaladSizes_FruitSaladId",
                table: "FruitSaladSizes",
                column: "FruitSaladId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitSaladSizes_SizeId",
                table: "FruitSaladSizes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitSaladVitamins_FruitId",
                table: "FruitSaladVitamins",
                column: "FruitId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitSaladVitamins_VitaminId",
                table: "FruitSaladVitamins",
                column: "VitaminId");

            migrationBuilder.CreateIndex(
                name: "IX_SaladAndFruits_FruitId",
                table: "SaladAndFruits",
                column: "FruitId");

            migrationBuilder.CreateIndex(
                name: "IX_SaladAndFruits_FruitSaladId",
                table: "SaladAndFruits",
                column: "FruitSaladId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FruitSaladSizes");

            migrationBuilder.DropTable(
                name: "FruitSaladVitamins");

            migrationBuilder.DropTable(
                name: "SaladAndFruits");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Vitamin");

            migrationBuilder.DropTable(
                name: "Fruits");

            migrationBuilder.DropTable(
                name: "FruitSalads");

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
