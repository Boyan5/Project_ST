using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseApp.Data.Migrations
{
    public partial class QuantityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CupboardCapacity",
                table: "Sections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CupboardCapacity",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");
        }
    }
}
