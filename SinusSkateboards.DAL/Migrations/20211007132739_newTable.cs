using Microsoft.EntityFrameworkCore.Migrations;

namespace SinusSkateboards.DAL.Migrations
{
    public partial class newTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderModelId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderModelId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderModelId",
                        column: x => x.OrderModelId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderModelId",
                table: "OrderProducts",
                column: "OrderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductModelId",
                table: "OrderProducts",
                column: "ProductModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderModelId",
                table: "Products",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderModelId",
                table: "Products",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
