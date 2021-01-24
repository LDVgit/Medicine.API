using Microsoft.EntityFrameworkCore.Migrations;

namespace Medicine.API.Migrations
{
    public partial class Change_Models_Add_SpecialtyController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Doctors_PhysicianId",
                table: "Doctors");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specialties_PhysicianId",
                table: "Doctors",
                column: "PhysicianId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specialties_PhysicianId",
                table: "Doctors");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Doctors_PhysicianId",
                table: "Doctors",
                column: "PhysicianId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
