using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidSpace.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePharmaCompanyAndRepAndDrugWithLinkByUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PharmaCompanys",
                columns: table => new
                {
                    PharmaCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneactEmai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmaCompanys", x => x.PharmaCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    DrugId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    pharmaCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.DrugId);
                    table.ForeignKey(
                        name: "FK_Drugs_PharmaCompanys_pharmaCompanyId",
                        column: x => x.pharmaCompanyId,
                        principalTable: "PharmaCompanys",
                        principalColumn: "PharmaCompanyId");
                });

            migrationBuilder.CreateTable(
                name: "pharmaRepresentatives",
                columns: table => new
                {
                    PharmaRepresentativeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentativeStatus = table.Column<int>(type: "int", nullable: false),
                    PharmaCompanyId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharmaRepresentatives", x => x.PharmaRepresentativeId);
                    table.ForeignKey(
                        name: "FK_pharmaRepresentatives_PharmaCompanys_PharmaCompanyId",
                        column: x => x.PharmaCompanyId,
                        principalTable: "PharmaCompanys",
                        principalColumn: "PharmaCompanyId");
                    table.ForeignKey(
                        name: "FK_pharmaRepresentatives_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_pharmaCompanyId",
                table: "Drugs",
                column: "pharmaCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_pharmaRepresentatives_PharmaCompanyId",
                table: "pharmaRepresentatives",
                column: "PharmaCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_pharmaRepresentatives_UserId",
                table: "pharmaRepresentatives",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "pharmaRepresentatives");

            migrationBuilder.DropTable(
                name: "PharmaCompanys");
        }
    }
}
