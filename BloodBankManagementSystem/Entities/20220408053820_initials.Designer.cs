﻿// <auto-generated />
using System;
using BloodBankManagementSystem.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodBankManagementSystem.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20220408053820_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodBankManagementSystem.Entities.BloodBank", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodBankId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodBankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BloodUnits")
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("BloodBank");
                });

            modelBuilder.Entity("BloodBankManagementSystem.Entities.BloodDonationCamp", b =>
                {
                    b.Property<int>("BloodDonationCampID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BloodBankID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CampEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CampName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CampStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodDonationCampID");

                    b.ToTable("BloodDonationCamps");
                });

            modelBuilder.Entity("BloodBankManagementSystem.Entities.BloodDonor", b =>
                {
                    b.Property<int>("BloodDonorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileNo")
                        .HasColumnType("int");

                    b.HasKey("BloodDonorID");

                    b.ToTable("Blooddonors");
                });

            modelBuilder.Entity("BloodBankManagementSystem.Entities.BloodDonorDonation", b =>
                {
                    b.Property<int>("BloodDonationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BloodDonationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BloodDonorID")
                        .HasColumnType("int");

                    b.Property<int>("HBCount")
                        .HasColumnType("int");

                    b.Property<int>("NumberofBottles")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("BloodDonationID");

                    b.ToTable("BloodDonorDonations");
                });

            modelBuilder.Entity("BloodBankManagementSystem.Entities.BloodInventory", b =>
                {
                    b.Property<int>("BloodInventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BloodBankID")
                        .HasColumnType("int");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberofBottles")
                        .HasColumnType("int");

                    b.HasKey("BloodInventoryID");

                    b.ToTable("BloodInventories");
                });

            modelBuilder.Entity("BloodBankManagementSystem.Entities.Hospital", b =>
                {
                    b.Property<int>("HospitalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalID");

                    b.ToTable("Hospital");
                });
#pragma warning restore 612, 618
        }
    }
}
