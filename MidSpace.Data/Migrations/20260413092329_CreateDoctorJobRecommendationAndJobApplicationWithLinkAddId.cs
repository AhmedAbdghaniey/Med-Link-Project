using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidSpace.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDoctorJobRecommendationAndJobApplicationWithLinkAddId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorJobRecommendations",
                columns: table => new
                {
                    DoctorJobRecommendationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecommendationMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRDecisionNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendationCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecommendationStatus = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    JobOpportunityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorJobRecommendations", x => x.DoctorJobRecommendationId);
                    table.ForeignKey(
                        name: "FK_DoctorJobRecommendations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId");
                    table.ForeignKey(
                        name: "FK_DoctorJobRecommendations_jobOpportunities_JobOpportunityId",
                        column: x => x.JobOpportunityId,
                        principalTable: "jobOpportunities",
                        principalColumn: "JobOpportunityId");
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationSubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CVFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverLetterText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobApplicationStatus = table.Column<int>(type: "int", nullable: false),
                    JobOpportunityId = table.Column<int>(type: "int", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.JobApplicationId);
                    table.ForeignKey(
                        name: "FK_JobApplications_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId");
                    table.ForeignKey(
                        name: "FK_JobApplications_jobOpportunities_JobOpportunityId",
                        column: x => x.JobOpportunityId,
                        principalTable: "jobOpportunities",
                        principalColumn: "JobOpportunityId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorJobRecommendations_DoctorId",
                table: "DoctorJobRecommendations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorJobRecommendations_JobOpportunityId",
                table: "DoctorJobRecommendations",
                column: "JobOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_DoctorId",
                table: "JobApplications",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobOpportunityId",
                table: "JobApplications",
                column: "JobOpportunityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorJobRecommendations");

            migrationBuilder.DropTable(
                name: "JobApplications");
        }
    }
}
