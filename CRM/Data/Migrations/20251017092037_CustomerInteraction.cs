using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInteraction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerInteractionsId",
                table: "ProjectAttachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerInteractions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InteractionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInteractions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerInteractions_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAttachments_CustomerInteractionsId",
                table: "ProjectAttachments",
                column: "CustomerInteractionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInteractions_ProjectId",
                table: "CustomerInteractions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInteractions_StaffId",
                table: "CustomerInteractions",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachments_CustomerInteractions_CustomerInteractionsId",
                table: "ProjectAttachments",
                column: "CustomerInteractionsId",
                principalTable: "CustomerInteractions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachments_CustomerInteractions_CustomerInteractionsId",
                table: "ProjectAttachments");

            migrationBuilder.DropTable(
                name: "CustomerInteractions");

            migrationBuilder.DropIndex(
                name: "IX_ProjectAttachments_CustomerInteractionsId",
                table: "ProjectAttachments");

            migrationBuilder.DropColumn(
                name: "CustomerInteractionsId",
                table: "ProjectAttachments");
        }
    }
}
