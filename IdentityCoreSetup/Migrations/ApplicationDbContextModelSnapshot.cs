﻿// <auto-generated />
using System;
using IdentityCoreSetup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentityCoreSetup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdentityCoreSetup.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("IdentityCoreSetup.Entities.Customer", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("_Id"));

                    b.Property<int?>("_Children")
                        .HasColumnType("int");

                    b.Property<string>("_ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("_DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("_EAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_HomeTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_RentCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("_TenancyBegan")
                        .HasColumnType("datetime2");

                    b.Property<string>("_UAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_UContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_UName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_UOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_URelation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("IdentityCoreSetup.Entities.Parents", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("_Id"));

                    b.Property<int>("_CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("_EAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_FOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_MOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id");

                    b.ToTable("parents");
                });

            modelBuilder.Entity("IdentityCoreSetup.Entities.Rent", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("_Id"));

                    b.Property<decimal>("_AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("_Arrears")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id");

                    b.ToTable("rents");
                });

            modelBuilder.Entity("IdentityCoreSetup.Entities.RentCard", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("_Id"));

                    b.Property<string>("_AddressOfLandlord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_AgentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_BusinessPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("_Commencement")
                        .HasColumnType("datetime2");

                    b.Property<string>("_ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_ContactOfLandlord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("_EmergencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_EmergencyTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Locality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_NameOfLandlord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_NameOfTenant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_RecoverableRent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_TypeOfPremises")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id");

                    b.ToTable("rentcards");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IdentityCoreSetup.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IdentityCoreSetup.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityCoreSetup.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IdentityCoreSetup.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
