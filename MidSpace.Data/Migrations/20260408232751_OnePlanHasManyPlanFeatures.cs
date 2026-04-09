using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidSpace.Data.Migrations
{
    /// <inheritdoc />
    public partial class OnePlanHasManyPlanFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_plans_PlanId",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_plans",
                table: "plans");

            migrationBuilder.RenameTable(
                name: "plans",
                newName: "Plans");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plans",
                table: "Plans",
                column: "PlanId");

            migrationBuilder.CreateTable(
                name: "PlanFeatures",
                columns: table => new
                {
                    PlanFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanFeatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanFeatures", x => x.PlanFeatureId);
                    table.ForeignKey(
                        name: "FK_PlanFeatures_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanFeatures_PlanId",
                table: "PlanFeatures",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Plans_PlanId",
                table: "Subscriptions",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Plans_PlanId",
                table: "Subscriptions");

            migrationBuilder.DropTable(
                name: "PlanFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plans",
                table: "Plans");

            migrationBuilder.RenameTable(
                name: "Plans",
                newName: "plans");

            migrationBuilder.AddPrimaryKey(
                name: "PK_plans",
                table: "plans",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_plans_PlanId",
                table: "Subscriptions",
                column: "PlanId",
                principalTable: "plans",
                principalColumn: "PlanId");
        }
    }
}
