using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class initializedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coefficients",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameInGreek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coefficients", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InIntro = table.Column<bool>(type: "bit", nullable: false),
                    CourseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareEngineering = table.Column<int>(type: "int", nullable: false),
                    AI_ML = table.Column<int>(type: "int", nullable: false),
                    UI_UX = table.Column<int>(type: "int", nullable: false),
                    Security = table.Column<int>(type: "int", nullable: false),
                    ComputerNetworks = table.Column<int>(type: "int", nullable: false),
                    ComputerVisionAndGraphics = table.Column<int>(type: "int", nullable: false),
                    GameDev = table.Column<int>(type: "int", nullable: false),
                    DatabaseEngineering = table.Column<int>(type: "int", nullable: false),
                    WebDev = table.Column<int>(type: "int", nullable: false),
                    MobileAppDev = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hyperlink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareEngineering = table.Column<bool>(type: "bit", nullable: false),
                    AI_ML = table.Column<bool>(type: "bit", nullable: false),
                    UI_UX = table.Column<bool>(type: "bit", nullable: false),
                    Security = table.Column<bool>(type: "bit", nullable: false),
                    ComputerNetworks = table.Column<bool>(type: "bit", nullable: false),
                    ComputerVisionAndGraphics = table.Column<bool>(type: "bit", nullable: false),
                    GameDev = table.Column<bool>(type: "bit", nullable: false),
                    DatabaseEngineering = table.Column<bool>(type: "bit", nullable: false),
                    WebDev = table.Column<bool>(type: "bit", nullable: false),
                    MobileAppDev = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrerequisiteCourses",
                columns: table => new
                {
                    BaseCourseId = table.Column<int>(type: "int", nullable: false),
                    PrerequisiteCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrerequisiteCourses", x => new { x.BaseCourseId, x.PrerequisiteCourseId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    HasCompletedIntroTest = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftwareEngineerPercentage = table.Column<float>(type: "real", nullable: false),
                    AI_ML_Percentage = table.Column<float>(type: "real", nullable: false),
                    UI_UX_Percentage = table.Column<float>(type: "real", nullable: false),
                    SecurityPercentage = table.Column<float>(type: "real", nullable: false),
                    ComputerNetworksPercentage = table.Column<float>(type: "real", nullable: false),
                    ComputerVisionAndGraphicsPercentage = table.Column<float>(type: "real", nullable: false),
                    GameDevPercentage = table.Column<float>(type: "real", nullable: false),
                    DatabaseEngineeringPercentage = table.Column<float>(type: "real", nullable: false),
                    WebDevPercentage = table.Column<float>(type: "real", nullable: false),
                    MobileAppDevPercentage = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    FinalGrade = table.Column<int>(type: "int", nullable: false),
                    InterestScore = table.Column<int>(type: "int", nullable: false),
                    TestGrade = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseId",
                table: "Grades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_UserId",
                table: "Grades",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coefficients");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "PostGraduateInstitutions");

            migrationBuilder.DropTable(
                name: "PrerequisiteCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
