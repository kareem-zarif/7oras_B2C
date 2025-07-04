using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _7oras.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Persons_CustomerId1",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CustomerId1",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Reports");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId1",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CustomerId1",
                table: "Reports",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Persons_CustomerId1",
                table: "Reports",
                column: "CustomerId1",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
