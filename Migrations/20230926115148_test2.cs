using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoefficientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameInGreek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Name);
                });

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
                name: "CourseHasCoefficients",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CoefficientName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseHasCoefficients", x => new { x.CourseId, x.CoefficientName });
                });

            migrationBuilder.CreateTable(
                name: "CourseQuizGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TimeStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeFinished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseQuizGrades", x => x.Id);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AudioFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    FinalGrade = table.Column<int>(type: "int", nullable: false),
                    InterestScore = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => new { x.UserId, x.CourseId });
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateInstitutionHasCoefficients",
                columns: table => new
                {
                    PostGraduateInstitutionId = table.Column<int>(type: "int", nullable: false),
                    CoefficientName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasCoefficient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateInstitutionHasCoefficients", x => new { x.PostGraduateInstitutionId, x.CoefficientName });
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeSpents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TotalTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSpents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserHasCoefficients",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CoefficientName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHasCoefficients", x => new { x.UserId, x.CoefficientName });
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
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "Name", "CoefficientName", "NameInGreek" },
                values: new object[,]
                {
                    { "3D Artist/Animator", "ComputerVisionAndGraphics", "Σχεδιαστής Τρισδιάστατων Σχεδίων" },
                    { "Accessibility Specialist", "UI_UX", "Ειδικός Προσβασιμότητας" },
                    { "Android Developer", "MobileAppDev", "Προγραμματιστής Εφαρμογών για Android" },
                    { "Back-End Developer", "WebDev", "Προγραμματιστής Back-End" },
                    { "Big Data Engineer", "DatabaseEngineering", "Μηχανικός Δεδομένων Μεγάλου Όγκου" },
                    { "Cloud Data Engineer", "DatabaseEngineering", "Μηχανικός Δεδομένων Υπολογιστικής Νέφους" },
                    { "Computer Graphics Programmer", "ComputerVisionAndGraphics", "Προγραμματιστής Γραφικών" },
                    { "Computer Vision Engineer", "ComputerVisionAndGraphics", "Μηχανικός Γραφικών Υπολογιστών" },
                    { "Data Architect", "DatabaseEngineering", "Αρχιτέκτονας Δεδομένων" },
                    { "Data Scientist", "AI_ML", "Επιστήμονας Δεδομένων" },
                    { "Database Developer", "DatabaseEngineering", "Προγραμματιστής Βάσεων Δεδομένων" },
                    { "DevOps Engineer", "SoftwareEngineering", "Μηχανικός DevOps" },
                    { "Front-End Developer", "UI_UX", "Προγραμματιστής Front-End" },
                    { "Full-Stack Developer", "SoftwareEngineering", "Προγραμματιστής Full-Stack" },
                    { "Games Designer", "GameDev", "Σχεδιαστής Ηλεκτρονικών Παιχνιδιών" },
                    { "Games Programmer", "GameDev", "Προγραμματιστής Ηλεκτρονικών Παιχνιδιών" },
                    { "Incident Responder", "Security", "Ανταποκριτής Συμβάντων" },
                    { "iOS Developer", "MobileAppDev", "Προγραμματιστής Εφαρμογών για iOS" },
                    { "Level Designer", "GameDev", "Σχεδιαστής Επιπέδων Ηλεκτρονικών Παιχνιδιών" },
                    { "Machine Learning Engineer", "AI_ML", "Μηχανικός Μηχανικής Μάθησης" },
                    { "Mobile App Developer", "MobileAppDev", "Προγραμματιστής Εφαρμογών Κινητών Τηλεφώνων" },
                    { "Mobile UI/UX Designer", "MobileAppDev", "Σχεδιαστής UI/UX για Εφαρμογές Κινητών Τηλεφώνων" },
                    { "N.L.P. Engineer", "AI_ML", "Μηχανικός Επεξεργασίας Φυσικής Γλώσσας" },
                    { "Network Administrator", "ComputerNetworks", "Διαχειριστής Δικτύων" },
                    { "Network Engineer", "ComputerNetworks", "Μηχανικός Δικτύων" },
                    { "Network Security Specialist", "ComputerNetworks", "Ειδικός Ασφάλειας Δικτύων" },
                    { "Penetration Tester", "Security", "Ελεγκτής Διείσδυσης" },
                    { "Robotics Engineer", "AI_ML", "Μηχανικός Ρομποτικής" },
                    { "Security Analyst", "Security", "Αναλυτής Ασφαλείας" },
                    { "Security Engineer", "Security", "Μηχανικός Ασφαλείας" },
                    { "Software Consultant", "SoftwareEngineering", "Σύμβουλος Λογισμικού" },
                    { "Software Developer", "SoftwareEngineering", "Προγραμματιστής Λογισμικού" },
                    { "UI/UX Designer", "UI_UX", "Σχεδιαστής UI/UX" },
                    { "Virtual Reality Developer", "ComputerVisionAndGraphics", "Προγραμματιστής Εικονικής Πραγματικότητας" },
                    { "Visual Designer", "UI_UX", "Οπτικός Σχεδιαστής" },
                    { "Web App Developer", "WebDev", "Προγραμματιστής Διαδικτυακών Εφαρμογών" },
                    { "Web Designer", "WebDev", "Σχεδιαστής Ιστοσελίδων" }
                });

            migrationBuilder.InsertData(
                table: "Coefficients",
                columns: new[] { "Name", "NameInGreek" },
                values: new object[,]
                {
                    { "AI_ML", "Τεχνητή Νοημοσύνη και Μηχανική Μάθηση" },
                    { "ComputerNetworks", "Δίκτυα Υπολογιστών" },
                    { "ComputerVisionAndGraphics", "Ανάλυση Εικόνας και Γραφικών" },
                    { "DatabaseEngineering", "Ανάπτυξη Βάσεων Δεδομένων και Επιστήμη Δεδομένων" },
                    { "GameDev", "Ανάπτυξη Ηλεκτρονικών Παιχνιδιών" },
                    { "MobileAppDev", "Ανάπτυξη Εφαρμογών Κινητών Τηλεφώνων" },
                    { "Security", "Ασφάλεια" },
                    { "SoftwareEngineering", "Τεχνολογία Λογισμικού" },
                    { "UI_UX", "Αλληλεπίδραση Ανθρώπου-Υπολογιστή" },
                    { "WebDev", "Ανάπτυξη Διαδικτυακών Εφαρμογών" }
                });

            migrationBuilder.InsertData(
                table: "CourseHasCoefficients",
                columns: new[] { "CoefficientName", "CourseId", "Value" },
                values: new object[,]
                {
                    { "MobileAppDev", 1, 10 },
                    { "SoftwareEngineering", 1, 10 },
                    { "WebDev", 1, 5 },
                    { "DatabaseEngineering", 2, 1 },
                    { "GameDev", 2, 1 },
                    { "MobileAppDev", 2, 3 },
                    { "SoftwareEngineering", 2, 10 },
                    { "WebDev", 2, 4 },
                    { "MobileAppDev", 3, 2 },
                    { "SoftwareEngineering", 3, 10 },
                    { "WebDev", 3, 1 },
                    { "AI_ML", 4, 2 },
                    { "ComputerVisionAndGraphics", 4, 7 },
                    { "GameDev", 4, 10 },
                    { "AI_ML", 5, 10 },
                    { "GameDev", 5, 8 },
                    { "GameDev", 6, 10 },
                    { "SoftwareEngineering", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AudioFileName", "Content", "Description", "Name", "Semester", "UUID" },
                values: new object[,]
                {
                    { 1, "", "", "", "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού", 7, "ΠΛΘΕΤΚΑΕ01" },
                    { 2, "", "", "", "Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών", 3, "ΠΛΠΛΗ37-3" },
                    { 3, "", "", "", "Αντικειμενοστρεφής Προγραμματισμός", 2, "ΠΛΠΛΗ37-2" },
                    { 4, "", "", "", "Εικονική Πραγματικότητα", 7, "ΠΛΕΙΚ03" },
                    { 5, "", "", "", "Ευφυείς Πράκτορες", 8, "ΠΛΕΥΠΡ01" },
                    { 6, "", "", "", "Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών", 7, "ΠΛΤΑΗΠ01" }
                });

            migrationBuilder.InsertData(
                table: "PostGraduateInstitutionHasCoefficients",
                columns: new[] { "CoefficientName", "PostGraduateInstitutionId", "HasCoefficient" },
                values: new object[,]
                {
                    { "AI_ML", 1, true },
                    { "DatabaseEngineering", 1, true },
                    { "AI_ML", 2, true },
                    { "DatabaseEngineering", 2, true },
                    { "Security", 2, true },
                    { "AI_ML", 3, true },
                    { "SoftwareEngineering", 3, true },
                    { "Networks", 4, true },
                    { "Security", 4, true },
                    { "WebDev", 4, true },
                    { "Networks", 5, true },
                    { "Security", 5, true },
                    { "Security", 6, true },
                    { "WebDev", 6, true },
                    { "AI_ML", 7, true },
                    { "DatabaseEngineering", 7, true },
                    { "Networks", 8, true },
                    { "AI_ML", 9, true },
                    { "Networks", 9, true },
                    { "WebDev", 9, true },
                    { "AI_ML", 10, true },
                    { "DatabaseEngineering", 10, true },
                    { "SoftwareEngineering", 11, true },
                    { "ComputerVisionAndGraphics", 12, true },
                    { "GameDev", 12, true },
                    { "MobileAppDev", 13, true },
                    { "UI_UX", 13, true },
                    { "WebDev", 13, true },
                    { "UI_UX", 14, true }
                });

            migrationBuilder.InsertData(
                table: "PostGraduateInstitutions",
                columns: new[] { "Id", "Department", "Description", "Hyperlink", "Name", "Town" },
                values: new object[,]
                {
                    { 1, "Επιστήμη Δεδομένων και Μηχανική Μάθηση", "", "https://dsml.ece.ntua.gr/", "Εθνικό Μετσόβειο Πολυτεχνείο", "Αθήνα" },
                    { 2, "Κυβερνοασφάλεια και Επιστήμη Δεδομένων", "", "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=609&Itemid=813&lang=el", "Πανεπιστήμιο Πειραιώς", "Πειραιάς" },
                    { 3, "Προηγμένα Συστήματα Πληροφορικής - Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης", "", "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=626&Itemid=815&lang=el", "Πανεπιστήμιο Πειραιώς", "Πειραιάς" },
                    { 4, "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες", "", "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=576&Itemid=814&lang=el", "Πανεπιστήμιο Πειραιώς", "Πειραιάς" },
                    { 5, "Προηγμένες Τεχνολογίες Πληροφορικής και Υπηρεσίες", "", "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=653&Itemid=812&lang=el", "Πανεπιστήμιο Πειραιώς", "Πειραιάς" },
                    { 6, "Ανάπτυξη και Ασφάλεια Πληροφοριακών Συστημάτων", "", "https://mscis.cs.aueb.gr/el/normal/home", "Οικονομικό Πανεπιστήμιο Αθηνών", "Αθήνα" },
                    { 7, "Επιστήμη Δεδομένων", "", "https://www.dept.aueb.gr/el/cs/content/%CF%80%CE%BC%CF%83-%CF%83%CF%84%CE%B7%CE%BD-%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B7-%CE%B4%CE%B5%CE%B4%CE%BF%CE%BC%CE%AD%CE%BD%CF%89%CE%BD", "Οικονομικό Πανεπιστήμιο Αθηνών", "Αθήνα" },
                    { 8, "Μηχανική Υπολογιστών, Τηλεποικοινωνιών και Δικτύων", "", "https://www.di.uoa.gr/eng", "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", "Αθήνα" },
                    { 9, "Τεχνολογίες Πληροφορικής και Τηλεποικοινωνιών", "", "https://www.di.uoa.gr/ict", "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", "Αθήνα" },
                    { 10, "Data Science and Information Technologies", "", "https://dsit.di.uoa.gr/", "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", "Αθήνα" },
                    { 11, "Προηγμένη Τεχνολογία Λογισμικού", "", "https://mai.uom.gr/frontend/articles.php?cid=41&t=Proigmeni-Texnologia-Logismikou", "Πανεπιστήμιο Μακεδονίας", "Θεσσαλονίκη" },
                    { 12, "Ανάπτυξη Ψηφιακών Παιχνιδιών και Πολυμεσικών Εφαρμογών", "", "https://gamedev.uowm.gr/", "Πανεπιστήμιο Μακεδονίας", "Θεσσαλονίκη" },
                    { 13, "Ανάπτυξη Εφαρμογών Ιστού και Κινητών Συσκευών", "", "https://mai.uom.gr/frontend/articles.php?cid=159&t=Anaptuksi-Efarmogwn-Istou-kai-Kinitwn-Suskeuwn", "Πανεπιστήμιο Μακεδονίας", "Θεσσαλονίκη" },
                    { 14, "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", "", "https://hcimaster.upatras.gr/regulation/", "Πανεπιστήμιο Πατρών", "Πάτρα" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Coefficients");

            migrationBuilder.DropTable(
                name: "CourseHasCoefficients");

            migrationBuilder.DropTable(
                name: "CourseQuizGrades");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "PostGraduateInstitutionHasCoefficients");

            migrationBuilder.DropTable(
                name: "PostGraduateInstitutions");

            migrationBuilder.DropTable(
                name: "PrerequisiteCourses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TimeSpents");

            migrationBuilder.DropTable(
                name: "UserHasCoefficients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
