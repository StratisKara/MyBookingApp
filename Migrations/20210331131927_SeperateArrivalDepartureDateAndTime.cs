using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.Migrations
{
    public partial class SeperateArrivalDepartureDateAndTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartureDateTime",
                table: "Booking",
                newName: "DepartureDate");

            migrationBuilder.RenameColumn(
                name: "ArrivalDateTime",
                table: "Booking",
                newName: "ArrivalDate");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Booking",
                newName: "DepartureDateTime");

            migrationBuilder.RenameColumn(
                name: "ArrivalDate",
                table: "Booking",
                newName: "ArrivalDateTime");
        }
    }
}
