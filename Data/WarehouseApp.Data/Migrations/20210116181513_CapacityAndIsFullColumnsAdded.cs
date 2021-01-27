using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseApp.Data.Migrations
{
    public partial class CapacityAndIsFullColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Capacity",
                table: "Products",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "Capacity",
                table: "Cupboards",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "IsFull",
                table: "Cupboards",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsFull",
                table: "Cupboards");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Cupboards",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
