using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class addcoefficientsandprerequisites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coefficient",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameInGreek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coefficient", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Coefficient",
                columns: new[] { "Name", "NameInGreek" },
                values: new object[,]
                {
                    { "Artificial Intelligence and Machine Learning", "Τεχνητή Νοημοσύνη και Μηχανική Μάθηση" },
                    { "Computer Networks", "Δίκτυα Υπολογιστών" },
                    { "Computer Vision and Graphics", "Ανάλυση Εικόνας και Γραφικών" },
                    { "Database Engineering", "Ανάπτυξη Βάσεων Δεδομένων και Επιστήμη Δεδομένων" },
                    { "Game Development", "Ανάπτυξη Ηλεκτρονικών Παιχνιδιών" },
                    { "Mobile App Development", "Ανάπτυξη Εφαρμογών Κινητών Τηλεφώνων" },
                    { "Security", "Ασφάλεια" },
                    { "Software Technology", "Τεχνολογία Λογισμικού" },
                    { "User Interface and User Experience", "Αλληλεπίδραση Ανθρώπου-Υπολογιστή" },
                    { "Web Development", "Ανάπτυξη Διαδικτυακών Εφαρμογών" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coefficient");
        }
    }
}
