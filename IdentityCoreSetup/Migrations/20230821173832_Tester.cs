using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityCoreSetup.Migrations
{
    /// <inheritdoc />
    public partial class Tester : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_CustomerId",
                table: "rents");

            migrationBuilder.RenameColumn(
                name: "_Type",
                table: "rents",
                newName: "_Receiver");

            migrationBuilder.RenameColumn(
                name: "_Amount",
                table: "rents",
                newName: "_AmountPaid");

            migrationBuilder.AddColumn<string>(
                name: "_Arrears",
                table: "rents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_Arrears",
                table: "rents");

            migrationBuilder.RenameColumn(
                name: "_Receiver",
                table: "rents",
                newName: "_Type");

            migrationBuilder.RenameColumn(
                name: "_AmountPaid",
                table: "rents",
                newName: "_Amount");

            migrationBuilder.AddColumn<int>(
                name: "_CustomerId",
                table: "rents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
