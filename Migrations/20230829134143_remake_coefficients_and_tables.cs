using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class remake_coefficients_and_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoftwareProgrammerPercentage",
                table: "Users",
                newName: "MobileAppDevPercentage");

            migrationBuilder.RenameColumn(
                name: "ProjectManagerPercentage",
                table: "Users",
                newName: "GameDevPercentage");

            migrationBuilder.RenameColumn(
                name: "CloudArchitectPercentage",
                table: "Users",
                newName: "DatabaseManagementPercentage");

            migrationBuilder.AddColumn<float>(
                name: "ComputerNetworksPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ComputerVisionAndGraphicsPercentage",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    UUID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InIntro = table.Column<bool>(type: "bit", nullable: false),
                    SoftwareEngineering = table.Column<int>(type: "int", nullable: false),
                    AI_ML = table.Column<int>(type: "int", nullable: false),
                    UI_UX = table.Column<int>(type: "int", nullable: false),
                    Security = table.Column<int>(type: "int", nullable: false),
                    ComputerNetworks = table.Column<int>(type: "int", nullable: false),
                    ComputerVisionAndGraphics = table.Column<int>(type: "int", nullable: false),
                    GameDev = table.Column<int>(type: "int", nullable: false),
                    DatabaseManagement = table.Column<int>(type: "int", nullable: false),
                    WebDev = table.Column<int>(type: "int", nullable: false),
                    MobileAppDev = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareEngineering = table.Column<bool>(type: "bit", nullable: false),
                    AI_ML = table.Column<bool>(type: "bit", nullable: false),
                    UI_UX = table.Column<bool>(type: "bit", nullable: false),
                    Security = table.Column<bool>(type: "bit", nullable: false),
                    ComputerNetworks = table.Column<bool>(type: "bit", nullable: false),
                    ComputerVisionAndGraphics = table.Column<bool>(type: "bit", nullable: false),
                    GameDev = table.Column<bool>(type: "bit", nullable: false),
                    DatabaseManagement = table.Column<bool>(type: "bit", nullable: false),
                    WebDev = table.Column<bool>(type: "bit", nullable: false),
                    MobileAppDev = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseUUID = table.Column<int>(type: "int", nullable: false),
                    FinalGrade = table.Column<int>(type: "int", nullable: false),
                    InterestScore = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseUUID",
                        column: x => x.CourseUUID,
                        principalTable: "Courses",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseUUID",
                table: "Grades",
                column: "CourseUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_UserId",
                table: "Grades",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "PostGraduateInstitutions");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropColumn(
                name: "ComputerNetworksPercentage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ComputerVisionAndGraphicsPercentage",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "MobileAppDevPercentage",
                table: "Users",
                newName: "SoftwareProgrammerPercentage");

            migrationBuilder.RenameColumn(
                name: "GameDevPercentage",
                table: "Users",
                newName: "ProjectManagerPercentage");

            migrationBuilder.RenameColumn(
                name: "DatabaseManagementPercentage",
                table: "Users",
                newName: "CloudArchitectPercentage");
        }
    }
}
