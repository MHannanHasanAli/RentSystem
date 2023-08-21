using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityCoreSetup.Migrations
{
    /// <inheritdoc />
    public partial class Dragon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_PaymentDate",
                table: "rents");

            migrationBuilder.AddColumn<string>(
                name: "_Month",
                table: "rents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_Month",
                table: "rents");

            migrationBuilder.AddColumn<DateTime>(
                name: "_PaymentDate",
                table: "rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
