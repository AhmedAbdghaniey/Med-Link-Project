using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidSpace.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateHospitalAndJobOpportunityWithLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorCertificates_Doctors_DoctorID",
                table: "DoctorCertificates");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Patients_PatientID",
                table: "PatientAllergies");

            migrationBuilder.AlterColumn<int>(
                name: "PatientID",
                table: "PatientAllergies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "DoctorCertificates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficialWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "jobOpportunities",
                columns: table => new
                {
                    JobOpportunityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaximumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApplicationDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmploymentType = table.Column<int>(type: "int", nullable: false),
                    JobOpportunityStatus = table.Column<int>(type: "int", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobOpportunities", x => x.JobOpportunityId);
                    table.ForeignKey(
                        name: "FK_jobOpportunities_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_jobOpportunities_HospitalId",
                table: "jobOpportunities",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorCertificates_Doctors_DoctorID",
                table: "DoctorCertificates",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Patients_PatientID",
                table: "PatientAllergies",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorCertificates_Doctors_DoctorID",
                table: "DoctorCertificates");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Patients_PatientID",
                table: "PatientAllergies");

            migrationBuilder.DropTable(
                name: "jobOpportunities");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.AlterColumn<int>(
                name: "PatientID",
                table: "PatientAllergies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "DoctorCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorCertificates_Doctors_DoctorID",
                table: "DoctorCertificates",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Patients_PatientID",
                table: "PatientAllergies",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
