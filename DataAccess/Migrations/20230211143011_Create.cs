using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Klavye" },
                    { 2, "Monitör" },
                    { 3, "Mouse" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, "Oyuncu klavyesi", 500m, "Rampage" },
                    { 2, 1, "RGB Oyuncu klavyesi", 250m, "Micropack" },
                    { 3, 1, "Beyaz kablosuz Q klavye", 200m, "Everest" },
                    { 4, 1, "Kablosuz Q klavye", 150m, "logitech" },
                    { 5, 2, "IPS Ekran Monitör", 6000m, "Huawei" },
                    { 6, 2, "Curved oyuncu monitörü", 6000m, "Samsung" },
                    { 7, 2, "IPS Ekran moniör", 5000m, "Samsung" },
                    { 8, 2, "IPS Ekran moniör", 5000m, "LG" },
                    { 9, 2, "Cruved moniör", 4500m, "LG" },
                    { 10, 3, "Kablosuz mouse", 500m, "logitech" },
                    { 11, 3, "Kablosuz mouse", 500m, "Everest" },
                    { 12, 3, "Kablosuz oyunucu mouse", 1500m, "Rampage" },
                    { 13, 3, "Kablosuz oyunucu mouse", 1500m, "Rampage" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
