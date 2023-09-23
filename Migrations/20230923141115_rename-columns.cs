using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class renamecolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatabaseManagementPercentage",
                table: "Users",
                newName: "DatabaseEngineeringPercentage");

            migrationBuilder.RenameColumn(
                name: "DatabaseManagement",
                table: "PostGraduateInstitutions",
                newName: "DatabaseEngineering");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "PostGraduateInstitutions",
                newName: "Hyperlink");

            migrationBuilder.RenameColumn(
                name: "DatabaseManagement",
                table: "Courses",
                newName: "DatabaseEngineering");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PostGraduateInstitutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PostGraduateInstitutions");

            migrationBuilder.RenameColumn(
                name: "DatabaseEngineeringPercentage",
                table: "Users",
                newName: "DatabaseManagementPercentage");

            migrationBuilder.RenameColumn(
                name: "Hyperlink",
                table: "PostGraduateInstitutions",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "DatabaseEngineering",
                table: "PostGraduateInstitutions",
                newName: "DatabaseManagement");

            migrationBuilder.RenameColumn(
                name: "DatabaseEngineering",
                table: "Courses",
                newName: "DatabaseManagement");
        }
    }
}
