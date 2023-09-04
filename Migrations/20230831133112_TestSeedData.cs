using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class TestSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "UUID", "AI_ML", "ComputerNetworks", "ComputerVisionAndGraphics", "DatabaseManagement", "Description", "GameDev", "InIntro", "MobileAppDev", "Name", "Security", "Semester", "SoftwareEngineering", "UI_UX", "WebDev", "Year" },
                values: new object[,]
                {
                    { "ΠΛΠΛΗ37-2", 0, 0, 0, 0, "Αντικειμενοστρέφεια", 0, true, 0, "Αντικειμενοστρεφής Προγραμματισμός", 0, 2, 10, 0, 0, 1 },
                    { "ΠΛΠΛΗ90", 0, 8, 0, 0, "Μάθημα 1ου εξαμήνου", 0, true, 0, "Τεχνολογίες Διαδικτύου", 0, 1, 4, 1, 8, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "UUID",
                keyValue: "ΠΛΠΛΗ37-2");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "UUID",
                keyValue: "ΠΛΠΛΗ90");
        }
    }
}
