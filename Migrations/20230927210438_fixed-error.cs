using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class fixederror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CorrectAnswer",
                value: "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CorrectAnswer",
                value: "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα.");
        }
    }
}
