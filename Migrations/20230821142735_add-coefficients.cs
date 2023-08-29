using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class addcoefficients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AI_ML_Percentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CloudArchitectPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "HasCompletedIntroTest",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "ProjectManagerPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SecurityPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SoftwareEngineerPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SoftwareProgrammerPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UI_UX_Percentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "WebDevPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AI_ML_Percentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CloudArchitectPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasCompletedIntroTest",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProjectManagerPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SoftwareEngineerPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SoftwareProgrammerPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UI_UX_Percentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WebDevPercentage",
                table: "Users");
        }
    }
}
