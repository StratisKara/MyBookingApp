using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.Migrations
{
    public partial class AccomodationChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxTraveler",
                table: "Accommodations",
                newName: "MinRentalPeriod");

            migrationBuilder.AddColumn<int>(
                name: "MaxRentalPeriod",
                table: "Accommodations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxRentalPeriod",
                table: "Accommodations");

            migrationBuilder.RenameColumn(
                name: "MinRentalPeriod",
                table: "Accommodations",
                newName: "MaxTraveler");
        }
    }
}
