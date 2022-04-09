using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodBankManagementSystem.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodBank",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<int>(type: "int", nullable: false),
                    BloodBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodBankId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<int>(type: "int", nullable: false),
                    BloodUnits = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBank", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BloodDonationCamps",
                columns: table => new
                {
                    BloodDonationCampID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodBankID = table.Column<int>(type: "int", nullable: false),
                    CampStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDonationCamps", x => x.BloodDonationCampID);
                });

            migrationBuilder.CreateTable(
                name: "Blooddonors",
                columns: table => new
                {
                    BloodDonorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blooddonors", x => x.BloodDonorID);
                });

            migrationBuilder.CreateTable(
                name: "BloodInventories",
                columns: table => new
                {
                    BloodInventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NumberofBottles = table.Column<int>(type: "int", nullable: false),
                    BloodBankID = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodInventories", x => x.BloodInventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    HospitalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.HospitalID);
                });

            migrationBuilder.CreateTable(
                name: "BloodDonorDonations",
                columns: table => new
                {
                    BloodDonationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodDonorID = table.Column<int>(type: "int", nullable: false),
                    BloodDonationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberofBottles = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    HBCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDonorDonations", x => x.BloodDonationID);
                    table.ForeignKey(
                        name: "FK_BloodDonorDonations_Blooddonors_BloodDonorID",
                        column: x => x.BloodDonorID,
                        principalTable: "Blooddonors",
                        principalColumn: "BloodDonorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorID",
                table: "BloodDonorDonations",
                column: "BloodDonorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodBank");

            migrationBuilder.DropTable(
                name: "BloodDonationCamps");

            migrationBuilder.DropTable(
                name: "BloodDonorDonations");

            migrationBuilder.DropTable(
                name: "BloodInventories");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Blooddonors");
        }
    }
}
