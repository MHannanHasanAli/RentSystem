using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityCoreSetup.Migrations
{
    /// <inheritdoc />
    public partial class Begin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    _Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Children = table.Column<int>(type: "int", nullable: true),
                    _ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _TenancyBegan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _HomeTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _UName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _UAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _UContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _UOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _URelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _RentCard = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    _Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _CustomerId = table.Column<int>(type: "int", nullable: false),
                    _MName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _MOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _EPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _FOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "rentcards",
                columns: table => new
                {
                    _Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _NameOfTenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _BusinessPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _EmergencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _EmergencyTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _NameOfLandlord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _AddressOfLandlord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _ContactOfLandlord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _TypeOfPremises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Commencement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _RecoverableRent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentcards", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "rents",
                columns: table => new
                {
                    _Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _CustomerId = table.Column<int>(type: "int", nullable: false),
                    _CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rents", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "parents");

            migrationBuilder.DropTable(
                name: "rentcards");

            migrationBuilder.DropTable(
                name: "rents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
