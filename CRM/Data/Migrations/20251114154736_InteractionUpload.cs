using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class InteractionUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachments_Projects_ProjectId",
                table: "ProjectAttachments");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectId",
                table: "ProjectAttachments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachments_Projects_ProjectId",
                table: "ProjectAttachments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachments_Projects_ProjectId",
                table: "ProjectAttachments");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectId",
                table: "ProjectAttachments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachments_Projects_ProjectId",
                table: "ProjectAttachments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
