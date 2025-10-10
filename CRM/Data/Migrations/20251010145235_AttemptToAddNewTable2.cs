using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class AttemptToAddNewTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_StaffId",
                table: "Devices",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Staff_StaffId",
                table: "Devices",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Staff_StaffId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_StaffId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Devices");
        }
    }
}
