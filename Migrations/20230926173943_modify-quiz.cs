using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class modifyquiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerIds",
                table: "CourseQuizGrades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionIds",
                table: "CourseQuizGrades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerIds",
                table: "CourseQuizGrades");

            migrationBuilder.DropColumn(
                name: "QuestionIds",
                table: "CourseQuizGrades");
        }
    }
}
