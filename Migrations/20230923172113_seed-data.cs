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
                table: "Coefficients",
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

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AI_ML", "ComputerNetworks", "ComputerVisionAndGraphics", "CourseType", "DatabaseEngineering", "Description", "GameDev", "InIntro", "MobileAppDev", "Name", "Security", "Semester", "SoftwareEngineering", "UI_UX", "UUID", "WebDev", "Year" },
                values: new object[,]
                {
                    { 1, 0, 8, 0, "", 0, "Το μάθημα αναφέρεται σε εισαγωγικά θέματα Τεχνολογιών Διαδικτύου: Βασικές Αρχές και Λειτουργίες Διαδικτύου. Υπηρεσίες Διαδικτύου. Ο Παγκόσμιος Ιστός και το Μοντέλο Πελάτη – Εξυπηρετητή. Προγραμματισμός στο Διαδίκτυο από την πλευρά του πελάτη και από την πλευρά του εξυπηρετητή, Σχεδιασμός και Υλοποίηση Εφαρμογών στον Παγκόσμιο Ιστό. Αλληλεπιδραστικές Ιστοσελίδες με Χρήση Γλωσσών Σεναρίων (scripting languages). Ανάπτυξη Σύνθετης Εφαρμογής.", 0, true, 0, "Τεχνολογίες Διαδικτύου", 0, 1, 4, 4, "ΠΛΠΛΗ90", 8, 1 },
                    { 2, 4, 0, 0, "", 0, "", 0, false, 0, "Ανάλυση I", 0, 1, 0, 0, "ΠΛΜΑΘ24", 0, 1 },
                    { 3, 0, 4, 0, "", 0, "", 0, false, 0, "Λογική Σχεδίαση Ψηφιακών Συστημάτων", 0, 1, 0, 0, "ΠΛΠΛΗ68", 0, 1 },
                    { 4, 4, 0, 0, "", 0, "", 0, false, 0, "Μαθηματικά Υπολογιστών", 0, 1, 0, 0, "ΠΛΜΑΘΥ01", 0, 1 },
                    { 5, 5, 0, 0, "", 0, "", 0, false, 0, "Εισαγωγή στην Επιστήμη των Υπολογιστών", 0, 1, 0, 0, "ΠΛΠΛΗ01-1", 0, 1 },
                    { 6, 0, 0, 0, "", 0, "Βασικές αρχές Προγραμματισμού. Εξέλιξη Λογισμικού. Ανάλυση προβλήματος - σχεδιασμός - αναλυτικός αλγόριθμος και ανάπτυξη προγράμματος. Νόρμες προγραμμάτων. Βασικές δομές της C/C++. Τελεστές. Εντολές C++. Συναρτήσεις Χρήστη και Βιβλιοθήκης C++. Αριστοποίηση προγραμμάτων. Εισαγωγή στον αντικειμενοστραφή προγραμματισμό με C++. Είσοδος/'Εξοδος με αρχεία. Σειριακή και κατευθυνόμενη  προσπέλαση. Σύγκριση C++ με τον παραδοσιακό προγραμματισμό της FORTRAN ή και της PASCAL. Ασκήσεις/Εφαρμογές.", 0, true, 0, "Αρχές Προγραμματισμού", 0, 1, 7, 0, "ΠΛΠΛΗ02-2", 0, 1 },
                    { 7, 0, 0, 0, "", 0, "Το κύριο αντικείμενο του μαθήματος είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού JAVA. Βασικές δομές, κληρονομικότητα, εντολές, ειδικές κλάσεις, εξαιρέσεις, ειδικά θέματα, βιβλιοθήκες/διαπροσωπίες,  προσπέλαση αρχείων και Βάσεων, κα.", 0, true, 1, "Αντικειμενοστρεφής Προγραμματισμός", 0, 2, 10, 0, "ΠΛΠΛΗ37-2", 1, 1 },
                    { 8, 5, 0, 0, "", 0, "", 0, false, 0, "Ανάλυση ΙΙ", 0, 2, 0, 0, "ΠΛΜΑΘ25", 0, 1 },
                    { 9, 0, 0, 0, "", 0, "", 0, false, 0, "Αρχιτεκτονική Υπολογιστών", 0, 2, 0, 0, "ΠΛΠΛΗ52", 0, 1 },
                    { 10, 0, 0, 0, "", 0, "", 0, false, 0, "Διακριτά Μαθηματικά", 0, 2, 0, 0, "ΠΛΠΛΗ71", 0, 1 },
                    { 11, 0, 0, 0, "", 0, "", 0, false, 0, "Δομές Δεδομένων", 0, 2, 0, 0, "ΠΛΠΛΗ31", 0, 1 },
                    { 12, 0, 0, 0, "", 0, "", 0, false, 0, "Εφαρμοσμένη Άλγεβρα", 0, 2, 0, 0, "ΠΛΜΑΘ02-3", 0, 1 },
                    { 13, 0, 0, 0, "", 1, "Το αντικείμενο του μαθήματος είναι η ανάπτυξη εφαρμογών βάσει του αντικειμενοστρεφούς μοντέλου ανάπτυξης λογισμικού. Η γλώσσα προγραμματισμού που χρησιμοποιείται ως βάση είναι η C#, που θεωρείται από τις πλέον σύγχρονες αντικειμενοστρεφείς γλώσσες. Στο πλαίσιο του μαθήματος δίνεται ιδιαίτερη έμφαση στα εργαλεία ανάπτυξης εφαρμογών, ολοκληρωμένα περιβάλλοντα ανάπτυξης (IDEs) και συγκεκριμένα το εργαλείο που χρησιμοποιείται είναι το Visual Studio Enterprise Edition. Με τη χρήση του Visual Studio και της C# ως γλώσσας προγραμματισμού, οι φοιτητές μαθαίνουν να αναπτύσσουν desktop, web, ή/και mobile εφαρμογές, γρήγορα, αποδοτικά και κυρίως με την όσο το δυνατόν μικρότερη πιθανότητα να κάνουν λάθη προγραμματισμού ή/και λογικής.", 1, true, 0, "Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών", 0, 3, 10, 0, "ΠΛΠΛΗ37-3", 3, 2 },
                    { 14, 0, 0, 0, "", 0, "", 0, false, 0, "Λειτουργικά Συστήματα", 0, 3, 0, 0, "ΠΛΠΛΗ41-1", 0, 2 },
                    { 15, 0, 0, 0, "", 0, "", 0, false, 0, "Μαθηματικός Προγραμματισμός", 0, 3, 0, 0, "ΠΛΜΑΘ06-1", 0, 2 },
                    { 16, 6, 0, 0, "", 0, "", 0, false, 0, "Μεταγλωττιστές", 0, 3, 0, 0, "ΠΛΠΛΗ08", 0, 2 },
                    { 17, 0, 0, 0, "", 0, "", 0, false, 0, "Πιθανότητες και Στατιστική", 0, 3, 0, 0, "ΠΛΜΑΘ23-1", 0, 2 },
                    { 18, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Δίκαιο της Πληροφορικής", 0, 3, 0, 0, "ΠΛΔΙΚ01", 0, 2 },
                    { 19, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Εφαρμογές Θεωρίας Γραφημάτων", 0, 3, 0, 0, "ΠΛΜΑΘ35-1", 0, 2 },
                    { 20, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Μάνατζμεντ", 0, 3, 0, 0, "ΠΛΜΑΝΖ01", 0, 2 },
                    { 21, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Παιδαγωγικά", 0, 3, 0, 0, "ΠΛΠΑΙΔ01", 0, 2 },
                    { 22, 0, 0, 0, "", 10, "Σκοπός του μαθήματος είναι αρχικά η κατανόηση των Βάσεων Δεδομένων (ΒΔ) ως συλλογές σχέσεων (πινάκων), μέσα από την παρουσίαση του θεωρητικού υπόβαθρου (Σχεσιακό Μοντέλο, Σχεσιακή Άλγεβρα) και της βασικής γλώσσας διεπαφής με αυτές (γλώσσα SQL), και κατόπιν η μελέτη τεχνικών σχεδίασης Σχεσιακών ΒΔ, με χρήση των αρχών της Θεωρίας Κανονικοποίησης.", 0, true, 0, "Βάσεις Δεδομένων", 0, 4, 0, 0, "ΠΛΠΛΗ30-1", 5, 2 },
                    { 23, 0, 0, 0, "", 5, "Το μάθημα ασχολείται με τη θεωρητική μελέτη και την πρακτική εξάσκηση σε θέματα προγραμματισμού στο διαδίκτυο και στον παγκόσμιο ιστό, όπως προγραμματισμό sockets, την υλοποίηση εφαρμογών πελάτη-εξυπηρετητή και τις αρχιτεκτονικές 3-tier.", 0, true, 0, "Προγραμματισμός στο Διαδίκτυο και στον Παγκόσμιο Ιστό", 3, 4, 4, 3, "ΠΛΔΠΙ01", 10, 2 },
                    { 24, 0, 0, 0, "", 0, "", 0, false, 0, "Αλγόριθμοι", 0, 4, 0, 0, "ΠΛΜΑΘ45", 0, 2 },
                    { 25, 8, 0, 0, "", 0, "", 0, false, 0, "Αρχές και Εφαρμογές Σημάτων και Συστημάτων", 0, 4, 0, 0, "ΠΛΠΛΗ10-1", 0, 2 },
                    { 26, 0, 10, 0, "", 0, "", 0, false, 0, "Δίκτυα Υπολογιστών", 0, 4, 0, 0, "ΠΛΠΛΗ44", 0, 2 },
                    { 27, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Επιχερησιακή Στρατηγική", 0, 4, 0, 0, "ΟΚΟΔΕ08", 0, 2 },
                    { 28, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Εφαρμοσμένη Συνδυαστική", 0, 4, 0, 0, "ΠΛΜΑΘ46-1", 0, 2 },
                    { 29, 3, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Θεωρία Πληροφοριών και Κωδίκων", 5, 4, 0, 0, "ΠΛΠΛΗ73-1", 0, 2 },
                    { 30, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, false, 0, "Πληροφορική στην Εκπαίδευση", 0, 4, 0, 0, "ΠΛΠΛΗΚΕΚ01", 0, 2 },
                    { 31, 0, 0, 0, "", 0, "Σχεδιασμός του συστήματος διεπαφής με τον χρήστη, η ανθρώπινη πλευρά στην αλληλεπίδραση. Κλασσικά και σύγχρονα μέσα επικοινωνίας του υπολογιστή. Μοντέλα αλληλεπίδρασης και μοντέλα για τον χρήστη. Στόχοι, μέθοδοι, ανάλυση εργασιών. Χρηστικότητα, φιλικότητα λογισμικού.", 0, true, 0, "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", 0, 5, 4, 10, "ΠΛΠΛΗ20", 0, 3 },
                    { 32, 10, 0, 0, "", 0, "Αναγνώριση Προτύπων (pattern recognition) είναι η επιστημονική περιοχή που έχει στόχο την ταξινόμηση αντικειμένων σε κατηγορίες (κλάσεις) και συμπεριλαμβάνει το επιστημονικό πεδίο της Μηχανικής Μάθησης (machine learning). Σκοπός, επομένως, του παρόντος μαθήματος είναι να παρουσιάσει με ενιαίο τρόπο τις ευρύτερα χρησιμοποιούμενες τεχνικές και μεθοδολογίες για προβλήματα αναγνώρισης προτύπων.", 0, true, 0, "Αναγνώριση Προτύπων", 0, 5, 0, 0, "ΠΛΠΛΗ50", 0, 3 },
                    { 33, 0, 0, 0, "", 0, "", 0, false, 0, "Πληροφοριακά Συστήματα", 0, 5, 0, 0, "ΠΛΠΛΗ81-2", 0, 3 },
                    { 34, 7, 0, 0, "ΤΛΕΣ", 0, "", 0, true, 0, "Λογικός Προγραμματισμός", 0, 5, 0, 0, "ΠΛΜΑΘ71", 0, 3 },
                    { 35, 0, 0, 0, "ΠΣΥ", 0, "", 0, true, 0, "Κρυπτογραφία", 10, 5, 0, 0, "ΠΛΚΡΥ01", 0, 3 },
                    { 36, 0, 0, 0, "ΠΣΥ, ΤΛΕΣ", 10, "", 0, true, 0, "Συστήματα Διαχείρισης Βάσεων Δεδομένων", 0, 5, 0, 0, "ΠΛΠΛΗ33-2", 0, 3 },
                    { 37, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Προηγμένα Θέματα Επικοινωνιών", 0, 5, 0, 0, "ΠΛΠΘΕ01", 0, 3 },
                    { 38, 0, 6, 0, "ΔΥΣ", 0, "", 0, true, 0, "Προηγμένη Αρχιτεκτονική Υπολογιστών", 0, 5, 0, 0, "ΠΛΠΡΟ01", 0, 3 },
                    { 39, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Ειδικά Θέματα Επιχειρησιακής Έρευνας", 0, 5, 0, 0, "ΠΛΘΕΠ01", 0, 3 },
                    { 40, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Λογισμικό Διαχείρισης Μάθησης", 0, 5, 7, 0, "ΠΛΛΟΔΙΜ01", 0, 3 },
                    { 41, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Θεωρία Υπολογισμού", 0, 5, 0, 0, "ΠΛΜΑΘ49", 0, 3 },
                    { 42, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Ουρές Αναμονής", 0, 5, 0, 0, "ΠΛΠΛΗ72-1", 0, 3 },
                    { 43, 0, 0, 0, "", 0, "", 0, true, 0, "Τεχνολογία Λογισμικού", 0, 6, 10, 0, "ΠΛΠΛΗ46", 0, 3 },
                    { 44, 10, 0, 0, "", 0, "", 0, true, 0, "Τεχνητή Νοημοσύνη και Έμπειρα Συστήματα", 0, 6, 0, 0, "ΠΛΠΛΗ18-1", 0, 3 },
                    { 45, 5, 0, 4, "ΤΛΕΣ", 0, "", 0, true, 0, "Βιοπληροφορική", 0, 6, 0, 0, "ΠΛΒΙΟΠ01", 0, 3 },
                    { 46, 6, 0, 0, "ΤΛΕΣ", 0, "", 0, true, 0, "Επεξεργασία Φυσικής Γλώσσας", 0, 6, 0, 0, "ΠΛΠΛΗ24-01", 0, 3 },
                    { 47, 6, 0, 8, "ΤΛΕΣ", 0, "", 0, true, 0, "Συστήματα Πολυμέσων", 0, 6, 0, 0, "ΠΛΠΛΗ48", 0, 3 },
                    { 48, 10, 0, 0, "ΠΣΥ", 6, "", 0, true, 0, "Αναλυτική Δεδομένων", 0, 6, 0, 0, "ΠΛΑΝΑΔΕ01", 0, 3 },
                    { 49, 0, 0, 0, "ΠΣΥ", 0, "", 0, true, 0, "Συστήματα Υποστήριξης Αποφάσεων", 0, 6, 0, 0, "ΠΛΜΑΘ36-1", 0, 3 },
                    { 51, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Δίκτυα Υψηλών Ταχυτήτων", 0, 6, 0, 0, "ΠΛΠΛΗ49", 0, 3 },
                    { 52, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Προγραμματισμός Συστημάτων, Τηλεπικοινωνιών και Υπηρεσιών", 0, 6, 0, 0, "ΠΛΠΛΗ91-1", 0, 3 },
                    { 53, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Σχεδίαση Υπολογιστικών Συστημάτων", 4, 6, 0, 0, "ΠΛΠΛΗ53", 0, 3 },
                    { 54, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Διδακτική της Πληροφορικής", 0, 6, 6, 6, "ΠΛΔΙΠ01-1", 0, 3 },
                    { 55, 0, 10, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Ευφυής Αλληλεπίδραση με Κοινωνικά Δίκτυα", 0, 6, 0, 0, "ΠΛΕΑΚΔ01", 0, 3 },
                    { 56, 5, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Παράλληλος Υπολογισμός", 0, 6, 0, 0, "ΠΛΠΡΑΝ01", 0, 3 },
                    { 57, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Πρότυπα Ανάπτυξης Λογισμικού", 0, 6, 10, 0, "ΠΛΠΡΑΝΑΛ01", 0, 3 },
                    { 58, 2, 0, 7, "ΤΛΕΣ", 0, "", 10, true, 0, "Εικονική Πραγματικότητα", 0, 7, 0, 0, "ΠΛΕΙΚ03", 0, 4 },
                    { 59, 7, 0, 10, "ΤΛΕΣ", 0, "", 0, true, 0, "Ανάλυση Εικόνας", 0, 7, 0, 0, "ΠΛΕΙΚ01", 0, 4 },
                    { 60, 0, 0, 0, "ΤΛΕΣ", 0, "", 0, true, 10, "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού", 0, 7, 10, 0, "ΠΛΘΕΤΚΑΕ01", 5, 4 },
                    { 61, 8, 0, 0, "ΠΣΥ", 5, "", 0, true, 0, "Θέματα Επιστήμης Δεδομένων", 0, 7, 0, 0, "ΠΛΗΘΕΔ01", 0, 4 },
                    { 63, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Κινητές και Ασύρματες Επικοινωνίες", 4, 7, 0, 0, "ΠΛΚΑΕ01", 0, 4 },
                    { 64, 0, 10, 0, "ΔΥΣ", 0, "", 0, true, 0, "Κατανεμημένα και Πολυεπεξεργαστικά Υπολογιστικά Συστήματα", 8, 7, 0, 0, "ΠΛΣΥΣ01-1", 5, 4 },
                    { 65, 0, 6, 0, "ΠΣΥ, ΔΥΣ", 0, "", 0, true, 0, "Ασφάλεια Πληροφοριακών Συστημάτων", 10, 7, 0, 0, "ΠΛΠΛΗ47", 6, 4 },
                    { 67, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Διαχείριση Γνώσης", 0, 7, 0, 0, "ΠΛΔΙΓ01", 0, 4 },
                    { 68, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Αξιολόγηση Προγραμμάτων Διδασκαλίας", 0, 7, 0, 0, "ΠΛΑΠΡΟΔΙΔ01", 0, 4 },
                    { 69, 0, 8, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Έξυπνες Πόλεις και Διαδίκτυο των Πραγμάτων", 1, 7, 0, 0, "ΠΛΕΠΔΙΠΡ01", 1, 4 },
                    { 70, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "Το μάθημα ασχολείται με την αξιοποίηση των Τεχνολογιών Πληροφορικής και Επικοινωνιών (ΤΠΕ) στην εκπαίδευση. Στόχος του συγκεκριμένου μαθήματος είναι η διδασκαλία των τεχνικών και των εργαλείων με τα οποία είναι δυνατός ο συγκερασμός των σύγχρονων πηγών ηλεκτρονικής μάθησης με τα ψηφιακά κοινωνικά δίκτυα, από τους παιδαγωγούς της ανώτερης εκπαίδευσης. Βασική επιδίωξη του μαθήματος είναι να μεταδώσει στους φοιτητές την ιδιαίτερη σημασία της κοινωνικής δικτύωσης σε θέματα που αφορούν κατά κύριο λόγο στην κατανεμημένη εκπαίδευση και το πως αυτή ενισχύει την συνεργασία μεταξύ των σχεδιαστών μαθημάτων αλλά και τον διαμοιρασμό του εκπαιδευτικού περιεχομένου.", 0, true, 0, "Ηλεκτρονική Μάθηση και Κοινωνικά Δίκτυα", 0, 7, 5, 0, "ΠΛΗΛΜΚΔ01", 3, 4 },
                    { 71, 5, 10, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Οχηματικά Δίκτυα Επόμενης Γενιάς", 0, 7, 0, 0, "ΠΛΟΔΕΓ01", 0, 4 },
                    { 72, 5, 3, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Ανάκτηση Πληροφορίας και Αναζήτηση στον Παγκόσμιο Ιστό", 0, 7, 0, 0, "ΠΛΠΛΗ74", 5, 4 },
                    { 73, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 10, true, 0, "Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών", 0, 7, 3, 0, "ΠΛΤΑΗΠ01", 0, 4 },
                    { 74, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 7, "", 0, true, 0, "Υπηρεσιοστρεφές Λογισμικό", 0, 7, 6, 4, "ΠΛΥΠΛΟ01", 10, 4 },
                    { 75, 10, 0, 0, "ΤΛΕΣ", 0, "", 0, true, 0, "Επεξεργασία Σημάτων Φωνής και Ήχου", 0, 8, 0, 0, "ΠΛΕΠΣΦΗ01", 0, 4 },
                    { 76, 10, 0, 0, "ΤΛΕΣ", 0, "", 8, true, 0, "Ευφυείς Πράκτορες", 0, 8, 0, 0, "ΠΛΕΥΦΠΡ01", 0, 4 },
                    { 77, 0, 0, 0, "ΤΛΕΣ", 1, "", 0, true, 0, "Εκπαιδευτικό Λογισμικό", 0, 8, 7, 4, "ΠΛΕΚΛ01", 1, 4 },
                    { 78, 4, 0, 0, "ΠΣΥ", 0, "", 0, true, 0, "Διοικητική Πληροφορική", 0, 8, 0, 0, "ΠΛΔΙΠ01", 0, 4 },
                    { 79, 0, 6, 0, "ΔΥΣ", 0, "", 0, true, 0, "Ασφάλεια Δικτύων", 10, 8, 0, 0, "ΠΛΑΣΦΔ01", 0, 4 },
                    { 80, 0, 0, 0, "ΠΣΥ, ΔΥΣ", 0, "", 0, true, 0, "Ηλεκτρονικό Επιχειρήν και Καινοτομία", 0, 8, 6, 0, "ΠΛΗΕΠΚ01", 0, 4 },
                    { 81, 0, 3, 0, "ΠΣΥ, ΔΥΣ", 7, "", 0, true, 0, "Πληροφοριακά Συστήματα στο Διαδίκτυο", 3, 8, 5, 5, "ΠΛΣΥΔ01", 10, 4 },
                    { 82, 0, 10, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Προηγμένα Θέματα Διαχείρισης Δικτύων και Κινητών Επικοινωνιών", 0, 8, 0, 0, "ΠΛΘΕΔΔΚΕ01", 0, 4 },
                    { 83, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Συστήματα ERP/CRM", 0, 8, 0, 0, "ΠΛΣΥΣ02", 0, 4 },
                    { 84, 0, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Συστήματα Διασφάλισης Ποιότητας", 0, 8, 0, 0, "ΠΛΣΥΣ03", 0, 4 },
                    { 85, 8, 0, 0, "ΕΠΙΛΟΓΗΣ", 0, "", 0, true, 0, "Τεχνολογίες Blockchain και Εφαρμογές", 6, 8, 0, 0, "ΠΛΤΕΒΕΦ01", 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "PostGraduateInstitutions",
                columns: new[] { "Id", "AI_ML", "ComputerNetworks", "ComputerVisionAndGraphics", "DatabaseEngineering", "Department", "Description", "GameDev", "Hyperlink", "MobileAppDev", "Name", "Security", "SoftwareEngineering", "Town", "UI_UX", "WebDev" },
                values: new object[,]
                {
                    { 1, true, false, false, true, "Επιστήμη Δεδομένων και Μηχανική Μάθηση", "", false, "https://dsml.ece.ntua.gr/", false, "Εθνικό Μετσόβειο Πολυτεχνείο", false, false, "Αθήνα", false, false },
                    { 2, true, false, false, true, "Κυβερνοασφάλεια και Επιστήμη Δεδομένων", "", false, "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=609&Itemid=813&lang=el", false, "Πανεπιστήμιο Πειραιώς", true, false, "Πειραιάς", false, false },
                    { 3, true, false, false, false, "Προηγμένα Συστήματα Πληροφορικής - Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης", "", false, "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=626&Itemid=815&lang=el", false, "Πανεπιστήμιο Πειραιώς", false, true, "Πειραιάς", false, false },
                    { 4, false, true, false, false, "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες", "", false, "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=576&Itemid=814&lang=el", false, "Πανεπιστήμιο Πειραιώς", true, false, "Πειραιάς", false, true },
                    { 5, false, true, false, false, "Προηγμένες Τεχνολογίες Πληροφορικής και Υπηρεσίες", "", false, "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=653&Itemid=812&lang=el", false, "Πανεπιστήμιο Πειραιώς", true, false, "Πειραιάς", false, false },
                    { 6, false, false, false, false, "Ανάπτυξη και Ασφάλεια Πληροφοριακών Συστημάτων", "", false, "https://mscis.cs.aueb.gr/el/normal/home", false, "Οικονομικό Πανεπιστήμιο Αθηνών", true, false, "Αθήνα", false, true },
                    { 7, true, false, false, true, "Επιστήμη Δεδομένων", "", false, "https://www.dept.aueb.gr/el/cs/content/%CF%80%CE%BC%CF%83-%CF%83%CF%84%CE%B7%CE%BD-%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B7-%CE%B4%CE%B5%CE%B4%CE%BF%CE%BC%CE%AD%CE%BD%CF%89%CE%BD", false, "Οικονομικό Πανεπιστήμιο Αθηνών", false, false, "Αθήνα", false, false },
                    { 8, false, true, false, false, "Μηχανική Υπολογιστών, Τηλεποικοινωνιών και Δικτύων", "", false, "https://www.di.uoa.gr/eng", false, "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", false, false, "Αθήνα", false, false },
                    { 9, true, true, false, false, "Τεχνολογίες Πληροφορικής και Τηλεποικοινωνιών", "", false, "https://www.di.uoa.gr/ict", false, "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", false, false, "Αθήνα", false, true },
                    { 10, true, false, false, true, "Data Science and Information Technologies", "", false, "https://dsit.di.uoa.gr/", false, "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", false, false, "Αθήνα", false, false },
                    { 11, false, false, false, false, "Προηγμένη Τεχνολογία Λογισμικού", "", false, "https://mai.uom.gr/frontend/articles.php?cid=41&t=Proigmeni-Texnologia-Logismikou", false, "Πανεπιστήμιο Μακεδονίας", false, true, "Θεσσαλονίκη", false, false },
                    { 12, false, false, true, false, "Ανάπτυξη Ψηφιακών Παιχνιδιών και Πολυμεσικών Εφαρμογών", "", true, "https://gamedev.uowm.gr/", false, "Πανεπιστήμιο Μακεδονίας", false, false, "Θεσσαλονίκη", false, false },
                    { 13, false, false, false, false, "Ανάπτυξη Εφαρμογών Ιστού και Κινητών Συσκευών", "", false, "https://mai.uom.gr/frontend/articles.php?cid=159&t=Anaptuksi-Efarmogwn-Istou-kai-Kinitwn-Suskeuwn", true, "Πανεπιστήμιο Μακεδονίας", false, false, "Θεσσαλονίκη", true, true },
                    { 14, false, false, false, false, "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", "", false, "https://hcimaster.upatras.gr/regulation/", false, "Πανεπιστήμιο Πατρών", false, false, "Πάτρα", true, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Artificial Intelligence and Machine Learning");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Computer Networks");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Computer Vision and Graphics");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Database Engineering");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Game Development");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Mobile App Development");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Security");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Software Technology");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "User Interface and User Experience");

            migrationBuilder.DeleteData(
                table: "Coefficients",
                keyColumn: "Name",
                keyValue: "Web Development");

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
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 85);

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
        }
    }
}
