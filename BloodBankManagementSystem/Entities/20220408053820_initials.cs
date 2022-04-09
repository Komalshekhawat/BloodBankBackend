using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodBankManagementSystem.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodDonorDonations_Blooddonors_BloodDonorID",
                table: "BloodDonorDonations");

            migrationBuilder.DropIndex(
                name: "IX_BloodDonorDonations_BloodDonorID",
                table: "BloodDonorDonations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BloodDonorDonations_BloodDonorID",
                table: "BloodDonorDonations",
                column: "BloodDonorID");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodDonorDonations_Blooddonors_BloodDonorID",
                table: "BloodDonorDonations",
                column: "BloodDonorID",
                principalTable: "Blooddonors",
                principalColumn: "BloodDonorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
