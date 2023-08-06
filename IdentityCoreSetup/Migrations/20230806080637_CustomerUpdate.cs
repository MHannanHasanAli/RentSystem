﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityCoreSetup.Migrations
{
    /// <inheritdoc />
    public partial class CustomerUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_Email",
                table: "customers",
                newName: "_URelation");

            migrationBuilder.AlterColumn<string>(
                name: "_Name",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "_Children",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "_DateOfBirth",
                table: "customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_EAddress",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_EContactNo",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_EName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_EPosition",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_FAddress",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_FContactNo",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_FName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_FOccupation",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_Gender",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_HomeTown",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_MAddress",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_MContactNo",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_MName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_MOccupation",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_MaritalStatus",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_Nationality",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_Occupation",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "_TenancyBegan",
                table: "customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "_UAddress",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_UContactNo",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_UName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_UOccupation",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_Children",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_DateOfBirth",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_EAddress",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_EContactNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_EName",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_EPosition",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_FAddress",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_FContactNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_FName",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_FOccupation",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_Gender",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_HomeTown",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_MAddress",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_MContactNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_MName",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_MOccupation",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_MaritalStatus",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_Nationality",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_Occupation",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_TenancyBegan",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_UAddress",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_UContactNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_UName",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "_UOccupation",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "_URelation",
                table: "customers",
                newName: "_Email");

            migrationBuilder.AlterColumn<string>(
                name: "_Name",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
