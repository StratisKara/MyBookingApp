using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.Migrations
{
    public partial class undo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodations_Address_AddressId",
                table: "Accommodations");


            migrationBuilder.DropIndex(
                name: "IX_Accommodations_AddressId",
                table: "Accommodations");


            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Accommodations");


            migrationBuilder.AddForeignKey(
                name: "FK_Address_Accommodations_Id",
                table: "Address",
                column: "Id",
                principalTable: "Accommodations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Accommodations_Id",
                table: "Address");



            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Accommodations",
                type: "uniqueidentifier",
                nullable: true);


            migrationBuilder.CreateIndex(
                name: "IX_Accommodations_AddressId",
                table: "Accommodations",
                column: "AddressId");


            migrationBuilder.AddForeignKey(
                name: "FK_Accommodations_Address_AddressId",
                table: "Accommodations",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }
    }
}
