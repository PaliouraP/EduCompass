using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCompass.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Answer1", "Answer2", "Answer3", "Answer4", "CorrectAnswer", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Σωστό", "Λάθος", "", "", "Σωστό", 1 },
                    { 2, "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα", "Να γνωρίζουν τις βασικές αρχές της γλώσσας C#", "Να μπορούν να αξιοποιήσουν τις βασικές αλγοριθμικές δομές σε γλώσσα C++", "Να μπορούν να υλοποιούν προγραμματισμό sockets (TCP sockets και UDP sockets).", "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα.", 2 },
                    { 3, "Να μπορούν να σχεδιάζουν και να υλοποιούν αλγόριθμους για την αποτελεσματική κατασκευή συνδυαστικών αντικειμένων.", "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", 3 },
                    { 4, "Σωστό", "Λάθος", "", "", "Λάθος", 4 },
                    { 5, "Java", "", "", "", "Java", 5 },
                    { 6, "Ανάγνωση", "", "", "", "Ανάγνωση", 6 },
                    { 7, "Σωστό", "Λάθος", "", "", "Σωστό", 7 },
                    { 8, "Σωστό", "Λάθος", "", "", "Λάθος", 8 },
                    { 9, "Εξαιρέσεις", "", "", "", "Εξαιρέσεις", 9 },
                    { 10, "Αυτόνομη εργασία", "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)", "Προσαρμογή σε νέες καταστάσεις", "Σχεδιασμός και διαχείριση έργων", "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)", 10 },
                    { 11, "Σωστό", "Λάθος", "", "", "Σωστό", 11 },
                    { 12, "γραφικά", "", "", "", "γραφικά", 12 },
                    { 13, "ευφυών", "", "", "", "ευφυών", 13 },
                    { 14, "Υφή επιφάνειας αντικειμένων. Διαχείριση πηγών φωτός, ήχων, κάμερας. Animations.", "Ανάπτυξη εφαρμογών εικονικής πραγματικότητας στην πλατφόρμα Unity3D.", "Κόσμοι τρισδιάστατων γραφικών. Τρισδιάστατα μοντέλα αντικειμένων.", "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού.", "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού.", 14 },
                    { 15, "Σωστό", "Λάθος", "", "", "Λάθος", 15 },
                    { 16, "Unity3D", "", "", "", "Unity3D", 16 },
                    { 17, "Σωστό", "Λάθος", "", "", "Σωστό", 17 },
                    { 18, "συνιστώσες", "", "", "", "συνιστώσες", 18 },
                    { 19, "Μετρήσεις Αντικειμένου Εικόνας", "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση.", "Δομή και την λειτουργία ενός ευφυούς πράκτορα μέσα σε ένα περιβάλλον.", "Αντιδρασιακοί πράκτορες (Reactive Agents) και Βουλητικοί πράκτορες (Deliberative Agents).", "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση.", 19 },
                    { 20, "VRML: sensors και animation, γενικές αρχές μοντελοποίησης σκελετού, πρότυπα μοντελοποίησης κίνησης σώματος (H-Anim, κ.ά.), scripting, ενσωμάτωση σε εφαρμογές, PROTOs, προτεινόμενες πρακτικές σχεδιασμού και ανάπτυξης.", "VRML: σύνταξη, υλοποιήσεις, βασικά εργαλεία, γεωμετρία, μετασχηματισμοί, επαναχρησιμοποίηση κόμβων, εξωτερικές αναφορές, υλικά/χρώμα, φωτισμός, υφή, viewpoints, background, ήχος, κείμενο, billboards, HUDs.", "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης.", "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης.", "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης.", 20 },
                    { 21, "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες", "Να αναλύει και να συγκρίνει μοντέλα ανάπτυξης λογισμικού", "Να αναπτύσσει native mobile apps κάνοντας χρήση του Android SDK", "Να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες", 21 },
                    { 22, "Android Studio", "", "", "", "Android Studio", 22 },
                    { 23, "Να σχεδιάζει και να αναπτύσσει εφαρμογές για κινητές και φορητές συσκευές υλοποιώντας τις πλέον σύγχρονες τεχνικές προγραμματισμού.", "Να εκμεταλλεύεται τοπικές (SQLite) βάσεις δεδομένων.", "Να επιλέγει μοντέλα ανάπτυξης λογισμικού ανάλογα με τις ανάγκες και να τα χρησιμοποιεί.", "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP.", "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP.", 23 },
                    { 24, "Να διασφαλίζει την αποτελεσματικότητα των λογισμικών μέσω των προαναφερθέντων εφαρμογών.", "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST.", "Να αξιοποιεί το εργαλείο Android Studio για την ανάπτυξη κινητών εφαρμογών.", "Να γνωρίζει τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST.", 24 },
                    { 25, "Σωστό", "Λάθος", "", "", "Σωστό", 25 },
                    { 26, "Σωστό", "Λάθος", "", "", "Λάθος", 26 },
                    { 27, "Δομημένη", "", "", "", "Δομημένη", 27 },
                    { 28, "Scrum", "Firebase", "Rational Unified Process", "DevOps", "Rational Unified Process", 28 },
                    { 29, "Σωστό", "Λάθος", "", "", "Σωστό", 29 },
                    { 30, "Cloud", "", "", "", "Cloud", 30 },
                    { 31, "Σωστό", "Λάθος", "", "", "Σωστό", 31 },
                    { 32, "αντιδρασιακός", "", "", "", "αντιδρασιακός", 32 },
                    { 33, "δομή", "", "", "", "δομή", 33 },
                    { 34, "Cleaning Agents", "Radioactive Agents", "Deliberative Agents", "Federal Agents", "Deliberative Agents", 34 },
                    { 35, "Σωστό", "Λάθος", "", "", "Σωστό", 35 },
                    { 36, "Unity3D", "", "", "", "Unity3D", 36 },
                    { 37, "Σωστό", "Λάθος", "", "", "Λάθος", 37 },
                    { 38, "ενεργώ", "", "", "", "ενεργώ", 38 },
                    { 39, "Maslow", "Khafre", "Djoser", "Cheops", "Maslow", 39 },
                    { 40, "Reactive Agents", "Deliberative Agents", "Κανένα από τα δύο", "Και τα δύο", "Και τα δύο", 40 },
                    { 41, "Σωστό", "Λάθος", "", "", "Σωστό", 41 },
                    { 42, "χαρακτηριστικά", "", "", "", "χαρακτηριστικά", 42 },
                    { 43, "υλοποίησης", "", "", "", "υλοποίησης", 43 },
                    { 44, "First Person", "Educational", "Role-playing", "Fourth Person", "Fourth Person", 44 },
                    { 45, "Σωστό", "Λάθος", "", "", "Σωστό", 45 },
                    { 46, "Unity3D", "", "", "", "Unity3D", 46 },
                    { 47, "Σωστό", "Λάθος", "", "", "Λάθος", 47 },
                    { 48, "C", "C++", "PythonFmu", "C#", "C#", 48 },
                    { 49, "3D μοντέλα", "bolts", "sprites", "animations", "bolts", 49 },
                    { 50, "Παίκτες", "Πράκτορες", "Κανένα από τα δύο", "Και τα δύο", "Και τα δύο", 50 },
                    { 51, "Σωστό", "Λάθος", "", "", "Σωστό", 51 },
                    { 52, "desktop", "", "", "", "desktop", 52 },
                    { 53, "Visual Studio Enterprise Edition", "IntelliJ IDEA", "Visual Studio Code", "QtSpim", "Visual Studio Enterprise Edition", 53 },
                    { 54, "Σωστό", "Λάθος", "", "", "Σωστό", 54 },
                    { 55, "λογισμικού", "", "", "", "λογισμικού", 55 },
                    { 56, "IDEs", "GUIs", "GNUs", "ICPs", "IDEs", 56 },
                    { 57, "Σωστό", "Λάθος", "", "", "Λάθος", 57 },
                    { 58, "αποσφαλμάτωση", "", "", "", "αποσφαλμάτωση", 58 },
                    { 59, "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού.", "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού.", 59 },
                    { 60, "αποδοτικό", "", "", "", "αποδοτικό", 60 }
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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CourseId" },
                values: new object[,]
                {
                    { 1, "Ένα από τα αντικέιμενα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός η ομαδική εργασία.", 3 },
                    { 2, "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", 3 },
                    { 3, "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", 3 },
                    { 4, "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί να θα παράγουν εφαρμογές πελάτη-εξυπηρετητή.", 3 },
                    { 5, "Το κύριο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός  είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού ______.", 3 },
                    { 6, "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να χειρίζονται αρχεία προορισμένα για _________ και αποθήκευση δεδομένων.", 3 },
                    { 7, "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν την έννοια της κληρονομικότητας.", 3 },
                    { 8, "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί  να παράγουν εφαρμογές με αποδοτικό και ταχύ ρυθμό.", 3 },
                    { 9, "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να διαχειρίζονται αποτελεσματικά και με χρήση των κατάλληλων εργαλείων τις ________ που ανακύπτουν.", 3 },
                    { 10, "Ποιο από τα παρακάτω ΔΕΝ ανήκει στο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", 3 },
                    { 11, "Η Εικονική Πραγματικότητα είναι το επιστημονικό πεδίο με αντικείμενο την αναπαράσταση κόσμων με τη βοήθεια ηλεκτρονικών υπολογιστών.", 4 },
                    { 12, "Τα ______ με υπολογιστές διαδραματίζουν βασικό ρόλο στην Εικονική Πραγματικότητα.", 4 },
                    { 13, "Η Εικονική Πραγματικότητα, κυρίως μέσω των _______ Εικονικών Συστημάτων, έχει πλήθος εφαρμογών στην εκπαίδευση, την ψυχαγωγία, την προσομοίωση, την αλληλεπίδραση ανθρώπου – υπολογιστή και την επιστημονική έρευνα", 4 },
                    { 14, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί αντικείμενο του μαθήματος Εικονική Πραγματικότητα;", 4 },
                    { 15, "Στόχος του μαθήματος Εικονική Πραγματικότητα είναι να αποκτήσουν οι φοιτητές γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.", 4 },
                    { 16, "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη συστημάτων Εικονικής Πραγματικότητας;", 4 },
                    { 17, "Στόχος του μαθήματος Εικονική Πραγματικότητα είναι η εξοικείωση των φοιτητών με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων εφαρμογών Εικονικής Πραγματικότητας.", 4 },
                    { 18, "Μέσω της παρακολούθησης του μαθήματος Εικονική Πραγματικότητα ο φοιτητής γνωρίζει τις ________ ενός συστήματος Εικονικής Πραγματικότητας.", 4 },
                    { 19, "Ποιο από τα παρακάτω αποτελεί διδακτική ενότητα του μαθήματος Εικονική Πραγματικότητα;", 4 },
                    { 20, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί διδακτική ενότητα του μαθήματος Εικονική Πραγματικότητα;", 4 },
                    { 21, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", 1 },
                    { 22, "Η ανάπτυξη των mobile apps στο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού  υλοποιείται με τη χρήση του περιβάλλοντος ανάπτυξης λογισμικού ___________.", 1 },
                    { 23, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", 1 },
                    { 24, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", 1 },
                    { 25, "Tο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού καλύπτει και την ύλη που αφορά στους αισθητήρες των κινητών συσκευών, στις υπηρεσίες γεοεντοπισμού και σε πλήθος άλλων προχωρημένων τεχνικών προγραμματισμού.", 1 },
                    { 26, "Η ύλη του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", 1 },
                    { 27, "Ένα από τα αντκείμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι η “Ανάλυση απαιτήσεων: __________ Ανάλυση και Αντικειμενοστρεφής Ανάλυση”.", 1 },
                    { 28, "Ποιο από τα παρακάτω αποτελεί μοντέλο ανάπτυξης λογισμικού που αναλύεται στα πλαίσια του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", 1 },
                    { 29, "Ένα από τα αντικέιμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι προϋπολογισμός κόστους λογισμικού.", 1 },
                    { 30, "Παρακολουθώντας το μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού, μπορεί κανείς να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες ______ και Mobile backend as a service που παρέχει η Firebase.", 1 },
                    { 31, "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μπορεί να εφαρμόζει τα μοντέλα “αντιλαμβάνομαι-αποφασίζω-ενεργώ” (Sense-Decide-Act), BDI (Belief-Desire-Intention), σε διάφορες περιπτώσεις πρακτόρων.", 5 },
                    { 32, "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής διακρίνει και εκτιμά πότε είναι απαραίτητος ένας _________ πράκτορας και πότε βουλητικός πράκτορας.", 5 },
                    { 33, "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής κατανοεί την ____ ενός ευφυούς πράκτορα", 5 },
                    { 34, "Ποίο από τα παρακάτω αποτελεί είδος ευφυούς πράκτορα που μελετάται στο μάθυμα Ευφυείς Πράκτορες;", 5 },
                    { 35, "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες  ο φοιτητής  αναπτύσσει αλγορίθμους για εύρεση μονοπατιού (path finding), και σχεδιασμό ενεργειών (plan generation)", 5 },
                    { 36, "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη εφαρμογών ευφυή πρακτόρων;", 5 },
                    { 37, "Η συναισθηματική διαλεκτική σε ευφυείς πράκτορες αποτελεί αντικείμενο του μαθήματος Ευφυείς Πράκτορες.", 5 },
                    { 38, "Μέσω της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μαθαίνει να εφαρμόζει το μοντέλο “αντιλαμβάνομαι-αποφασίζω-________”", 5 },
                    { 39, "Αντικείμενο του μαθήματος Ευφυείς Πράκτορες είναι  ο σχεδιασμός ενεργειών, βασισμένος σε κίνητρα και η πυραμίδα του ________.", 5 },
                    { 40, "Mε ποιο είδος πρακτόρων θα ασχοληθούν οι φοιτητές στα πλαίσια του μαθληματος Ευφυείς Πράκτορες;", 5 },
                    { 41, "Παρακολουθώντας το μάθημα Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών, οι φοιτητές θα μπορούν να αναπτύσουν εφαρμογές ηλεκτρονικών παιχνιδιών στο περιβάλλον της Python.", 6 },
                    { 42, "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές βασικές γνώσεις για τον ρόλο, τους τύπους και τα ________ των παιχνιδιών, καθώς και για τη συνολική διαδικασία δημιουργίας ενός παιχνιδιού.", 6 },
                    { 43, "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές ικανότητες σχεδίασης και _________ παιχνιδιών αξιοποιώντας σύγχρονα εργαλεία, διασυνδέσεις και γλώσσες προγραμματισμού,", 6 },
                    { 44, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί κατηγορία ηλεκτρονικών παιχνιδιών;", 6 },
                    { 45, "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.", 6 },
                    { 46, "Στα πλάισια του μαθήαμτος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών ο φοιτητής μαθαίνει να συνοψίζει τις απαιτούμενες γνώσεις σχετικά με την ανάπτυξη ηλεκτρονικών παιχνιδιών στο περιβάλλον της ________", 6 },
                    { 47, "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι η εξοικείωση των φοιτητών με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων διαδικτυακών εφαρμογών.", 6 },
                    { 48, "Το αντικείενο του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών περιλαμβάνει τη σχεδίαση ενός παιχνιδιού σε ________.", 6 },
                    { 49, "Ποιο από τα παρακάτω ΔΕΝ αποτελεί συστατικά ηλεκτρονικών παιχνιδιών στο Διαδίκτυο;", 6 },
                    { 50, "Ο κόσμος ενός ηλεκτρονικού αποτελείται από χαρακτήρες που μπορεί να είναι...;", 6 },
                    { 51, "Η ύλη του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", 2 },
                    { 52, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν _______, web, ή/και mobile εφαρμογές.", 2 },
                    { 53, "Ποιο εργαλείο ανάπτυξης εφαρμογών χρησιμοποιείται στα πλαίσια του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", 2 },
                    { 54, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν λογισμικό για ένα μεγάλο πλήθος από πεδία, συμπεριλαμβανομένων των παραθυρικών εφαρμογών, των εφαρμογών κονσόλας, των εφαρμογών web και των mobile εφαρμογών.", 2 },
                    { 55, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές εκτίθονται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του παραγόμενου _________, καθώς και την ταχύτητα ανάπτυξης σύνθετων και πολύπλοκων προγραμμάτων/έργων.", 2 },
                    { 56, "Στο πλαίσιο του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών δίνεται ιδιαίτερη έμφαση στα ολοκληρωμένα περιβάλλοντα ανάπτυξης τα οποία ονομάζονται και:", 2 },
                    { 57, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναγνωρίζουν και να εξηγούν τι είναι γλώσσα και γραμματική και πώς συμβολίζονται.", 2 },
                    { 58, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθάινουν να κάνουν ________ λογισμικού με τα πλέον σύγχρονα εργαλεία.", 2 },
                    { 59, "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", 2 },
                    { 60, "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών , οι φοιτητές μαθάινουν να παράγουν εφαρμογές με _______ και ταχύ ρυθμό.", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "3D Artist/Animator");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Accessibility Specialist");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Android Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Back-End Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Big Data Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Cloud Data Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Computer Graphics Programmer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Computer Vision Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Data Architect");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Data Scientist");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Database Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "DevOps Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Front-End Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Full-Stack Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Games Designer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Games Programmer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Incident Responder");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "iOS Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Level Designer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Machine Learning Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Mobile App Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Mobile UI/UX Designer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "N.L.P. Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Network Administrator");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Network Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Network Security Specialist");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Penetration Tester");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Robotics Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Security Analyst");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Security Engineer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Software Consultant");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Software Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "UI/UX Designer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Virtual Reality Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Visual Designer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Web App Developer");

            migrationBuilder.DeleteData(
                table: "Careers",
                keyColumn: "Name",
                keyValue: "Web Designer");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "AI_ML");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "ComputerNetworks");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "ComputerVisionAndGraphics");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "DatabaseEngineering");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "GameDev");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "MobileAppDev");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Security");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "SoftwareEngineering");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "UI_UX");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "WebDev");

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "MobileAppDev", 1 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "SoftwareEngineering", 1 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "WebDev", 1 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "DatabaseEngineering", 2 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "GameDev", 2 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "MobileAppDev", 2 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "SoftwareEngineering", 2 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "WebDev", 2 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "MobileAppDev", 3 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "SoftwareEngineering", 3 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "WebDev", 3 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "AI_ML", 4 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "ComputerVisionAndGraphics", 4 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "GameDev", 4 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "AI_ML", 5 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "GameDev", 5 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "GameDev", 6 });

            migrationBuilder.DeleteData(
                table: "CourseHasCoefficients",
                keyColumns: new[] { "CoefficientName", "CourseId" },
                keyValues: new object[] { "SoftwareEngineering", 6 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 1 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "DatabaseEngineering", 1 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 2 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "DatabaseEngineering", 2 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Security", 2 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 3 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "SoftwareEngineering", 3 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Networks", 4 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Security", 4 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "WebDev", 4 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Networks", 5 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Security", 5 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Security", 6 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "WebDev", 6 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 7 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "DatabaseEngineering", 7 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Networks", 8 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 9 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "Networks", 9 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "WebDev", 9 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "AI_ML", 10 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "DatabaseEngineering", 10 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "SoftwareEngineering", 11 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "ComputerVisionAndGraphics", 12 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "GameDev", 12 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "MobileAppDev", 13 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "UI_UX", 13 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "WebDev", 13 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutionHasCoefficients",
                keyColumns: new[] { "CoefficientName", "PostGraduateInstitutionId" },
                keyValues: new object[] { "UI_UX", 14 });

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostGraduateInstitutions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
