using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseApp.Data.Migrations
{
    public partial class CapacityLeftAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Cupboards",
                newName: "MaxCapacity");

            migrationBuilder.AddColumn<float>(
                name: "CapacityLeft",
                table: "Cupboards",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapacityLeft",
                table: "Cupboards");

            migrationBuilder.RenameColumn(
                name: "MaxCapacity",
                table: "Cupboards",
                newName: "Capacity");
        }
    }
}
