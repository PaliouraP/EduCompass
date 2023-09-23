using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class modifycoefficientsandprerequisites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coefficient",
                table: "Coefficient");

            migrationBuilder.RenameTable(
                name: "Coefficient",
                newName: "Coefficients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coefficients",
                table: "Coefficients",
                column: "Name");

            migrationBuilder.CreateTable(
                name: "PrerequisiteCourses",
                columns: table => new
                {
                    BaseCourseUUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrerequisiteCourseUUID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrerequisiteCourses", x => new { x.BaseCourseUUID, x.PrerequisiteCourseUUID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrerequisiteCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coefficients",
                table: "Coefficients");

            migrationBuilder.RenameTable(
                name: "Coefficients",
                newName: "Coefficient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coefficient",
                table: "Coefficient",
                column: "Name");
        }
    }
}
