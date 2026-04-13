using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidSpace.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateConferenceAndConferenceAttendanceWithLinkByDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConferenceAttendances",
                columns: table => new
                {
                    ConferenceAttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceAttendances", x => x.ConferenceAttendanceId);
                    table.ForeignKey(
                        name: "FK_ConferenceAttendances_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conferences",
                columns: table => new
                {
                    ConferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConferenceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PharmaCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conferences", x => x.ConferenceId);
                    table.ForeignKey(
                        name: "FK_conferences_PharmaCompanys_PharmaCompanyId",
                        column: x => x.PharmaCompanyId,
                        principalTable: "PharmaCompanys",
                        principalColumn: "PharmaCompanyId");
                });

            migrationBuilder.CreateTable(
                name: "ConferenceDoctor",
                columns: table => new
                {
                    ConferencesConferenceId = table.Column<int>(type: "int", nullable: false),
                    DoctorsDoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceDoctor", x => new { x.ConferencesConferenceId, x.DoctorsDoctorId });
                    table.ForeignKey(
                        name: "FK_ConferenceDoctor_Doctors_DoctorsDoctorId",
                        column: x => x.DoctorsDoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConferenceDoctor_conferences_ConferencesConferenceId",
                        column: x => x.ConferencesConferenceId,
                        principalTable: "conferences",
                        principalColumn: "ConferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceAttendances_DoctorId",
                table: "ConferenceAttendances",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceDoctor_DoctorsDoctorId",
                table: "ConferenceDoctor",
                column: "DoctorsDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_conferences_PharmaCompanyId",
                table: "conferences",
                column: "PharmaCompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConferenceAttendances");

            migrationBuilder.DropTable(
                name: "ConferenceDoctor");

            migrationBuilder.DropTable(
                name: "conferences");
        }
    }
}
