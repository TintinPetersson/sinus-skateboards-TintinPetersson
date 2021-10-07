using Microsoft.EntityFrameworkCore.Migrations;

namespace SinusSkateboards.DAL.Migrations
{
    public partial class newTablejh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
