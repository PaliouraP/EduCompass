using EduCompass.Models;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<PostGraduateInstitution> PostGraduateInstitutions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        
        public DbSet<PrerequisiteCourse> PrerequisiteCourses { get; set; }
        public DbSet<TimeSpent> TimeSpents { get; set; }
        public DbSet<Career> Careers { get; set; }
        
        // QUIZ
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseQuizGrade> CourseQuizGrades { get; set; }
        public DbSet<CoefficientQuizGrade> CoefficientQuizGrades { get; set; }
        
        // COEFFICIENT TABLES
        public DbSet<Coefficient> Coefficients { get; set; }
        public DbSet<PostGraduateInstitutionHasCoefficient> PostGraduateInstitutionHasCoefficients { get; set; }
        public DbSet<UserHasCoefficient> UserHasCoefficients { get; set; }
        public DbSet<CourseHasCoefficient> CourseHasCoefficients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDataToCourses(modelBuilder);
            SeedDataToPrerequisiteCourses(modelBuilder);
            SeedDataToPostGraduate(modelBuilder);
            SeedDataToCoefficients(modelBuilder);
            SeedDataToCoefficientPgi(modelBuilder);
            SeedDataToCoefficientsCourses(modelBuilder);
            SeedDataToCareer(modelBuilder);
            SeedDataToQuestionsAndAnswers(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        private void SeedDataToCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                
                new Course { Id = 1, Name = "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού", UUID = "ΠΛΘΕΤΚΑΕ01", Semester = 7, Description = "", Content = AndroidDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 2, Name = "Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών", UUID = "ΠΛΠΛΗ37-3", Semester = 3, Description = "", Content = AAEDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 3, Name = "Αντικειμενοστρεφής Προγραμματισμός", UUID = "ΠΛΠΛΗ37-2", Semester = 2, Description = "", Content = OOPDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 4, Name = "Εικονική Πραγματικότητα", UUID = "ΠΛΕΙΚ03", Semester = 7, Description = "", Content = VRDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 5, Name = "Ευφυείς Πράκτορες", UUID = "ΠΛΕΥΠΡ01", Semester = 8, Description = "", Content = IntelligentAgentsDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 6, Name = "Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών", UUID = "ΠΛΤΑΗΠ01", Semester = 7, Description = "", Content = VideoGamesDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 7, Name = "Κρυπτογραφία", UUID = "ΠΛΚΡΥ01", Semester = 5, Description = "", Content = CryptographyDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 8, Name = "Ασφάλεια Πληροφοριακών Συστημάτων", UUID = "ΠΛΠΛΗ47", Semester = 7, Description = "", Content = AsfaleiaPSDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 9, Name = "Ασφάλεια Δικτύων", UUID = "ΠΛΑΣΦΔ01", Semester = 8, Description = "", Content = AsfaleiaDiktywnDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 10, Name = "Τεχνολογίες Διαδικτύου", UUID = "ΠΛΠΛΗ90", Semester = 1, Description = "", Content = TexnologiesDiadiktyouDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 11, Name = "Αλληλεπίδραση Ανθρώπου και Υπολογιστή", UUID = "ΠΛΠΛΗ20", Semester = 5, Description = "", Content = AAYDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 12, Name = "Αναγνώριση Προτύπων", UUID = "ΠΛΠΛΗ81-2", Semester = 5, Description = "", Content = PatternRecognitionDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 13, Name = "Τεχνητή Νοημοσύνη και Έμπειρα Συστήματα", UUID = "ΠΛΠΛΗ18-1", Semester = 6, Description = "", Content = AIDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 14, Name = "Αναλυτική Δεδομένων", UUID = "ΠΛΑΝΑΔΕ01", Semester = 6, Description = "", Content = DataAnalyticsDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 15, Name = "Βάσεις Δεδομένων", UUID = "ΠΛΠΛΗ30-1", Semester = 4, Description = "", Content = DbDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 16, Name = "Συστήματα Διαχείρισης Βάσεων Δεδομένων", UUID = "ΠΛΠΛΗ33-2", Semester = 5, Description = "", Content = DbmsDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 17, Name = "Προγραμματισμός στο Διαδίκτυο και στον Παγκόσμιο Ιστό", UUID = "ΠΛΔΠΙ01", Semester = 4, Description = "", Content = GlobalWebProgrammingDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 18, Name = "Πληροφοριακά Συστήματα στο Διαδίκτυο", UUID = "ΠΛΣΥΔ01", Semester = 8, Description = "", Content = InternetInformationSystemsDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 19, Name = "Δίκτυα Υπολογιστών", UUID = "ΠΛΠΛΗ44", Semester = 4, Description = "", Content = NetworksDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 20, Name = "Ανάλυση Εικόνας", UUID = "ΠΛΕΙΚ01", Semester = 7, Description = "", Content = ImageAnalysisDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 21, Name = "Τεχνολογία Λογισμικού", UUID = "ΠΛΠΛΗ46", Semester = 6, Description = "", Content = SoftEngDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 22, Name = "Πρότυπα Ανάπυτξης Λογισμικού", UUID = "ΠΛΠΡΑΝΑΛ01", Semester = 6, Description = "", Content = DesignPatternsDesc(), AudioFileName = "correct.mp3" },
                new Course { Id = 23, Name = "Συστήματα Πολυμέσων", UUID = "ΠΛΠΛΗ48", Semester = 6, Description = "", Content = MultimediaSystemsDesc(), AudioFileName = "correct.mp3" }
            );
        }

        private void SeedDataToPrerequisiteCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrerequisiteCourse>().HasData(
                
                // security
                new PrerequisiteCourse { BaseCourseId = 8, PrerequisiteCourseId = 7 },
                new PrerequisiteCourse { BaseCourseId = 9, PrerequisiteCourseId = 8 },
                
                // networks
                new PrerequisiteCourse { BaseCourseId = 19, PrerequisiteCourseId = 10 },
                new PrerequisiteCourse { BaseCourseId = 9, PrerequisiteCourseId = 19 },
                
                // ui-ux
                new PrerequisiteCourse { BaseCourseId = 11, PrerequisiteCourseId = 10 },

                // web app dev
                new PrerequisiteCourse { BaseCourseId = 17, PrerequisiteCourseId = 10 },
                new PrerequisiteCourse { BaseCourseId = 18, PrerequisiteCourseId = 17 },
                
                // android
                new PrerequisiteCourse { BaseCourseId = 2, PrerequisiteCourseId = 3 },
                new PrerequisiteCourse { BaseCourseId = 1, PrerequisiteCourseId = 2 },
                
                // softeng
                new PrerequisiteCourse { BaseCourseId = 22, PrerequisiteCourseId = 21 },
                new PrerequisiteCourse { BaseCourseId = 1, PrerequisiteCourseId = 22 },
                
                // cptr vision
                new PrerequisiteCourse { BaseCourseId = 23, PrerequisiteCourseId = 12 },
                new PrerequisiteCourse { BaseCourseId = 20, PrerequisiteCourseId = 23 },
                
                // ai-ml
                new PrerequisiteCourse { BaseCourseId = 13, PrerequisiteCourseId = 12 },
                new PrerequisiteCourse { BaseCourseId = 14, PrerequisiteCourseId = 13 },
                new PrerequisiteCourse { BaseCourseId = 5, PrerequisiteCourseId = 13 },
                
                // data eng
                new PrerequisiteCourse { BaseCourseId = 16, PrerequisiteCourseId = 15 },
                new PrerequisiteCourse { BaseCourseId = 14, PrerequisiteCourseId = 16 },
                
                // game dev
                new PrerequisiteCourse { BaseCourseId = 6, PrerequisiteCourseId = 4 },
                new PrerequisiteCourse { BaseCourseId = 5, PrerequisiteCourseId = 6 }
            );
        }
        
        private void SeedDataToPostGraduate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostGraduateInstitution>().HasData(
                
                // ΕΜΠ
                new PostGraduateInstitution
                {
                    Id = 1, Name = "Εθνικό Μετσόβειο Πολυτεχνείο", Department = "Επιστήμη Δεδομένων και Μηχανική Μάθηση", Town = "Αθήνα", Hyperlink = "https://dsml.ece.ntua.gr/"
                },
                
                // ΠΑΠΕΙ
                new PostGraduateInstitution
                {
                    Id = 2, Name = "Πανεπιστήμιο Πειραιώς", Department = "Κυβερνοασφάλεια και Επιστήμη Δεδομένων", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=609&Itemid=813&lang=el",
                },
                
                new PostGraduateInstitution
                {
                    Id = 3, Name = "Πανεπιστήμιο Πειραιώς", Department = "Προηγμένα Συστήματα Πληροφορικής - Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=626&Itemid=815&lang=el",
                },
                
                new PostGraduateInstitution
                {
                    Id = 4,Name = "Πανεπιστήμιο Πειραιώς", Department = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=576&Itemid=814&lang=el",
                },
                
                new PostGraduateInstitution
                {
                    Id = 5, Name = "Πανεπιστήμιο Πειραιώς", Department = "Προηγμένες Τεχνολογίες Πληροφορικής και Υπηρεσίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=653&Itemid=812&lang=el",
                },

                // ΟΠΑ (ΑΣΟΕΕ)
                
                new PostGraduateInstitution
                {
                    Id = 6, Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Ανάπτυξη και Ασφάλεια Πληροφοριακών Συστημάτων", Town = "Αθήνα", Hyperlink = "https://mscis.cs.aueb.gr/el/normal/home",
                },

                new PostGraduateInstitution
                {
                    Id = 7, Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Επιστήμη Δεδομένων", Town = "Αθήνα", Hyperlink = "https://www.dept.aueb.gr/el/cs/content/%CF%80%CE%BC%CF%83-%CF%83%CF%84%CE%B7%CE%BD-%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B7-%CE%B4%CE%B5%CE%B4%CE%BF%CE%BC%CE%AD%CE%BD%CF%89%CE%BD",
                },

                // ΕΚΠΑ
                
                new PostGraduateInstitution
                {
                    Id = 8, Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Μηχανική Υπολογιστών, Τηλεποικοινωνιών και Δικτύων", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/eng",
                },
                
                new PostGraduateInstitution
                {
                    Id = 9, Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Τεχνολογίες Πληροφορικής και Τηλεποικοινωνιών", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/ict",
                },

                new PostGraduateInstitution
                {
                    Id = 10, Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Data Science and Information Technologies", Town = "Αθήνα", Hyperlink = "https://dsit.di.uoa.gr/",
                },
                
                // ΠΑΜΑΚ
                
                new PostGraduateInstitution
                {
                    Id = 11, Name = "Πανεπιστήμιο Μακεδονίας", Department = "Προηγμένη Τεχνολογία Λογισμικού", Town = "Θεσσαλονίκη", Hyperlink = "https://mai.uom.gr/frontend/articles.php?cid=41&t=Proigmeni-Texnologia-Logismikou",
                },
                
                new PostGraduateInstitution
                {
                    Id = 12, Name = "Πανεπιστήμιο Μακεδονίας", Department = "Ανάπτυξη Ψηφιακών Παιχνιδιών και Πολυμεσικών Εφαρμογών", Town = "Θεσσαλονίκη", Hyperlink = "https://gamedev.uowm.gr/",
                },
                
                new PostGraduateInstitution
                {
                    Id = 13, Name = "Πανεπιστήμιο Μακεδονίας", Department = "Ανάπτυξη Εφαρμογών Ιστού και Κινητών Συσκευών", Town = "Θεσσαλονίκη", Hyperlink = "https://mai.uom.gr/frontend/articles.php?cid=159&t=Anaptuksi-Efarmogwn-Istou-kai-Kinitwn-Suskeuwn",
                },
                
                // ΠΑΝΕΠΙΣΤΗΜΙΟ ΠΑΤΡΩΝ
                
                new PostGraduateInstitution
                {
                    Id = 14, Name = "Πανεπιστήμιο Πατρών", Department = "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", Town = "Πάτρα", Hyperlink = "https://hcimaster.upatras.gr/regulation/",
                }
            );
        }
        
        private void SeedDataToCoefficients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coefficient>().HasData(

                new Coefficient
                {
                    Name = "SoftwareEngineering", NameInGreek = "Τεχνολογία Λογισμικού"
                },
                
                new Coefficient
                {
                    Name = "AI_ML", NameInGreek = "Τεχνητή Νοημοσύνη και Μηχανική Μάθηση"
                },
                
                new Coefficient
                {
                    Name = "UI_UX", NameInGreek = "Αλληλεπίδραση Ανθρώπου-Υπολογιστή"
                },
                
                new Coefficient
                {
                    Name = "Security", NameInGreek = "Ασφάλεια"
                },
                
                new Coefficient
                {
                    Name = "ComputerNetworks", NameInGreek = "Δίκτυα Υπολογιστών"
                },
                
                new Coefficient
                {
                    Name = "ComputerVisionAndGraphics", NameInGreek = "Ανάλυση Εικόνας και Γραφικών"
                },
                
                new Coefficient
                {
                    Name = "GameDev", NameInGreek = "Ανάπτυξη Ηλεκτρονικών Παιχνιδιών"
                },
                
                new Coefficient
                {
                    Name = "DatabaseEngineering", NameInGreek = "Ανάπτυξη Βάσεων Δεδομένων και Επιστήμη Δεδομένων"
                },
                
                new Coefficient
                {
                    Name = "WebDev", NameInGreek = "Ανάπτυξη Διαδικτυακών Εφαρμογών"
                },
                
                new Coefficient
                {
                    Name = "MobileAppDev", NameInGreek = "Ανάπτυξη Εφαρμογών Κινητών Τηλεφώνων"
                }
            );
        }
        
        private void SeedDataToCoefficientPgi(ModelBuilder modelBuilder)
        {
            // COEFFICIENTS FOR MASTER'S
            modelBuilder.Entity<PostGraduateInstitutionHasCoefficient>().HasData(
                
                // AI_ML
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 1,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 2,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 3,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 7,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 9,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 10,
                    CoefficientName = "AI_ML",
                    HasCoefficient = true
                },
                
                // Software Engineering
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 3,
                    CoefficientName = "SoftwareEngineering",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 11,
                    CoefficientName = "SoftwareEngineering",
                    HasCoefficient = true
                },
                
                // Database Engineering
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 1,
                    CoefficientName = "DatabaseEngineering",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 2,
                    CoefficientName = "DatabaseEngineering",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 7,
                    CoefficientName = "DatabaseEngineering",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 10,
                    CoefficientName = "DatabaseEngineering",
                    HasCoefficient = true
                },
                
                // Security
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 2,
                    CoefficientName = "Security",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 4,
                    CoefficientName = "Security",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 5,
                    CoefficientName = "Security",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 6,
                    CoefficientName = "Security",
                    HasCoefficient = true
                },
                
                // NETWORKS
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 4,
                    CoefficientName = "Networks",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 5,
                    CoefficientName = "Networks",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 8,
                    CoefficientName = "Networks",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 9,
                    CoefficientName = "Networks",
                    HasCoefficient = true
                },
                
                // WebDev
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 4,
                    CoefficientName = "WebDev",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 6,
                    CoefficientName = "WebDev",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 9,
                    CoefficientName = "WebDev",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 13,
                    CoefficientName = "WebDev",
                    HasCoefficient = true
                },
                
                //UI_UX
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 13,
                    CoefficientName = "UI_UX",
                    HasCoefficient = true
                },
                
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 14,
                    CoefficientName = "UI_UX",
                    HasCoefficient = true
                },
                
                // GAMEDEV
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 12,
                    CoefficientName = "GameDev",
                    HasCoefficient = true
                },
                
                // Mobile App Dev
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 13,
                    CoefficientName = "MobileAppDev",
                    HasCoefficient = true
                },
                
                // GAMEDEV
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 12,
                    CoefficientName = "ComputerVisionAndGraphics",
                    HasCoefficient = true
                }
            );
        }

        private void SeedDataToCoefficientsCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseHasCoefficient>().HasData(

                // mobile dev
                new CourseHasCoefficient { CourseId = 3, CoefficientName = "MobileAppDev", Value = 2 },
                new CourseHasCoefficient { CourseId = 2, CoefficientName = "MobileAppDev", Value = 5 },
                new CourseHasCoefficient { CourseId = 1, CoefficientName = "MobileAppDev", Value = 10 },
                
                // game dev
                new CourseHasCoefficient { CourseId = 4, CoefficientName = "GameDev", Value = 6 },
                new CourseHasCoefficient { CourseId = 6, CoefficientName = "GameDev", Value = 10 },
                new CourseHasCoefficient { CourseId = 5, CoefficientName = "GameDev", Value = 9 },
                
                // security
                new CourseHasCoefficient { CourseId = 7, CoefficientName = "Security", Value = 8 },
                new CourseHasCoefficient { CourseId = 8, CoefficientName = "Security", Value = 10 },
                new CourseHasCoefficient { CourseId = 9, CoefficientName = "Security", Value = 10 },

                // ui/ux
                new CourseHasCoefficient { CourseId = 10, CoefficientName = "UI_UX", Value = 3 },
                new CourseHasCoefficient { CourseId = 11, CoefficientName = "UI_UX", Value = 10 },
                
                // ai/ml
                new CourseHasCoefficient { CourseId = 12, CoefficientName = "AI_ML", Value = 7 },
                new CourseHasCoefficient { CourseId = 13, CoefficientName = "AI_ML", Value = 8 },
                new CourseHasCoefficient { CourseId = 14, CoefficientName = "AI_ML", Value = 9 },
                new CourseHasCoefficient { CourseId = 5, CoefficientName = "AI_ML", Value = 10 },
                
                // web dev
                new CourseHasCoefficient { CourseId = 10, CoefficientName = "WebDev", Value = 5 },
                new CourseHasCoefficient { CourseId = 17, CoefficientName = "WebDev", Value = 9 },
                new CourseHasCoefficient { CourseId = 18, CoefficientName = "WebDev", Value = 10 },
                
                // data eng
                new CourseHasCoefficient { CourseId = 15, CoefficientName = "DatabaseEngineering", Value = 6 },
                new CourseHasCoefficient { CourseId = 16, CoefficientName = "DatabaseEngineering", Value = 10 },
                new CourseHasCoefficient { CourseId = 14, CoefficientName = "DatabaseEngineering", Value = 10 },

                // networks
                new CourseHasCoefficient { CourseId = 10, CoefficientName = "ComputerNetworks", Value = 3 },
                new CourseHasCoefficient { CourseId = 19, CoefficientName = "ComputerNetworks", Value = 10 },
                new CourseHasCoefficient { CourseId = 9, CoefficientName = "ComputerNetworks", Value = 7 },
                
                // computer vision
                new CourseHasCoefficient { CourseId = 12, CoefficientName = "ComputerVisionAndGraphics", Value = 6 },
                new CourseHasCoefficient { CourseId = 23, CoefficientName = "ComputerVisionAndGraphics", Value = 9 },
                new CourseHasCoefficient { CourseId = 20, CoefficientName = "ComputerVisionAndGraphics", Value = 10 },
                
                // software engineering
                new CourseHasCoefficient { CourseId = 1, CoefficientName = "SoftwareEngineering", Value = 10 },
                new CourseHasCoefficient { CourseId = 21, CoefficientName = "SoftwareEngineering", Value = 10 },
                new CourseHasCoefficient { CourseId = 22, CoefficientName = "SoftwareEngineering", Value = 10 }
            );
        }

        private void SeedDataToCareer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Career>().HasData(
                
                // soft eng
                new Career { Name = "Software Developer", NameInGreek = "Προγραμματιστής Λογισμικού", CoefficientName = "SoftwareEngineering" },
                new Career { Name = "Full-Stack Developer", NameInGreek = "Προγραμματιστής Full-Stack", CoefficientName = "SoftwareEngineering" },
                new Career { Name = "DevOps Engineer", NameInGreek = "Μηχανικός DevOps", CoefficientName = "SoftwareEngineering" },
                new Career { Name = "Software Consultant", NameInGreek = "Σύμβουλος Λογισμικού", CoefficientName = "SoftwareEngineering" },
                
                // ai_ml
                new Career { Name = "Machine Learning Engineer", NameInGreek = "Μηχανικός Μηχανικής Μάθησης", CoefficientName = "AI_ML" },
                new Career { Name = "Data Scientist", NameInGreek = "Επιστήμονας Δεδομένων", CoefficientName = "AI_ML" },
                new Career { Name = "N.L.P. Engineer", NameInGreek = "Μηχανικός Επεξεργασίας Φυσικής Γλώσσας", CoefficientName = "AI_ML" },
                new Career { Name = "Robotics Engineer", NameInGreek = "Μηχανικός Ρομποτικής", CoefficientName = "AI_ML" },
                
                // ui_ux
                new Career { Name = "UI/UX Designer", NameInGreek = "Σχεδιαστής UI/UX", CoefficientName = "UI_UX" },
                new Career { Name = "Visual Designer", NameInGreek = "Οπτικός Σχεδιαστής", CoefficientName = "UI_UX" },
                new Career { Name = "Front-End Developer", NameInGreek = "Προγραμματιστής Front-End", CoefficientName = "UI_UX" },
                new Career { Name = "Accessibility Specialist", NameInGreek = "Ειδικός Προσβασιμότητας", CoefficientName = "UI_UX" },
                
                // game dev
                new Career { Name = "Games Programmer", NameInGreek = "Προγραμματιστής Ηλεκτρονικών Παιχνιδιών", CoefficientName = "GameDev" },
                new Career { Name = "Games Designer", NameInGreek = "Σχεδιαστής Ηλεκτρονικών Παιχνιδιών", CoefficientName = "GameDev" },
                new Career { Name = "Level Designer", NameInGreek = "Σχεδιαστής Επιπέδων Ηλεκτρονικών Παιχνιδιών", CoefficientName = "GameDev" },

                // mobile app dev
                new Career { Name = "Mobile App Developer", NameInGreek = "Προγραμματιστής Εφαρμογών Κινητών Τηλεφώνων", CoefficientName = "MobileAppDev" },
                new Career { Name = "iOS Developer", NameInGreek = "Προγραμματιστής Εφαρμογών για iOS", CoefficientName = "MobileAppDev" },
                new Career { Name = "Android Developer", NameInGreek = "Προγραμματιστής Εφαρμογών για Android", CoefficientName = "MobileAppDev" },
                new Career { Name = "Mobile UI/UX Designer", NameInGreek = "Σχεδιαστής UI/UX για Εφαρμογές Κινητών Τηλεφώνων", CoefficientName = "MobileAppDev" },
                
                // database engineer
                new Career { Name = "Big Data Engineer", NameInGreek = "Μηχανικός Δεδομένων Μεγάλου Όγκου", CoefficientName = "DatabaseEngineering" },
                new Career { Name = "Data Architect", NameInGreek = "Αρχιτέκτονας Δεδομένων", CoefficientName = "DatabaseEngineering" },
                new Career { Name = "Database Developer", NameInGreek = "Προγραμματιστής Βάσεων Δεδομένων", CoefficientName = "DatabaseEngineering" },
                new Career { Name = "Cloud Data Engineer", NameInGreek = "Μηχανικός Δεδομένων Υπολογιστικής Νέφους", CoefficientName = "DatabaseEngineering" },
                
                // computer networks
                new Career { Name = "Network Administrator", NameInGreek = "Διαχειριστής Δικτύων", CoefficientName = "ComputerNetworks" },
                new Career { Name = "Network Engineer", NameInGreek = "Μηχανικός Δικτύων", CoefficientName = "ComputerNetworks" },
                new Career { Name = "Network Security Specialist", NameInGreek = "Ειδικός Ασφάλειας Δικτύων", CoefficientName = "ComputerNetworks" },
                
                // computer vision and graphics 
                new Career { Name = "Computer Vision Engineer", NameInGreek = "Μηχανικός Γραφικών Υπολογιστών", CoefficientName = "ComputerVisionAndGraphics" },
                new Career { Name = "Computer Graphics Programmer", NameInGreek = "Προγραμματιστής Γραφικών", CoefficientName = "ComputerVisionAndGraphics" },
                new Career { Name = "3D Artist/Animator", NameInGreek = "Σχεδιαστής Τρισδιάστατων Σχεδίων", CoefficientName = "ComputerVisionAndGraphics" },
                new Career { Name = "Virtual Reality Developer", NameInGreek = "Προγραμματιστής Εικονικής Πραγματικότητας", CoefficientName = "ComputerVisionAndGraphics" },
                
                // security 
                new Career { Name = "Security Analyst", NameInGreek = "Αναλυτής Ασφαλείας", CoefficientName = "Security" },
                new Career { Name = "Penetration Tester", NameInGreek = "Ελεγκτής Διείσδυσης", CoefficientName = "Security" },
                new Career { Name = "Security Engineer", NameInGreek = "Μηχανικός Ασφαλείας", CoefficientName = "Security" },
                new Career { Name = "Incident Responder", NameInGreek = "Ανταποκριτής Συμβάντων", CoefficientName = "Security" },
                
                // webdev
                new Career { Name = "Back-End Developer", NameInGreek = "Προγραμματιστής Back-End", CoefficientName = "WebDev" },
                new Career { Name = "Web Designer", NameInGreek = "Σχεδιαστής Ιστοσελίδων", CoefficientName = "WebDev" },
                new Career { Name = "Web App Developer", NameInGreek = "Προγραμματιστής Διαδικτυακών Εφαρμογών", CoefficientName = "WebDev" }
                );
        }

        private void SeedDataToQuestionsAndAnswers(ModelBuilder modelBuilder)
        {
            // QUESTIONS
            modelBuilder.Entity<Question>().HasData(
                
                // OOP
                new Question { Id = 1, Content = "Ένα από τα αντικέιμενα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός η ομαδική εργασία.", CourseId = 3 },
                new Question { Id = 2, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 3 },
                new Question { Id = 3, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 3 },
                new Question { Id = 4, Content = "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί να θα παράγουν εφαρμογές πελάτη-εξυπηρετητή.", CourseId = 3 },
                new Question { Id = 5, Content = "Το κύριο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός  είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού ______.", CourseId = 3 },
                new Question { Id = 6, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να χειρίζονται αρχεία προορισμένα για _________ και αποθήκευση δεδομένων.", CourseId = 3 },
                new Question { Id = 7, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν την έννοια της κληρονομικότητας.", CourseId = 3 },
                new Question { Id = 8, Content = "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί  να παράγουν εφαρμογές με αποδοτικό και ταχύ ρυθμό.", CourseId = 3 },
                new Question { Id = 9, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να διαχειρίζονται αποτελεσματικά και με χρήση των κατάλληλων εργαλείων τις ________ που ανακύπτουν.", CourseId = 3 },
                new Question { Id = 10, Content = "Ποιο από τα παρακάτω ΔΕΝ ανήκει στο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 3 },
            
                // VR
                new Question { Id = 11, Content = "Η Εικονική Πραγματικότητα είναι το επιστημονικό πεδίο με αντικείμενο την αναπαράσταση κόσμων με τη βοήθεια ηλεκτρονικών υπολογιστών.", CourseId = 4 },
                new Question { Id = 12, Content = "Τα ______ με υπολογιστές διαδραματίζουν βασικό ρόλο στην Εικονική Πραγματικότητα.", CourseId = 4 },
                new Question { Id = 13, Content = "Η Εικονική Πραγματικότητα, κυρίως μέσω των _______ Εικονικών Συστημάτων, έχει πλήθος εφαρμογών στην εκπαίδευση, την ψυχαγωγία, την προσομοίωση, την αλληλεπίδραση ανθρώπου – υπολογιστή και την επιστημονική έρευνα", CourseId = 4 },
                new Question { Id = 14, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί αντικείμενο του μαθήματος Εικονική Πραγματικότητα;", CourseId = 4 },
                new Question { Id = 15, Content = "Στόχος του μαθήματος Εικονική Πραγματικότητα είναι να αποκτήσουν οι φοιτητές γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.", CourseId = 4 },
                new Question { Id = 16, Content = "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη συστημάτων Εικονικής Πραγματικότητας;", CourseId = 4 },
                new Question { Id = 17, Content = "Στόχος του μαθήματος Εικονική Πραγματικότητα είναι η εξοικείωση των φοιτητών με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων εφαρμογών Εικονικής Πραγματικότητας.", CourseId = 4 },
                new Question { Id = 18, Content = "Μέσω της παρακολούθησης του μαθήματος Εικονική Πραγματικότητα ο φοιτητής γνωρίζει τις ________ ενός συστήματος Εικονικής Πραγματικότητας.", CourseId = 4 },
                new Question { Id = 19, Content = "Ποιο από τα παρακάτω αποτελεί διδακτική ενότητα του μαθήματος Εικονική Πραγματικότητα;", CourseId = 4 },
                new Question { Id = 20, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί διδακτική ενότητα του μαθήματος Εικονική Πραγματικότητα;", CourseId = 4 },
                
                // android
                new Question { Id = 21, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 1 },
                new Question { Id = 22, Content = "Η ανάπτυξη των mobile apps στο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού  υλοποιείται με τη χρήση του περιβάλλοντος ανάπτυξης λογισμικού ___________.", CourseId = 1 },
                new Question { Id = 23, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 1 },
                new Question { Id = 24, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 1 },
                new Question { Id = 25, Content = "Tο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού καλύπτει και την ύλη που αφορά στους αισθητήρες των κινητών συσκευών, στις υπηρεσίες γεοεντοπισμού και σε πλήθος άλλων προχωρημένων τεχνικών προγραμματισμού.", CourseId = 1 },
                new Question { Id = 26, Content = "Η ύλη του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", CourseId = 1 },
                new Question { Id = 27, Content = "Ένα από τα αντκείμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι η “Ανάλυση απαιτήσεων: __________ Ανάλυση και Αντικειμενοστρεφής Ανάλυση”.", CourseId = 1 },
                new Question { Id = 28, Content = "Ποιο από τα παρακάτω αποτελεί μοντέλο ανάπτυξης λογισμικού που αναλύεται στα πλαίσια του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 1 },
                new Question { Id = 29, Content = "Ένα από τα αντικέιμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι προϋπολογισμός κόστους λογισμικού.", CourseId = 1 },
                new Question { Id = 30, Content = "Παρακολουθώντας το μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού, μπορεί κανείς να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες ______ και Mobile backend as a service που παρέχει η Firebase.", CourseId = 1 },

                // intelligent agents
                new Question { Id = 31, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μπορεί να εφαρμόζει τα μοντέλα “αντιλαμβάνομαι-αποφασίζω-ενεργώ” (Sense-Decide-Act), BDI (Belief-Desire-Intention), σε διάφορες περιπτώσεις πρακτόρων.", CourseId = 5 },
                new Question { Id = 32, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής διακρίνει και εκτιμά πότε είναι απαραίτητος ένας _________ πράκτορας και πότε βουλητικός πράκτορας.", CourseId = 5 },
                new Question { Id = 33, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής κατανοεί την ____ ενός ευφυούς πράκτορα", CourseId = 5 },
                new Question { Id = 34, Content = "Ποίο από τα παρακάτω αποτελεί είδος ευφυούς πράκτορα που μελετάται στο μάθυμα Ευφυείς Πράκτορες;", CourseId = 5 },
                new Question { Id = 35, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες  ο φοιτητής  αναπτύσσει αλγορίθμους για εύρεση μονοπατιού (path finding), και σχεδιασμό ενεργειών (plan generation)", CourseId = 5 },
                new Question { Id = 36, Content = "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη εφαρμογών ευφυή πρακτόρων;", CourseId = 5 },
                new Question { Id = 37, Content = "Η συναισθηματική διαλεκτική σε ευφυείς πράκτορες αποτελεί αντικείμενο του μαθήματος Ευφυείς Πράκτορες.", CourseId = 5 },
                new Question { Id = 38, Content = "Μέσω της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μαθαίνει να εφαρμόζει το μοντέλο “αντιλαμβάνομαι-αποφασίζω-________”", CourseId = 5 },
                new Question { Id = 39, Content = "Αντικείμενο του μαθήματος Ευφυείς Πράκτορες είναι  ο σχεδιασμός ενεργειών, βασισμένος σε κίνητρα και η πυραμίδα του ________.", CourseId = 5 },
                new Question { Id = 40, Content = "Mε ποιο είδος πρακτόρων θα ασχοληθούν οι φοιτητές στα πλαίσια του μαθληματος Ευφυείς Πράκτορες;", CourseId = 5 },
                
                // video games
                new Question { Id = 41, Content = "Παρακολουθώντας το μάθημα Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών, οι φοιτητές θα μπορούν να αναπτύσουν εφαρμογές ηλεκτρονικών παιχνιδιών στο περιβάλλον της Python.", CourseId = 6 },
                new Question { Id = 42, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές βασικές γνώσεις για τον ρόλο, τους τύπους και τα ________ των παιχνιδιών, καθώς και για τη συνολική διαδικασία δημιουργίας ενός παιχνιδιού.", CourseId = 6 },
                new Question { Id = 43, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές ικανότητες σχεδίασης και _________ παιχνιδιών αξιοποιώντας σύγχρονα εργαλεία, διασυνδέσεις και γλώσσες προγραμματισμού,", CourseId = 6 },
                new Question { Id = 44, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί κατηγορία ηλεκτρονικών παιχνιδιών;", CourseId = 6 },
                new Question { Id = 45, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.", CourseId = 6 },
                new Question { Id = 46, Content = "Στα πλάισια του μαθήαμτος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών ο φοιτητής μαθαίνει να συνοψίζει τις απαιτούμενες γνώσεις σχετικά με την ανάπτυξη ηλεκτρονικών παιχνιδιών στο περιβάλλον της ________", CourseId = 6 },
                new Question { Id = 47, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι η εξοικείωση των φοιτητών με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων διαδικτυακών εφαρμογών.", CourseId = 6 },
                new Question { Id = 48, Content = "Το αντικείενο του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών περιλαμβάνει τη σχεδίαση ενός παιχνιδιού σε ________.", CourseId = 6 },
                new Question { Id = 49, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί συστατικά ηλεκτρονικών παιχνιδιών στο Διαδίκτυο;", CourseId = 6 },
                new Question { Id = 50, Content = "Ο κόσμος ενός ηλεκτρονικού αποτελείται από χαρακτήρες που μπορεί να είναι...;", CourseId = 6 },
                
                // antikeimenostrefhs anaptyxh
                new Question { Id = 51, Content = "Η ύλη του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", CourseId = 2 },
                new Question { Id = 52, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν _______, web, ή/και mobile εφαρμογές.", CourseId = 2 },
                new Question { Id = 53, Content = "Ποιο εργαλείο ανάπτυξης εφαρμογών χρησιμοποιείται στα πλαίσια του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 2 },
                new Question { Id = 54, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν λογισμικό για ένα μεγάλο πλήθος από πεδία, συμπεριλαμβανομένων των παραθυρικών εφαρμογών, των εφαρμογών κονσόλας, των εφαρμογών web και των mobile εφαρμογών.", CourseId = 2 },
                new Question { Id = 55, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές εκτίθονται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του παραγόμενου _________, καθώς και την ταχύτητα ανάπτυξης σύνθετων και πολύπλοκων προγραμμάτων/έργων.", CourseId = 2 },
                new Question { Id = 56, Content = "Στο πλαίσιο του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών δίνεται ιδιαίτερη έμφαση στα ολοκληρωμένα περιβάλλοντα ανάπτυξης τα οποία ονομάζονται και:", CourseId = 2 },
                new Question { Id = 57, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναγνωρίζουν και να εξηγούν τι είναι γλώσσα και γραμματική και πώς συμβολίζονται.", CourseId = 2 },
                new Question { Id = 58, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθάινουν να κάνουν ________ λογισμικού με τα πλέον σύγχρονα εργαλεία.", CourseId = 2 },
                new Question { Id = 59, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 2 },
                new Question { Id = 60, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών , οι φοιτητές μαθάινουν να παράγουν εφαρμογές με _______ και ταχύ ρυθμό.", CourseId = 2 },
                
                // cryptography, 
                new Question { Id = 61, Content = "Η ύλη του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", CourseId = 7 },
                new Question { Id = 62, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν _______, web, ή/και mobile εφαρμογές.", CourseId = 7 },
                new Question { Id = 63, Content = "Ποιο εργαλείο ανάπτυξης εφαρμογών χρησιμοποιείται στα πλαίσια του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 7 },
                new Question { Id = 64, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν λογισμικό για ένα μεγάλο πλήθος από πεδία, συμπεριλαμβανομένων των παραθυρικών εφαρμογών, των εφαρμογών κονσόλας, των εφαρμογών web και των mobile εφαρμογών.", CourseId = 7 },
                new Question { Id = 65, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές εκτίθονται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του παραγόμενου _________, καθώς και την ταχύτητα ανάπτυξης σύνθετων και πολύπλοκων προγραμμάτων/έργων.", CourseId = 7 },
                new Question { Id = 66, Content = "Στο πλαίσιο του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών δίνεται ιδιαίτερη έμφαση στα ολοκληρωμένα περιβάλλοντα ανάπτυξης τα οποία ονομάζονται και:", CourseId = 7 },
                new Question { Id = 67, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναγνωρίζουν και να εξηγούν τι είναι γλώσσα και γραμματική και πώς συμβολίζονται.", CourseId = 7 },
                new Question { Id = 68, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθάινουν να κάνουν ________ λογισμικού με τα πλέον σύγχρονα εργαλεία.", CourseId = 7 },
                new Question { Id = 69, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 7 },
                new Question { Id = 70, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών , οι φοιτητές μαθάινουν να παράγουν εφαρμογές με _______ και ταχύ ρυθμό.", CourseId = 7 },
                
                // asfaleia p.s.
                new Question { Id = 71, Content = "Παρακολουθώντας το μάθημα Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών, οι φοιτητές θα μπορούν να αναπτύσουν εφαρμογές ηλεκτρονικών παιχνιδιών στο περιβάλλον της Python.", CourseId = 8 },
                new Question { Id = 72, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές βασικές γνώσεις για τον ρόλο, τους τύπους και τα ________ των παιχνιδιών, καθώς και για τη συνολική διαδικασία δημιουργίας ενός παιχνιδιού.", CourseId = 8 },
                new Question { Id = 73, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές ικανότητες σχεδίασης και _________ παιχνιδιών αξιοποιώντας σύγχρονα εργαλεία, διασυνδέσεις και γλώσσες προγραμματισμού,", CourseId = 8 },
                new Question { Id = 74, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί κατηγορία ηλεκτρονικών παιχνιδιών;", CourseId = 8 },
                new Question { Id = 75, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι να αποκτήσουν οι φοιτητές γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.", CourseId = 8 },
                new Question { Id = 76, Content = "Στα πλάισια του μαθήαμτος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών ο φοιτητής μαθαίνει να συνοψίζει τις απαιτούμενες γνώσεις σχετικά με την ανάπτυξη ηλεκτρονικών παιχνιδιών στο περιβάλλον της ________", CourseId = 8 },
                new Question { Id = 77, Content = "Στόχος του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών είναι η εξοικείωση των φοιτητών με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων διαδικτυακών εφαρμογών.", CourseId = 8 },
                new Question { Id = 78, Content = "Το αντικείενο του μαθήματος Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών περιλαμβάνει τη σχεδίαση ενός παιχνιδιού σε ________.", CourseId = 8 },
                new Question { Id = 79, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί συστατικά ηλεκτρονικών παιχνιδιών στο Διαδίκτυο;", CourseId = 8 },
                new Question { Id = 80, Content = "Ο κόσμος ενός ηλεκτρονικού αποτελείται από χαρακτήρες που μπορεί να είναι...;", CourseId = 8 },
                
                // asfaleia d.
                new Question { Id = 81, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μπορεί να εφαρμόζει τα μοντέλα “αντιλαμβάνομαι-αποφασίζω-ενεργώ” (Sense-Decide-Act), BDI (Belief-Desire-Intention), σε διάφορες περιπτώσεις πρακτόρων.", CourseId = 9 },
                new Question { Id = 82, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής διακρίνει και εκτιμά πότε είναι απαραίτητος ένας _________ πράκτορας και πότε βουλητικός πράκτορας.", CourseId = 9 },
                new Question { Id = 83, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής κατανοεί την ____ ενός ευφυούς πράκτορα", CourseId = 9 },
                new Question { Id = 84, Content = "Ποίο από τα παρακάτω αποτελεί είδος ευφυούς πράκτορα που μελετάται στο μάθυμα Ευφυείς Πράκτορες;", CourseId = 9 },
                new Question { Id = 85, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες  ο φοιτητής  αναπτύσσει αλγορίθμους για εύρεση μονοπατιού (path finding), και σχεδιασμό ενεργειών (plan generation)", CourseId = 9 },
                new Question { Id = 86, Content = "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη εφαρμογών ευφυή πρακτόρων;", CourseId = 9 },
                new Question { Id = 87, Content = "Η συναισθηματική διαλεκτική σε ευφυείς πράκτορες αποτελεί αντικείμενο του μαθήματος Ευφυείς Πράκτορες.", CourseId = 9 },
                new Question { Id = 88, Content = "Μέσω της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μαθαίνει να εφαρμόζει το μοντέλο “αντιλαμβάνομαι-αποφασίζω-________”", CourseId = 9 },
                new Question { Id = 89, Content = "Αντικείμενο του μαθήματος Ευφυείς Πράκτορες είναι  ο σχεδιασμός ενεργειών, βασισμένος σε κίνητρα και η πυραμίδα του ________.", CourseId = 9 },
                new Question { Id = 90, Content = "Mε ποιο είδος πρακτόρων θα ασχοληθούν οι φοιτητές στα πλαίσια του μαθληματος Ευφυείς Πράκτορες;", CourseId = 9 },
                
                // texnologies diadiktyoy
                new Question { Id = 91, Content = "Ένα από τα αντικέιμενα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός η ομαδική εργασία.", CourseId = 10 },
                new Question { Id = 92, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 10 },
                new Question { Id = 93, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 10 },
                new Question { Id = 94, Content = "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί να θα παράγουν εφαρμογές πελάτη-εξυπηρετητή.", CourseId = 10 },
                new Question { Id = 95, Content = "Το κύριο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός  είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού ______.", CourseId = 10 },
                new Question { Id = 96, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να χειρίζονται αρχεία προορισμένα για _________ και αποθήκευση δεδομένων.", CourseId = 10 },
                new Question { Id = 97, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν την έννοια της κληρονομικότητας.", CourseId = 10 },
                new Question { Id = 98, Content = "Παρακολουθώντας το μάθημα Αντικειμενοστρεφής Προγραμματισμός, οι φοιτητές είναι ικανοί  να παράγουν εφαρμογές με αποδοτικό και ταχύ ρυθμό.", CourseId = 10 },
                new Question { Id = 99, Content = "Στα πλαίσια του μαθήματος Αντικειμενοστρεφής Προγραμματισμός οι φοιτητές μαθαίνουν να διαχειρίζονται αποτελεσματικά και με χρήση των κατάλληλων εργαλείων τις ________ που ανακύπτουν.", CourseId = 10 },
                new Question { Id = 100, Content = "Ποιο από τα παρακάτω ΔΕΝ ανήκει στο αντικείμενο του μαθήματος Αντικειμενοστρεφής Προγραμματισμός;", CourseId = 10 },
                
                // diktya
                new Question { Id = 101, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 19 },
                new Question { Id = 102, Content = "Η ανάπτυξη των mobile apps στο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού  υλοποιείται με τη χρήση του περιβάλλοντος ανάπτυξης λογισμικού ___________.", CourseId = 19 },
                new Question { Id = 103, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 19 },
                new Question { Id = 104, Content = "Ποιο από τα παρακάτω ΔΕΝ αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 19 },
                new Question { Id = 105, Content = "Tο μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού καλύπτει και την ύλη που αφορά στους αισθητήρες των κινητών συσκευών, στις υπηρεσίες γεοεντοπισμού και σε πλήθος άλλων προχωρημένων τεχνικών προγραμματισμού.", CourseId = 19 },
                new Question { Id = 106, Content = "Η ύλη του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", CourseId = 19 },
                new Question { Id = 107, Content = "Ένα από τα αντκείμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι η “Ανάλυση απαιτήσεων: __________ Ανάλυση και Αντικειμενοστρεφής Ανάλυση”.", CourseId = 19 },
                new Question { Id = 108, Content = "Ποιο από τα παρακάτω αποτελεί μοντέλο ανάπτυξης λογισμικού που αναλύεται στα πλαίσια του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού;", CourseId = 19 },
                new Question { Id = 109, Content = "Ένα από τα αντικέιμενα του μαθήματος Σύγχρονα Θέματα Τεχνολογίας Λογισμικού είναι προϋπολογισμός κόστους λογισμικού.", CourseId = 19 },
                new Question { Id = 110, Content = "Παρακολουθώντας το μάθημα Σύγχρονα Θέματα Τεχνολογίας Λογισμικού, μπορεί κανείς να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες ______ και Mobile backend as a service που παρέχει η Firebase.", CourseId = 19 },
                
                // allilepidrash
                new Question { Id = 111, Content = "Η ύλη του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού C#.", CourseId = 11 },
                new Question { Id = 112, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν _______, web, ή/και mobile εφαρμογές.", CourseId = 11 },
                new Question { Id = 113, Content = "Ποιο εργαλείο ανάπτυξης εφαρμογών χρησιμοποιείται στα πλαίσια του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 11 },
                new Question { Id = 114, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναπτύσσουν λογισμικό για ένα μεγάλο πλήθος από πεδία, συμπεριλαμβανομένων των παραθυρικών εφαρμογών, των εφαρμογών κονσόλας, των εφαρμογών web και των mobile εφαρμογών.", CourseId = 11 },
                new Question { Id = 115, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές εκτίθονται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του παραγόμενου _________, καθώς και την ταχύτητα ανάπτυξης σύνθετων και πολύπλοκων προγραμμάτων/έργων.", CourseId = 11 },
                new Question { Id = 116, Content = "Στο πλαίσιο του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών δίνεται ιδιαίτερη έμφαση στα ολοκληρωμένα περιβάλλοντα ανάπτυξης τα οποία ονομάζονται και:", CourseId = 11 },
                new Question { Id = 117, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθαίνουν να αναγνωρίζουν και να εξηγούν τι είναι γλώσσα και γραμματική και πώς συμβολίζονται.", CourseId = 11 },
                new Question { Id = 118, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών, οι φοιτητές μαθάινουν να κάνουν ________ λογισμικού με τα πλέον σύγχρονα εργαλεία.", CourseId = 11 },
                new Question { Id = 119, Content = "Ποιο από τα παρακάτω αποτελεί μαθησιακό αποτέλεσμα του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών;", CourseId = 11 },
                new Question { Id = 120, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών , οι φοιτητές μαθάινουν να παράγουν εφαρμογές με _______ και ταχύ ρυθμό.", CourseId = 11 },
                
                // programmatismos sto diadiktyo kai ston pagkosmio isto
                new Question { Id = 121, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μπορεί να εφαρμόζει τα μοντέλα “αντιλαμβάνομαι-αποφασίζω-ενεργώ” (Sense-Decide-Act), BDI (Belief-Desire-Intention), σε διάφορες περιπτώσεις πρακτόρων.", CourseId = 17 },
                new Question { Id = 122, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής διακρίνει και εκτιμά πότε είναι απαραίτητος ένας _________ πράκτορας και πότε βουλητικός πράκτορας.", CourseId = 17 },
                new Question { Id = 123, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής κατανοεί την ____ ενός ευφυούς πράκτορα", CourseId = 17 },
                new Question { Id = 124, Content = "Ποίο από τα παρακάτω αποτελεί είδος ευφυούς πράκτορα που μελετάται στο μάθυμα Ευφυείς Πράκτορες;", CourseId = 17 },
                new Question { Id = 125, Content = "Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες  ο φοιτητής  αναπτύσσει αλγορίθμους για εύρεση μονοπατιού (path finding), και σχεδιασμό ενεργειών (plan generation)", CourseId = 17 },
                new Question { Id = 126, Content = "Πως ονομάζεται το περιβάλλον με το οποίο θα εξοικιωθούν οι φοιτητές για την ανάπτηξη εφαρμογών ευφυή πρακτόρων;", CourseId = 17 },
                new Question { Id = 127, Content = "Η συναισθηματική διαλεκτική σε ευφυείς πράκτορες αποτελεί αντικείμενο του μαθήματος Ευφυείς Πράκτορες.", CourseId = 17 },
                new Question { Id = 128, Content = "Μέσω της παρακολούθησης του μαθήματος Ευφυείς Πράκτορες ο φοιτητής μαθαίνει να εφαρμόζει το μοντέλο “αντιλαμβάνομαι-αποφασίζω-________”", CourseId = 17 },
                new Question { Id = 129, Content = "Αντικείμενο του μαθήματος Ευφυείς Πράκτορες είναι  ο σχεδιασμός ενεργειών, βασισμένος σε κίνητρα και η πυραμίδα του ________.", CourseId = 17 },
                new Question { Id = 130, Content = "Mε ποιο είδος πρακτόρων θα ασχοληθούν οι φοιτητές στα πλαίσια του μαθληματος Ευφυείς Πράκτορες;", CourseId = 17 }
                
            );

            // ANSWERS
            modelBuilder.Entity<Answer>().HasData(
                
                // OOP
                new Answer { Id = 1, QuestionId = 1, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 2, QuestionId = 2, Answer1 = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα", Answer2 = "Να γνωρίζουν τις βασικές αρχές της γλώσσας C#", Answer3 = "Να μπορούν να αξιοποιήσουν τις βασικές αλγοριθμικές δομές σε γλώσσα C++", Answer4 = "Να μπορούν να υλοποιούν προγραμματισμό sockets (TCP sockets και UDP sockets).", CorrectAnswer = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα" },
                new Answer { Id = 3, QuestionId = 3, Answer1 = "Να μπορούν να σχεδιάζουν και να υλοποιούν αλγόριθμους για την αποτελεσματική κατασκευή συνδυαστικών αντικειμένων.", Answer2 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", Answer3 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer4 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", CorrectAnswer = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης." },
                new Answer { Id = 4, QuestionId = 4, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 5, QuestionId = 5, Answer1 = "Java", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Java" },
                new Answer { Id = 6, QuestionId = 6, Answer1 = "Ανάγνωση", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Ανάγνωση" },
                new Answer { Id = 7, QuestionId = 7, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 8, QuestionId = 8, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 9, QuestionId = 9, Answer1 = "Εξαιρέσεις", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Εξαιρέσεις" },
                new Answer { Id = 10, QuestionId = 10, Answer1 = "Αυτόνομη εργασία", Answer2 = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)", Answer3 = "Προσαρμογή σε νέες καταστάσεις", Answer4 = "Σχεδιασμός και διαχείριση έργων", CorrectAnswer = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)" },
                
                // VR
                new Answer { Id = 11, QuestionId = 11, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 12, QuestionId = 12, Answer1 = "γραφικά", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "γραφικά" },
                new Answer { Id = 13, QuestionId = 13, Answer1 = "ευφυών", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "ευφυών" },
                new Answer { Id = 14, QuestionId = 14, Answer1 = "Υφή επιφάνειας αντικειμένων. Διαχείριση πηγών φωτός, ήχων, κάμερας. Animations.", Answer2 = "Ανάπτυξη εφαρμογών εικονικής πραγματικότητας στην πλατφόρμα Unity3D.", Answer3 = "Κόσμοι τρισδιάστατων γραφικών. Τρισδιάστατα μοντέλα αντικειμένων.", Answer4 = "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού.", CorrectAnswer = "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού." },
                new Answer { Id = 15, QuestionId = 15, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 16, QuestionId = 16, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 17, QuestionId = 17, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 18, QuestionId = 18, Answer1 = "συνιστώσες", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "συνιστώσες" },
                new Answer { Id = 19, QuestionId = 19, Answer1 = "Μετρήσεις Αντικειμένου Εικόνας", Answer2 = "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση.", Answer3 = "Δομή και την λειτουργία ενός ευφυούς πράκτορα μέσα σε ένα περιβάλλον.", Answer4 = "Αντιδρασιακοί πράκτορες (Reactive Agents) και Βουλητικοί πράκτορες (Deliberative Agents).", CorrectAnswer = "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση." },
                new Answer { Id = 20, QuestionId = 20, Answer1 = "VRML: sensors και animation, γενικές αρχές μοντελοποίησης σκελετού, πρότυπα μοντελοποίησης κίνησης σώματος (H-Anim, κ.ά.), scripting, ενσωμάτωση σε εφαρμογές, PROTOs, προτεινόμενες πρακτικές σχεδιασμού και ανάπτυξης.", Answer2 = "VRML: σύνταξη, υλοποιήσεις, βασικά εργαλεία, γεωμετρία, μετασχηματισμοί, επαναχρησιμοποίηση κόμβων, εξωτερικές αναφορές, υλικά/χρώμα, φωτισμός, υφή, viewpoints, background, ήχος, κείμενο, billboards, HUDs.", Answer3 = "Γράφημα σκηνής, υλοποιήσεις (Java3D, VRML/X3D, κ.ά.)", Answer4 = "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης", CorrectAnswer = "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης" },

                // android
                new Answer { Id = 21, QuestionId = 21, Answer1 = "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες", Answer2 = "Να αναλύει και να συγκρίνει μοντέλα ανάπτυξης λογισμικού", Answer3 = "Να αναπτύσσει native mobile apps κάνοντας χρήση του Android SDK", Answer4 = "Να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", CorrectAnswer = "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες" },
                new Answer { Id = 22, QuestionId = 22, Answer1 = "Android Studio", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Android Studio" },
                new Answer { Id = 23, QuestionId = 23, Answer1 = "Να σχεδιάζει και να αναπτύσσει εφαρμογές για κινητές και φορητές συσκευές υλοποιώντας τις πλέον σύγχρονες τεχνικές προγραμματισμού.", Answer2 = "Να εκμεταλλεύεται τοπικές (SQLite) βάσεις δεδομένων.", Answer3 = "Να επιλέγει μοντέλα ανάπτυξης λογισμικού ανάλογα με τις ανάγκες και να τα χρησιμοποιεί.", Answer4 = "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP.", CorrectAnswer = "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP." },
                new Answer { Id = 24, QuestionId = 24, Answer1 = "Να διασφαλίζει την αποτελεσματικότητα των λογισμικών μέσω των προαναφερθέντων εφαρμογών.", Answer2 = "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST.", Answer3 = "Να αξιοποιεί το εργαλείο Android Studio για την ανάπτυξη κινητών εφαρμογών.", Answer4 = "Να γνωρίζει τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", CorrectAnswer = "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST." },
                new Answer { Id = 25, QuestionId = 25, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 26, QuestionId = 26, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 27, QuestionId = 27, Answer1 = "Δομημένη", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Δομημένη" },
                new Answer { Id = 28, QuestionId = 28, Answer1 = "Scrum", Answer2 = "Firebase", Answer3 = "Rational Unified Process", Answer4 = "DevOps", CorrectAnswer = "Rational Unified Process" },
                new Answer { Id = 29, QuestionId = 29, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 30, QuestionId = 30, Answer1 = "Cloud", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Cloud" },
                
                // intelligent agents
                new Answer { Id = 31, QuestionId = 31, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 32, QuestionId = 32, Answer1 = "αντιδρασιακός", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αντιδρασιακός" },
                new Answer { Id = 33, QuestionId = 33, Answer1 = "δομή", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "δομή" },
                new Answer { Id = 34, QuestionId = 34, Answer1 = "Cleaning Agents", Answer2 = "Radioactive Agents", Answer3 = "Deliberative Agents", Answer4 = "Federal Agents", CorrectAnswer = "Deliberative Agents" },
                new Answer { Id = 35, QuestionId = 35, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 36, QuestionId = 36, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 37, QuestionId = 37, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 38, QuestionId = 38, Answer1 = "ενεργώ", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "ενεργώ" },
                new Answer { Id = 39, QuestionId = 39, Answer1 = "Maslow", Answer2 = "Khafre", Answer3 = "Djoser", Answer4 = "Cheops", CorrectAnswer = "Maslow" },
                new Answer { Id = 40, QuestionId = 40, Answer1 = "Reactive Agents", Answer2 = "Deliberative Agents", Answer3 = "Κανένα από τα δύο", Answer4 = "Και τα δύο", CorrectAnswer = "Και τα δύο" },
                
                // video games
                new Answer { Id = 41, QuestionId = 41, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 42, QuestionId = 42, Answer1 = "χαρακτηριστικά", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "χαρακτηριστικά" },
                new Answer { Id = 43, QuestionId = 43, Answer1 = "υλοποίησης", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "υλοποίησης" },
                new Answer { Id = 44, QuestionId = 44, Answer1 = "First Person", Answer2 = "Educational", Answer3 = "Role-playing", Answer4 = "Fourth Person", CorrectAnswer = "Fourth Person" },
                new Answer { Id = 45, QuestionId = 45, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 46, QuestionId = 46, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 47, QuestionId = 47, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 48, QuestionId = 48, Answer1 = "C", Answer2 = "C++", Answer3 = "PythonFmu", Answer4 = "C#", CorrectAnswer = "C#" },
                new Answer { Id = 49, QuestionId = 49, Answer1 = "3D μοντέλα", Answer2 = "bolts", Answer3 = "sprites", Answer4 = "animations", CorrectAnswer = "bolts" },
                new Answer { Id = 50, QuestionId = 50, Answer1 = "Παίκτες", Answer2 = "Πράκτορες", Answer3 = "Κανένα από τα δύο", Answer4 = "Και τα δύο", CorrectAnswer = "Και τα δύο" },
                
                // antikeimenostrfhs anmptyjh
                new Answer { Id = 51, QuestionId = 51, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 52, QuestionId = 52, Answer1 = "desktop", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "desktop" },
                new Answer { Id = 53, QuestionId = 53, Answer1 = "Visual Studio Enterprise Edition", Answer2 = "IntelliJ IDEA", Answer3 = "Visual Studio Code", Answer4 = "QtSpim", CorrectAnswer = "Visual Studio Enterprise Edition" },
                new Answer { Id = 54, QuestionId = 54, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 55, QuestionId = 55, Answer1 = "λογισμικού", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "λογισμικού" },
                new Answer { Id = 56, QuestionId = 56, Answer1 = "IDEs", Answer2 = "GUIs", Answer3 = "GNUs", Answer4 = "ICPs", CorrectAnswer = "IDEs" },
                new Answer { Id = 57, QuestionId = 57, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 58, QuestionId = 58, Answer1 = "αποσφαλμάτωση", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποσφαλμάτωση" },
                new Answer { Id = 59, QuestionId = 59, Answer1 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer2 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", Answer3 = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού.", Answer4 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", CorrectAnswer = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού." },
                new Answer { Id = 60, QuestionId = 60, Answer1 = "αποδοτικό", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποδοτικό" },
                
                // cryptography
                new Answer { Id = 61, QuestionId = 61, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 62, QuestionId = 62, Answer1 = "desktop", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "desktop" },
                new Answer { Id = 63, QuestionId = 63, Answer1 = "Visual Studio Enterprise Edition", Answer2 = "IntelliJ IDEA", Answer3 = "Visual Studio Code", Answer4 = "QtSpim", CorrectAnswer = "Visual Studio Enterprise Edition" },
                new Answer { Id = 64, QuestionId = 64, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 65, QuestionId = 65, Answer1 = "λογισμικού", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "λογισμικού" },
                new Answer { Id = 66, QuestionId = 66, Answer1 = "IDEs", Answer2 = "GUIs", Answer3 = "GNUs", Answer4 = "ICPs", CorrectAnswer = "IDEs" },
                new Answer { Id = 67, QuestionId = 67, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 68, QuestionId = 68, Answer1 = "αποσφαλμάτωση", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποσφαλμάτωση" },
                new Answer { Id = 69, QuestionId = 69, Answer1 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer2 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", Answer3 = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού.", Answer4 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", CorrectAnswer = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού." },
                new Answer { Id = 70, QuestionId = 70, Answer1 = "αποδοτικό", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποδοτικό" },
                
                // asfaleia p.s.
                new Answer { Id = 71, QuestionId = 71, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 72, QuestionId = 72, Answer1 = "χαρακτηριστικά", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "χαρακτηριστικά" },
                new Answer { Id = 73, QuestionId = 73, Answer1 = "υλοποίησης", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "υλοποίησης" },
                new Answer { Id = 74, QuestionId = 74, Answer1 = "First Person", Answer2 = "Educational", Answer3 = "Role-playing", Answer4 = "Fourth Person", CorrectAnswer = "Fourth Person" },
                new Answer { Id = 75, QuestionId = 75, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 76, QuestionId = 76, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 77, QuestionId = 77, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 78, QuestionId = 78, Answer1 = "C", Answer2 = "C++", Answer3 = "PythonFmu", Answer4 = "C#", CorrectAnswer = "C#" },
                new Answer { Id = 79, QuestionId = 79, Answer1 = "3D μοντέλα", Answer2 = "bolts", Answer3 = "sprites", Answer4 = "animations", CorrectAnswer = "bolts" },
                new Answer { Id = 80, QuestionId = 80, Answer1 = "Παίκτες", Answer2 = "Πράκτορες", Answer3 = "Κανένα από τα δύο", Answer4 = "Και τα δύο", CorrectAnswer = "Και τα δύο" },
                
                // asfaleia d.
                new Answer { Id = 81, QuestionId = 81, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 82, QuestionId = 82, Answer1 = "αντιδρασιακός", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αντιδρασιακός" },
                new Answer { Id = 83, QuestionId = 83, Answer1 = "δομή", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "δομή" },
                new Answer { Id = 84, QuestionId = 84, Answer1 = "Cleaning Agents", Answer2 = "Radioactive Agents", Answer3 = "Deliberative Agents", Answer4 = "Federal Agents", CorrectAnswer = "Deliberative Agents" },
                new Answer { Id = 85, QuestionId = 85, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 86, QuestionId = 86, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 87, QuestionId = 87, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 88, QuestionId = 88, Answer1 = "ενεργώ", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "ενεργώ" },
                new Answer { Id = 89, QuestionId = 89, Answer1 = "Maslow", Answer2 = "Khafre", Answer3 = "Djoser", Answer4 = "Cheops", CorrectAnswer = "Maslow" },
                new Answer { Id = 90, QuestionId = 90, Answer1 = "Reactive Agents", Answer2 = "Deliberative Agents", Answer3 = "Κανένα από τα δύο", Answer4 = "Και τα δύο", CorrectAnswer = "Και τα δύο" },
                
                // texnologies diadiktyoy
                new Answer { Id = 91, QuestionId = 91, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 92, QuestionId = 92, Answer1 = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα", Answer2 = "Να γνωρίζουν τις βασικές αρχές της γλώσσας C#", Answer3 = "Να μπορούν να αξιοποιήσουν τις βασικές αλγοριθμικές δομές σε γλώσσα C++", Answer4 = "Να μπορούν να υλοποιούν προγραμματισμό sockets (TCP sockets και UDP sockets).", CorrectAnswer = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα" },
                new Answer { Id = 93, QuestionId = 93, Answer1 = "Να μπορούν να σχεδιάζουν και να υλοποιούν αλγόριθμους για την αποτελεσματική κατασκευή συνδυαστικών αντικειμένων.", Answer2 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", Answer3 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer4 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", CorrectAnswer = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης." },
                new Answer { Id = 94, QuestionId = 94, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 95, QuestionId = 95, Answer1 = "Java", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Java" },
                new Answer { Id = 96, QuestionId = 96, Answer1 = "Ανάγνωση", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Ανάγνωση" },
                new Answer { Id = 97, QuestionId = 97, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 98, QuestionId = 98, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 99, QuestionId = 99, Answer1 = "Εξαιρέσεις", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Εξαιρέσεις" },
                new Answer { Id = 100, QuestionId = 100, Answer1 = "Αυτόνομη εργασία", Answer2 = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)", Answer3 = "Προσαρμογή σε νέες καταστάσεις", Answer4 = "Σχεδιασμός και διαχείριση έργων", CorrectAnswer = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)" },

                // diktya
                new Answer { Id = 101, QuestionId = 101, Answer1 = "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες", Answer2 = "Να αναλύει και να συγκρίνει μοντέλα ανάπτυξης λογισμικού", Answer3 = "Να αναπτύσσει native mobile apps κάνοντας χρήση του Android SDK", Answer4 = "Να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", CorrectAnswer = "Να εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες" },
                new Answer { Id = 102, QuestionId = 102, Answer1 = "Android Studio", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Android Studio" },
                new Answer { Id = 103, QuestionId = 103, Answer1 = "Να σχεδιάζει και να αναπτύσσει εφαρμογές για κινητές και φορητές συσκευές υλοποιώντας τις πλέον σύγχρονες τεχνικές προγραμματισμού.", Answer2 = "Να εκμεταλλεύεται τοπικές (SQLite) βάσεις δεδομένων.", Answer3 = "Να επιλέγει μοντέλα ανάπτυξης λογισμικού ανάλογα με τις ανάγκες και να τα χρησιμοποιεί.", Answer4 = "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP.", CorrectAnswer = "Να γνωρίζει τις τεχνικές σηματοδοσίας, διαχείρισης κινητικότητας και το πρωτόκολλο Mobile IP." },
                new Answer { Id = 104, QuestionId = 104, Answer1 = "Να διασφαλίζει την αποτελεσματικότητα των λογισμικών μέσω των προαναφερθέντων εφαρμογών.", Answer2 = "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST.", Answer3 = "Να αξιοποιεί το εργαλείο Android Studio για την ανάπτυξη κινητών εφαρμογών.", Answer4 = "Να γνωρίζει τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase", CorrectAnswer = "Να αναγνωρίζει αρχές σχεδίασης λογισμικού με REST." },
                new Answer { Id = 105, QuestionId = 105, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 106, QuestionId = 106, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 107, QuestionId = 107, Answer1 = "Δομημένη", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Δομημένη" },
                new Answer { Id = 108, QuestionId = 108, Answer1 = "Scrum", Answer2 = "Firebase", Answer3 = "Rational Unified Process", Answer4 = "DevOps", CorrectAnswer = "Rational Unified Process" },
                new Answer { Id = 109, QuestionId = 109, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 110, QuestionId = 110, Answer1 = "Cloud", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Cloud" },
                
                // allilepidrasi
                new Answer { Id = 111, QuestionId = 111, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 112, QuestionId = 112, Answer1 = "desktop", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "desktop" },
                new Answer { Id = 113, QuestionId = 113, Answer1 = "Visual Studio Enterprise Edition", Answer2 = "IntelliJ IDEA", Answer3 = "Visual Studio Code", Answer4 = "QtSpim", CorrectAnswer = "Visual Studio Enterprise Edition" },
                new Answer { Id = 114, QuestionId = 114, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 115, QuestionId = 115, Answer1 = "λογισμικού", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "λογισμικού" },
                new Answer { Id = 116, QuestionId = 116, Answer1 = "IDEs", Answer2 = "GUIs", Answer3 = "GNUs", Answer4 = "ICPs", CorrectAnswer = "IDEs" },
                new Answer { Id = 117, QuestionId = 117, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 118, QuestionId = 118, Answer1 = "αποσφαλμάτωση", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποσφαλμάτωση" },
                new Answer { Id = 119, QuestionId = 119, Answer1 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer2 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", Answer3 = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού.", Answer4 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", CorrectAnswer = "Να μαθαίνουν, να αξιολογούν και να εντοπίζουν λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού." },
                new Answer { Id = 120, QuestionId = 120, Answer1 = "αποδοτικό", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αποδοτικό" },
                
                // programmatismos sto diadiktyo kai ston pagkosmio isto
                new Answer { Id = 121, QuestionId = 121, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 122, QuestionId = 122, Answer1 = "αντιδρασιακός", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "αντιδρασιακός" },
                new Answer { Id = 123, QuestionId = 123, Answer1 = "δομή", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "δομή" },
                new Answer { Id = 124, QuestionId = 124, Answer1 = "Cleaning Agents", Answer2 = "Radioactive Agents", Answer3 = "Deliberative Agents", Answer4 = "Federal Agents", CorrectAnswer = "Deliberative Agents" },
                new Answer { Id = 125, QuestionId = 125, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Σωστό" },
                new Answer { Id = 126, QuestionId = 126, Answer1 = "Unity3D", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "Unity3D" },
                new Answer { Id = 127, QuestionId = 127, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = "", Answer4 = "", CorrectAnswer = "Λάθος" },
                new Answer { Id = 128, QuestionId = 128, Answer1 = "ενεργώ", Answer2 = "", Answer3 = "", Answer4 = "", CorrectAnswer = "ενεργώ" },
                new Answer { Id = 129, QuestionId = 129, Answer1 = "Maslow", Answer2 = "Khafre", Answer3 = "Djoser", Answer4 = "Cheops", CorrectAnswer = "Maslow" },
                new Answer { Id = 130, QuestionId = 130, Answer1 = "Reactive Agents", Answer2 = "Deliberative Agents", Answer3 = "Κανένα από τα δύο", Answer4 = "Και τα δύο", CorrectAnswer = "Και τα δύο" }
            );
        }

        private static string AndroidDesc()
        {
            return @"Αντικείμενο Μαθήματος:
                        1. Μοντέλα ανάπτυξης λογισμικού: Μοντέλο καταρράκτη, Σπειροειδές μοντέλο, Μοντέλο Πρωτοτύπου, Rational Unified Process.
                        2. Προϋπολογισμός κόστους λογισμικού.
                        3. Ανάλυση απαιτήσεων: Δομημένη Ανάλυση και Αντικειμενοστρεφής Ανάλυση.
                        4. Σχεδιασμός: Αρχιτεκτονικός σχεδιασμός, λεπτομερής σχεδιασμός, Δομημένος και Αντικειμενοστρεφής σχεδιασμός.
                        5. Ανάπτυξη εφαρμογών, οι οποίες μπορούν να εκτελεστούν από σύγχρονες κινητές συσκευές (smartphones) με ενσωματωμένο λειτουργικό σύστημα. Οι εφαρμογές αυτές δύναται να λειτουργήσουν τόσο στα σύγχρονα «έξυπνα» τηλέφωνα ""smartphones"", όσο και σε άλλες «κινητές» συσκευές, οι οποίες έχουν κάνει την εμφάνισή τους τα τελευταία χρόνια και χρησιμοποιούν λειτουργικό σύστημα (Tablets, Wearables).

                        Στο μάθημα αναλύονται περιληπτικά τα δημοφιλέστερα λειτουργικά συστήματα κινητών συσκευών, καθώς και τα εργαλεία ανάπτυξης εφαρμογών σε αυτά, ωστόσο η ύλη περιλαμβάνει κυρίως τη χρήση της αντικειμενοστρεφούς γλώσσας προγραμματισμού Java, για την ανάπτυξη εφαρμογών σε κινητές συσκευές υπό το λειτουργικό σύστημα Android. Ενδεικτικά, η ανάπτυξη των mobile apps υλοποιείται με τη χρήση του περιβάλλοντος ανάπτυξης λογισμικού Android Studio.
                        Επιπλέον το μάθημα καλύπτει και την ύλη που αφορά στους αισθητήρες των κινητών συσκευών, στις υπηρεσίες γεοεντοπισμού και σε πλήθος άλλων προχωρημένων τεχνικών προγραμματισμού (asynchronous programming, android services, broadcast receivers, android intents).

                        Μαθησιακά αποτελέσματα:
                        • Να αναλύει και να συγκρίνει μοντέλα ανάπτυξης λογισμικού.
                        • Να επιλέγει μοντέλα ανάπτυξης λογισμικού ανάλογα με τις ανάγκες και να τα χρησιμοποιεί.
                        • Να αξιοποιεί το εργαλείο Android Studio για την ανάπτυξη κινητών εφαρμογών.
                        • Να αναπτύσσει native mobile apps κάνοντας χρήση του Android SDK.
                        • Να εκμεταλλεύεται τοπικές (SQLite) βάσεις δεδομένων.
                        • Να γνωρίζει τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase
                        • Να χρησιμοποιεί πρακτικά τις πλέον σύγχρονες υπηρεσίες Cloud και Mobile backend as a service που παρέχει η Firebase
                        • Να σχεδιάζει και να αναπτύσσει εφαρμογές για κινητές και φορητές συσκευές υλοποιώντας τις πλέον σύγχρονες τεχνικές προγραμματισμού.
                        • Να διασφαλίζει την αποτελεσματικότητα των λογισμικών μέσω των προαναφερθέντων εφαρμογών.";
        }
        private static string AAEDesc()
        {
            return
                @"Αντικείμενο του μαθήματος είναι η ανάπτυξη εφαρμογών βάσει του αντικειμενοστρεφούς μοντέλου ανάπτυξης λογισμικού. Η γλώσσα προγραμματισμού που χρησιμοποιείται ως βάση είναι η C#, που θεωρείται από τις πλέον σύγχρονες αντικειμενοστρεφείς γλώσσες. Στο πλαίσιο του μαθήματος δίνεται ιδιαίτερη έμφαση στα εργαλεία ανάπτυξης εφαρμογών, ολοκληρωμένα περιβάλλοντα ανάπτυξης (IDEs) και συγκεκριμένα το εργαλείο που χρησιμοποιείται είναι το Visual Studio Enterprise Edition. Με τη χρήση του Visual Studio και της C# ως γλώσσας προγραμματισμού, οι φοιτητές μαθαίνουν να αναπτύσσουν desktop, web, ή/και mobile εφαρμογές, γρήγορα, αποδοτικά και κυρίως με την όσο το δυνατόν μικρότερη πιθανότητα να κάνουν λάθη προγραμματισμού ή/και λογικής.

                Μαθησιακά αποτελέσματα:
                • Να χρησιμοποιεί ολοκληρωμένα περιβάλλοντα ανάπτυξης λογισμικού.
                • Να παράγει εφαρμογές με αποδοτικό και ταχύ ρυθμό
                • Να γνωρίζει τις βασικές αρχές της γλώσσας C#
                • Να κάνει αποσφαλμάτωση λογισμικού με τα πλέον σύγχρονα εργαλεία
                • Να αναπτύσσει λογισμικό για ένα μεγάλο πλήθος από πεδία, συμπεριλαμβανομένων των παραθυρικών εφαρμογών, των εφαρμογών κονσόλας, των εφαρμογών web και των mobile εφαρμογών
                • Να εκτίθεται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του παραγόμενου λογισμικού, καθώς και την ταχύτητα ανάπτυξης σύνθετων και πολύπλοκων προγραμμάτων/έργων
                • Να μαθαίνει να αξιολογεί και να εντοπίζει λογισμικό υλοποιημένο με εργαλεία οπτικού προγραμματισμού";
        }
        private static string OOPDesc()
        {
            return @"Αντικείμενο μαθήματος:
            1. Αναζήτηση, ανάλυση και σύνθεση δεδομένων και πληροφοριών, με τη χρήση και των απαραίτητων τεχνολογιών.
            2. Αυτόνομη εργασία.
            3. Ομαδική εργασία.
            4. Σχεδιασμός και διαχείριση έργων.
            5. Προσαρμογή σε νέες καταστάσεις.
                Το κύριο αντικείμενο του μαθήματος είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού JAVA. Βασικές δομές, κληρονομικότητα, εντολές, ειδικές κλάσεις, εξαιρέσεις, ειδικά θέματα, βιβλιοθήκες/διαπροσωπίες,  προσπέλαση αρχείων και Βάσεων, κα.  
            Μαθησιακά αποτελέσματα:
                • Να γνωρίζουν τις βασικές αρχές που διέπουν τον αντικειμενοστρεφή προγραμματισμό
                • Να υλοποιούν αντικειμενοστρεφή προγράμματα
                • Να σχεδιάζουν, να αναπτύσσουν και να υλοποιούν λογισμικό ως λύσεις σε προβλήματα, αποτελούμενο από αντικείμενα και αλλληλεπιδράσεις αυτών.
                • Να δημιουργούν τάξεις, διεπαφές και αντικείμενα.
                • Να χρησιμοποιούν σωστά τους modifiers της γλώσσας Java.
                • Να διαχειρίζονται αποτελεσματικά και με χρήση των κατάλληλων εργαλείων τις εξαιρέσεις που ανακύπτουν
                • Να χειρίζονται αρχεία προορισμένα για ανάγνωση και αποθήκευση δεδομένων
                • Να συμβαδίζουν με τις εναλασσόμενες τεχνολογικές απαιτήσεις καθώς εκτίθενται σε σύγχρονες τεχνικές προγραμματισμού με στόχο την ποιότητα του λογισμικού τους
                • Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.";

        }
        private static string VRDesc()
        {
            return
                @"Η Εικονική Πραγματικότητα είναι το επιστημονικό πεδίο με αντικείμενο την αναπαράσταση κόσμων με τη βοήθεια ηλεκτρονικών υπολογιστών. Τα γραφικά με υπολογιστές διαδραματίζουν βασικό ρόλο στην Εικονική Πραγματικότητα, ενώ άλλα θέματα εξ’ ίσου σημαντικά είναι ο ήχος και το υλικό αλληλεπίδρασης με τους χρήστες. Η Εικονική Πραγματικότητα, κυρίως μέσω των Ευφυών Εικονικών Συστημάτων, έχει πλήθος εφαρμογών στην εκπαίδευση, την ψυχαγωγία, την προσομοίωση, την αλληλεπίδραση ανθρώπου – υπολογιστή και την επιστημονική έρευνα.
 
Σκοποί του μαθήματος:
Στόχος του μαθήματος είναι η εξοικείωση των φοιτητών με τις βασικές θεωρητικές αρχές στις οποίες στηρίζεται η Εικονική Πραγματικότητα, καθώς και με σύγχρονες τεχνολογίες, μεθόδους και εργαλεία για τη δημιουργία ολοκληρωμένων εφαρμογών Εικονικής Πραγματικότητας.
 
Δομή του μαθήματος:
Κατά τη διάρκεια του μαθήματος θα καλυφθούν οι παρακάτω διδακτικές ενότητες:
•	Eισαγωγή στην Εικονική Πραγματικότητα, ιστορική αναδρομή, βασικές έννοιες, στόχοι, εφαρμογές.
•	Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση.
•	Γράφημα σκηνής, υλοποιήσεις (Java3D, VRML/X3D, κ.ά.)
•	VRML: σύνταξη, υλοποιήσεις, βασικά εργαλεία, γεωμετρία, μετασχηματισμοί, επαναχρησιμοποίηση κόμβων, εξωτερικές αναφορές, υλικά/χρώμα, φωτισμός, υφή, viewpoints, background, ήχος, κείμενο, billboards, HUDs.
•	VRML: sensors και animation, γενικές αρχές μοντελοποίησης σκελετού, πρότυπα μοντελοποίησης κίνησης σώματος (H-Anim, κ.ά.), scripting, ενσωμάτωση σε εφαρμογές, PROTOs, προτεινόμενες πρακτικές σχεδιασμού και ανάπτυξης.
•	Συστήματα υλικού και λογισμικού Εικονικής Πραγματικότητας.
•	Second Life και OpenSimulator.


Αντικείμενο μαθήματος:
1. Δομή και λειτουργία ενός συστήματος εικονικής πραγματικότητας. Υλικό, Λογισμικό.
2. Κατηγορίες συστημάτων Εικονικής Πραγματικότητας.
3. Κόσμοι τρισδιάστατων γραφικών. Τρισδιάστατα μοντέλα αντικειμένων.
4. Υφή επιφάνειας αντικειμένων. Διαχείριση πηγών φωτός, ήχων, κάμερας. Animations.
5. Το περιβάλλον Unity3D.
6. Ανάπτυξη εφαρμογών εικονικής πραγματικότητας στην πλατφόρμα Unity3D.

Μαθησιακά αποτελέσματα:
• Γνωρίζει τις συνιστώσες ενός συστήματος Εικονικής Πραγματικότητας.
• Κατανοεί τις παραμέτρους ανάπτυξης συστημάτων Εικονικής Πραγματικότητας στο περιβάλλον της Unity3D.
• Αναπτύσσει και υλοποιεί εφαρμογές εικονικής πραγματικότητας στο περιβάλλον της Unity3D.
• Κατανοεί τη διαχείριση τρισδιάστατων μοντέλων αντικειμένων, κάμερας, ήχου, διάφορα είδη υφής, animations, κ.λπ.
• Ανακαλύπτει διάφορα μοντέλα εικονικής πραγματικότητας στο Διαδίκτυο.
• Συνδυάζει και ενσωματώνει τα παραπάνω, σε ένα ολοκληρωμένο λειτουργικό σύστημα Εικονικής Πραγματικότητας.
• Εντοπίζει και αξιολογεί τα δεδομένα τυχόν προβλημάτων σε λειτουργικό επίπεδο.
• Εφευρίσκει τρόπους επίλυσης των προβλημάτων και βελτιστοποίησης των λειτουργιών στα εικονικά περιβάλλοντα.";

        }
        private static string IntelligentAgentsDesc()
        {
            return @"1. Δομή και την λειτουργία ενός ευφυούς πράκτορα μέσα σε ένα περιβάλλον.
            2. Αντιδρασιακοί πράκτορες (Reactive Agents) και Βουλητικοί πράκτορες (Deliberative Agents).
            3. Ο κύκλος αντιλαμβάνομαι-αποφασίζω-ενεργώ (Sense-Decide-Act).
            4. Tο μοντέλο BDI (Belief-Desire-Intention), εύρεση μονοπατιού (path finding), αναπαράσταση ενεργειών (action representation).
            5. O σχεδιασμός ενεργειών (plan generation), ο σχεδιασμός ενεργειών, βασισμένος σε κίνητρα και η πυραμίδα του Maslow.
            6. Η συναισθηματική υπολογιστική σε ευφυείς πράκτορες.
            7. Η ανάπτυξη σχετικών συστημάτων ευφυών πρακτόρων.
            8. Οι εφαρμογές στην πλατφόρμα Unity3D.

                Μαθησιακά αποτελέσματα:
            Μετά την ολοκλήρωση της παρακολούθησης του μαθήματος ο φοιτητής :
                • κατανοεί την δομή ενός ευφυούς πράκτορα,
                • αναγνωρίζει τα χαρακτηριστικά τη λειτουργίας ενός ευφυούς πράκτορα και τους τρόπους επικοινωνίας του με ένα περιβάλλον,
                • διακρίνει και εκτιμά πότε είναι απαραίτητος ένας Αντιδρασιακός πράκτορας (Reactive Agent) και πότε Βουλητικός πράκτορας (Deliberative Agent),
                • εφαρμόζει τα μοντέλα “αντιλαμβάνομαι-αποφασίζω-ενεργώ” (Sense-Decide-Act), BDI (Belief-Desire-Intention), σε διάφορες περιπτώσεις πρακτόρων,
                • αναπτύσσει αλγορίθμους για εύρεση μονοπατιού (path finding), και σχεδιασμό ενεργειών (plan generation),
                • αξιολογεί πότε είναι απαραίτητο να εφαρμοστεί σχεδιασμός ενεργειών βασισμένος σε κίνητρα και συναισθηματική υπολογιστική σε ευφυείς πράκτορες.";

        }
        private static string VideoGamesDesc()
        {
            return
                @"1.	Ο ρόλος των παιχνιδιών ως εργαλείων εκπαίδευσης, απόκτησης δεξιοτήτων και προσομοίωσης σε διάφορους τομείς, όπως  εκπαίδευση, υγεία και επιχειρηματικές διεργασίες. 
2.	Τύποι και κατηγορίες ηλεκτρονικών παιχνιδιών. Shoot-them-up, Role-playing, Adventure, First Person, Third Person, Δικτυακά παιχνίδια πολλών Παικτών. MMORPGs, Serious Games, Educational Games
3.	Τύποι και χαρακτηριστικά παιχνιδιών. Επισκόπηση χαρακτηριστικών παραδειγμάτων παιχνιδιών σοβαρού σκοπού που έχουν αναπτυχθεί για διάφορους τομείς.
4.	Σχεδίαση ενός παιχνιδιού: ο κόσμος, οι χαρακτήρες (παίκτες και πράκτορες) και οι ενέργειες τους, τα επίπεδα του παιχνιδιού. Αρχές και μεθοδολογίες σχεδίασης. Παρουσίαση των σχετικών εννοιών μέσω της σχεδίασης ενός απλού εκπαιδευτικού παιχνιδιού σε ένα εκπαιδευτικό προγραμματιστικό περιβάλλον, όπως το Unity3D. Αξιολόγηση της ποιότητας σχεδίασης υπαρχόντων παιχνιδιών σοβαρού σκοπού. Εργαλεία, μηχανές και διασυνδέσεις προγραμματισμού παιχνιδιών.
5.	Προγραμματισμός παιχνιδιών: ο βρόχος του παιχνιδιού, αρχιτεκτονική του παιχνιδιού, γραφική διασύνδεση, αλληλεπίδραση και χειρισμός συμβάντων, κείμενο, 2D/3D γραφικά και κίνηση, πίνακες και συλλογές αντικειμένων.
6.	Σχεδίαση ενός παιχνιδιού σοβαρού σκοπού χρησιμοποιώντας σύγχρονες μηχανές παιχνιδιών/βιβλιοθήκες και προγραμματισμός του παιχνιδιού σε C#.
7.	Το περιβάλλον Unity3D. Ανάπτυξη ηλεκτρονικών παιχνιδιών στην πλατφόρμα Unity3D.
 
Μαθησιακοί στόχοι:
Στόχος του μαθήματος είναι να αποκτήσουν οι φοιτητές: 
(α) βασικές γνώσεις για τον ρόλο, τους τύπους και τα χαρακτηριστικά των παιχνιδιών, καθώς και για τη συνολική διαδικασία δημιουργίας ενός παιχνιδιού,
(β) ικανότητες σχεδίασης και υλοποίησης παιχνιδιών αξιοποιώντας σύγχρονα εργαλεία, διασυνδέσεις και γλώσσες προγραμματισμού,
(γ) γνώσεις και ικανότητες χρήσης/δημιουργίας μετρικών αξιολόγησης παιχνιδιών βάσει των στόχων που τέθηκαν κατά τη σχεδίασή τους.

Μαθησιακά αποτελέσματα:
• Αναγνωρίζει τις συνιστώσες ενός ηλεκτρονικού παιχνιδιού (Computer Game).
• Κατανοεί τις συνιστώσες των σοβαρών και εκπαιδευτικών παιχνιδιών (serious games, educational games)
• Συνοψίζει τις απαιτούμενες γνώσεις σχετικά με την ανάπτυξη ηλεκτρονικών παιχνιδιών στο περιβάλλον της Unity3D.
• Αναπτύσει εφαρμογές ηλεκτρονικών παιχνιδιών στο περιβάλλον της Unity3D
• Ανακαλύπτει τους τρόπους διαχείρισης των διαφόρων συστατικών ενός ηλεκτρονικού παιχνιδιού, κ.λπ.
• Μαθαίνει να ανακαλύπτει διάφορα συστατικά ηλεκτρονικών παιχνιδιών στο Διαδίκτυο (π.χ. 3D μοντέλα, sprites, animations, κ.λπ.)
• Συνδυάζει όλα τα παραπάνω στο πλαίσιο του σχεδιασμού και της ανάπτυξης ενός ολοκληρωμένου ηλεκτρονικού παιχνιδιού.";

        }
        private static string CryptographyDesc()
        {
            return
                @"Η κρυπτογραφία αποτελεί τα θεμέλια της ασφάλειας υπολογιστικών συστημάτων. Βασικό σκοπός είναι οι φοιτητές να αποκτήσουν το απαραίτητοθεωρητικό υπόβαθρο για την κατασκευή προγραμμάτων ή συσκευών οι οποίες ανταλλάσσουν δεδομένα με ασφάλεια μέσα σε μη ασφαλείς χώρους όπως τοδιαδίκτυο.
                Αντικείμενο μαθήματος:
            1. Ιστορική εξέλιξη της κρυπτογραφίας
            2. Επανάληψη του απαραίτητου μαθηματικού υπόβαθρου (Ομάδες, Πεπερασμένα σώματα, Δακτύλιοι Zp και Zn, Πράξεις με υπόλοιπα, Γενικευμένος αλγόριθμος του Ευκλείδη, συνάρτηση του Euler)
            3. Αλγόριθμοι ιδιωτικού κλειδιού (Μονοαλφαβητική αντικατάσταση, One-Time-Pad, Αλγόριθμοι των : Καίσαρα, Vigenere, Hill)
            4. Αλγόρθιμοι τμημάτων: καταστάσεις (cipher modes: ECB, CBC, OFB κτλ) DES, AES
            5. Αλγόριθμοι ροής: PRNG vs TRNG, LFSR, RC4
            6. Αλγόριθμοι δημοσίου κλειδιού (Αλγόριθμος RSA,Αλγόριθμος ελλειπτικών καμπυλών)
            7. Ομομορφική κρυπτογραφία
            8. Συναρτήσεις κατακερματισμού
            9. Ψηφιακές Υπογραφές
            10. Εφαρμογές της κρυπτογραφίας και πρωτόκολλα
            11. Κρυπτανάλυση (Γραμμική και διαφορική κρυπτανάλυση, Αλγόριθμοι παραγοντοποίησης)
            12. Θέματα υλοποίησης

                Μαθησιακά αποτελέσματα:
            Μετά την επιτυχή ολοκλήρωση του μαθήματος, οι φοιτητές θα είναι σε θέση:
                • Να αξιολογήσουν την ασφάλεια που προσφέρει ένας αλγόριθμος κρυπτογράφησης.
                • Να διακρίνουν και να κατηγοριοποιούν τα είδη και τη χρήση των αλγόριθμων.
                • Να επιλέξουν τον κατάλληλο αλγόριθμο και να διακρίνουν τις παραμέτρους της ορθής ταση λειτουργίας του για την επιτυχή εφαρμογή του.
                • Να υλοποιήσουν έναν αλγόριθμο κρυπτογράφησης.
                • Να κατανοούν σε βάθος τις εφαρμογές και τα πρωτόκολλα της κρυπτογραφίας.
                • Να γνωρίζουν τις μεθόδους και παραμέτρους σχεδιασμού και ανάπτυξης πρωτοκόλλων.
                • Να εντοπίζουν και να αξιολογούν πιθανά κενά ασφάλειας ενός πρωτοκόλλου.
                • Να αξιοποιούν όλα τα παραπάνω για την ανάπτυξη και τον έλεγχο προγραμμάτων";

        }
        private static string AsfaleiaPSDesc()
        {
            return @"Αντικείμενο μαθήματος:
Η ασφάλεια της πληροφορίας, των συστημάτων και των εφαρμογών, αποτελεί βασική απαίτηση κατά την ανάπτυξη και λειτουργία πληροφοριακών συστημάτων. Το μάθημα καλύπτει βασικά ζητήματα της ασφάλειας πληροφοριακών συστημάτων και περιλαμβάνει τις εξής ενότητες:
1. Εισαγωγικές έννοιες ασφάλειας συστημάτων.
2. Συστήματα Διαχείρισης Ασφάλειας.
3. Κρυπτογραφικά συστήματα.
4. Υποδομή Δημόσιας Κλείδας.
5. Έλεγχος προσπέλασης – Ιδιωτικότητα.
6. Ασφάλεια στις Τεχνολογίες.
7. Ασφαλείς η/κ-υπηρεσίες.
8. Εισαγωγή στην ασφάλεια δικτύων.

Μαθησιακά αποτελέσματα:
Με την ολοκλήρωση του μαθήματος οι φοιτητές θα μπορούν να:
• Αναγνωρίζουν και να κατανοούν το περιεχόμενο των απαιτήσεων ασφάλειας πληροφοριακών συστημάτων σε όλο των κύκλο ζωής τους.
• Αντιλαμβάνονται και να εντοπίζουν τα θεωρητικά και πρακτικά ζητήματα ασφάλειας πληροφοριακών συστημάτων.
• Κατανοούν τα δομικά και λειτουργικά χαρακτηριστικά των κρυπτογραφικών συστημάτων.
• Εμβαθύνουν σε βασικούς τομείς του πεδίου αυτού και να υλοποιούν (μέσω προσομοίωσης) τεχνικές ή εφαρμογές σε δεδομένες καταστάσεις απειλών ή κινδύνων.
• Εφαρμόζουν πρακτικά τεχνολογίες ασφάλειας πληροφοριακών συστημάτων σε πραγματικές συνθήκες.
• Σχεδιάζουν νέες εφαρμογές και να επεκτείνουν τις ήδη υπάρχουσες.
• Διαχειρίζονται απειλές και κινδύνους στα πληροφοριακά συστήματα με κριτική, δημιουργική και ερευνητική διάθεση για την εξεύρεση λύσεων.";
        }
        private static string AsfaleiaDiktywnDesc()
        {
            return @"Αντικείμενο μαθήματος:
Σκοπός του μαθήματος είναι η θεωρητική και πρακτική μελέτη θεμάτων ασφάλειας σε όλα τα επίπεδα δικτύων. Στο πλαίσιο του μαθήματος θα αναλυθούν οι παρακάτω ενότητες:
1. Εισαγωγή στην ασφάλεια δικτύων.
2. Ασφάλεια Δρομολόγησης.
3. Σχεδιασμός συστημάτων Firewall.
4. Ιδιωτικά Εικονικά Δίκτυα (VPN).
5. Ασφάλεια επιπέδου δικτύου (IPSec).
6. Ασφάλεια επιπέδου συνόδου (SSL/TLS).
Μαθησιακά αποτελέσματα:
Μετά την ολοκλήρωση του μαθήματος οι φοιτητές θα είναι σε θέση:
• Να κατανοούν βασικές εννοιών ασφάλειας σε όλα τα επίπεδα των υπολογιστικών δικτύων με έμφαση στα TCP/IP δίκτυα.
• Να διακρίνουν τα τρωτά σημεία στα συστήματα αυτά.
• Να προβλέπουν τυχόν αδυναμίες και αστοχίες.
• Να αναζητούν και να εφευρίσκουν/ανακαλύπτουν τρόπους επίλυσης/διαχείρισης για την περιστολή των τρωτών σημείων.
• Να σχεδιάζουν, λαμβάνοντας υπόψη την ανάλυση των δεδομένων, νέες τεχνικές/μεθόδους.
• Να προχωρούν σε πρακτική εφαρμογή συστημάτων ασφάλειας δικτύων, με έμφαση στη χρήση ελεύθερου λογισμικού / λογισμικού ανοικτού κώδικα.";
        }
        private static string TexnologiesDiadiktyouDesc()
        {
            return @"Αντικειμενο μαθήματος:
• Στο μάθημα αυτό περιγράφονται με εισαγωγικό, αλλά πλήρη, τρόπο οι τεχνολογίες και τα πρωτόκολλα πάνω στα οποία στηρίζονται το Διαδίκτυο και ο Παγκόσμιος Ιστός και αναλύονται με περισσότερη λεπτομέρεια η ανάπτυξη εφαρμογών με τη χρήση συγκεκριμένων εργαλείων/γλωσσών, οι οποίες εκτελούνται στην πλευρά του πελάτη ή/και στην πλευρά του εξυπηρετητή.

• Μερικές από τις έννοιες οι οποίες αντιμετωπίζονται είναι: στοίβα πρωτοκόλλων TCP/IP, επίπεδο μεταφοράς και διαδικτύου, HTML5, CSS3, Javascript, jQuery, κλήση AJAX, PHP nodejs, XML και JSON.

Μαθησιακά αποτελέσματα:
Με την επιτυχή ολοκλήρωση του μαθήματος ο φοιτητής / τρια θα είναι σε θέση να:
• Αναγνωρίζει τις βασικές αρχές των πρωτοκόλλων που στηρίζουν το Διαδίκτυο, με έμφαση στο IP και το TCP.
• Έχει κατανοήσει τα βασικά χαρακτηριστικά εφαρμογών του διαδικτύου, τη δομή τους, τους στόχους τους όπως και τη διασύνδεσή τους.
• Έχει διακρίνει και εμβαθύνει στις των βασικές τεχνικές και εργαλεία, η αξιοποίηση των οποίων διασφαλίζει τον προγραμματισμό και τον άρτιο έλεγχο μιας τέτοιας εφαρμογής.
• Αξιοποιείτις προγραμματιστικές τεχνικές σε συνδυασμό με τη θεωρία του μαθήματος για αποδοτικότερο σχεδιασμό, βελτιστοποίση απόδοσης και λειτουργική/αποτελεσματική δημιουργία εφαρμογών στο διαδίκτυο.
• Αναλύει, συγκρίνει, αξολογεί και προτείνει εναλλακτικές σχετικά με υπάρχουσες διαδικτυακές εφαρμογές και πιθανά προβλήματα απόδοσής τους.και με παραδοσιακές μεθόδους/εργαλεία.
• Συνεργάζεται με τους συμφοιτητές του στη δημιουργία και εκτέλεση απλών και σύνθετων εφαρμογών διαδικτύου.";
        }

        private static string AAYDesc()
        {
            return @"Αντικείμενο μαθήματος:
1. Σχεδιασμός του συστήματος διεπαφής με τον χρήστη.
2. Η ανθρώπινη πλευρά στην αλληλεπίδραση.
3. Κλασσικά και σύγχρονα μέσα επικοινωνίας του υπολογιστή.
4. Μοντέλα αλληλεπίδρασης και μοντέλα για τον χρήστη.
5. Στόχοι, μέθοδοι, ανάλυση εργασιών.
6. Χρηστικότητα, φιλικότητα λογισμικού.

Μαθησιακά αποτελέσματα:
Με την ολοκλήρωση του μαθήματος οι φοιτητές/τριες θα είναι σε θέση:
• Να γνωρίζουν, να κατανοούν και να εξηγούν τις αρχές του σχεδιασμού ενός συστήματος διεπαφής.
• Να σχεδιάζουν εύχρηστα συστήματα διεπαφής με τους χρήστες για οποιαδήποτε εφαρμογή.
• Να υλοποιούν συστήματα διεπαφής με τους χρήστες σε κάποια οπτική γλώσσα προγραμματισμού.
• Να αξιολογούν την ευχρηστία των συστημάτων διεπαφής που έχουν αναπτυχθεί από άλλους.
• Να προσδιορίζουν τις δυνατότητες και ικανότητες που μπορεί κανείς να περιμένει από τους ανθρώπους χρήστες για σχεδιασμό βελτιωμένων, μελλοντικών αλληλεπιδραστικών συστημάτων.
• Να κατανοούν και να ταξινομούν εργασίες ιεραρχικά
• Να εφαρμόζουν την ιεραρχική ανάλυση εργασιών.
• Να αντιλαμβάνονται τη σημαντικότητα της ύπαρξης βοήθειας σε ένα αλληλεπιδραστικό σύστημα διεπαφής.
• Να αναγνωρίζουν τις μορφές βοήθειας που μπορεί να παρέχεται σε ένα αλληλεπιδραστικό σύστημα διεπαφής.
• Να σχεδιάζουν και να αναπτύσσουν εύχρηστη βοήθεια σε ένα αλληλεπιδραστικό σύστημα διεπαφής.
• Να αναγνωρίζουν τα διάφορα εγχειρίδια χρήσης που συνοδεύουν ένα αλληλεπιδραστικό λογισμικό.
• Να αναλύουν και να συνθέτουν ευκρινείς οδηγίες χρήσης σε αλλλεπιδραστικά λογισμικά.
• Να συντάσσουν, με βάση τα παραπάνω, τα απαραίτητα εγχειρίδια χρήσης που συνοδεύουν ένα αλληλεπιδραστικό λογισμικό.
• Να γνωρίζουν, κατανοούν και εξηγούν θεωρητικά μοντέλα αλληλεπίδρασης.
• Να κατανοούν και να υλοποιούν τα στάδια του μοντέλου του Norman.
• Να αναλύουν εναλλακτικούς τρόπους σχεδιασμού αλληλεπιδράσεων ενός συστήματος διεπαφής σύμφωνα με το μοντέλο του Νόρμαν.
• Να προτείνουν και να αξιολογούν εναλλακτικούς τρόπους σχεδιασμού αλληλεπιδράσεων ενός συστήματος διεπαφής.
";
        }

        private static string PatternRecognitionDesc()
        {
            return @"Αντικείμενο μαθήματος:
Αναγνώριση Προτύπων (pattern recognition) είναι η επιστημονική περιοχή που έχει στόχο την ταξινόμηση αντικειμένων σε κατηγορίες (κλάσεις) και συμπεριλαμβάνει το επιστημονικό πεδίο της Μηχανικής Μάθησης (machine learning). Σκοπός, επομένως, του παρόντος μαθήματος είναι να παρουσιάσει με ενιαίο τρόπο τις ευρύτερα χρησιμοποιούμενες τεχνικές και μεθοδολογίες για προβλήματα αναγνώρισης προτύπων.
Το περιεχόμενο του μαθήματος χωρίζεται σε οκτώ ενότητες και κάθε ενότητα πραγματοποιείται σε μία ή περισσότερες διαλέξεις.

Ενότητα 1: Εισαγωγή στην Αναγνώριση Προτύπων

Ενότητα 2: Ταξινομητές που βασίζονται στη θεωρία αποφάσεων του Bayes:
Θεωρία Αποφάσεων του Bayes, H Γκαουσσιανή Συνάρτηση Πυκνότητας Πιθανότητας, Ταξινομητές Ελάχιστης Απόστασης, Ταξινομητής Ευκλείδειας Απόστασης, Ταξινομητής Mahalanobis Απόστασης, Εκτίμηση Μέγιστης Πιθανοφάνειας των παραμέτρων της Γκαουσσιανής Συνάρτησης Πυκνότητας Πιθανότητας
Μοντέλα Μίξης, Ο Αλγόριθμος Expectation-Maximization, Παράθυρα Parzen
Εκτίμηση Πυκνότητας Πιθανότητας με βάση τους k-πλησιέστερους γείτονες, Ο Ταξινομητής Naive Bayes, Ο Ταξινομητής Πλησιέστερων Γειτόνων

Ενότητα 3: Ταξινομητές που βασίζονται στη Βελτιστοποίηση Συνάρτησης Κόστους:
Ο αλγόριθμος Perceptron, H online έκδοση του αλγόριθμου Perceptron, Ταξινομητής Ελάχιστου Τετραγωνικού Σφάλματος, Περίπτωση πολλών κλάσεων, Μηχανές Διανυσματικής Στήριξης (ΜΔΣ/SVM): Η γραμμική περίπτωση, Επεκτάσεις για την περίπτωση πολλών κλάσεων, SVM: Η μη γραμμική περίπτωση, Ο Αλγόριθμος Perceptron με χρήση Πυρήνων, O Αλγόριθμος AdaBoost, Πολυστρωματικά Δίκτυα Perceptrons

Ενότητα 4: Μετασχηματισμοί Δεδομένων: Γένεση Χαρακτηριστικών και Μείωση Αριθμού Διαστάσεων:
Ανάλυση σε Κύριες Συνιστώσες (PCA), Ανάλυση σε Ιδιάζουσες Τιμές (SVD), Ανάλυση Γραμμικής Διάκρισης κατά Fisher, Ανάλυση σε Κύριες Συνιστώσες με Χρήση Πυρήνων, Μέθοδος Χαρτογράφησης Ιδιοτιμών του Laplacian Μητρώου

Ενότητα 5: Επιλογή Χαρακτηριστικών:
Αποκοπή Ακραίων Τιμών, Κανονικοποίηση Δεδομένων, Έλεγχος Υποθέσεων: t-Test,
Καμπύλη Receiver Operating Characteristic, Λόγος Διάκρισης κατά Fisher, Μέτρα Διαχωριστικής Ικανότητας μεταξύ κλάσεων, Απόκλιση, Απόσταση Bhattacharya και Φράγμα Chernoff, Μέτρα βασισμένα σε Μητρώα Διασποράς, Επιλογή Υποσυνόλου Χαρακτηριστικών, Βαθμωτή Επιλογή Χαρακτηριστικών, Διανυσματική Επιλογή Χαρακτηριστικών

Ενότητα 6: Σύγκριση με Πρότυπα Αναφοράς: Απόσταση Edit, Σύγκριση Ακολουθιών Πραγματικών Αριθμών, Δυναμική Χρονική Στρέβλωση στα πλαίσια της Αναγνώρισης Φωνής

Ενότητα 7: Κρυφά Μοντέλα Markov: Μοντελοποίηση, Αναγνώριση και Εκπαίδευση

Ενότητα 8: Ομαδοποίηση: Βασικές Έννοιες και Ορισμοί, Αλγόριθμοι Ομαδοποίησης, Ακολουθιακοί Αλγόριθμοι, Αλγόριθμος BSAS, Βελτίωση Ομαδοποίησης, Αλγόριθμοι Ομαδοποίησης Βασιζόμενοι στη Βελτιστοποίηση Συνάρτησης Κόστους, Αλγόριθμοι Σαφούς Ομαδοποίησης, Αλγόριθμοι Μη-Σαφούς Ομαδοποίησης, Άλλοι Αλγόριθμοι Ομαδοποίησης, Αλγόριθμοι Ιεραρχικής Ομαδοποίησης, Γενικό Σχήμα Συγχώνευσης, Εξειδικευμένοι Αλγόριθμοι Συγχώνευσης, Επιλογή της καλύτερης Ομαδοποίησης

Μαθησιακά αποτελέσματα:
Αναγνώριση Προτύπων (pattern recognition) είναι η επιστημονική περιοχή που έχει στόχο την ταξινόμηση αντικειμένων σε κατηγορίες (κλάσεις) και συμπεριλαμβάνει το επιστημονικό πεδίο της Μηχανικής Μάθησης (machine learning). Σκοπός, επομένως, του παρόντος μαθήματος είναι να παρουσιάσει με ενιαίο τρόπο τις ευρύτερα χρησιμοποιούμενες τεχνικές και μεθοδολογίες για προβλήματα αναγνώρισης προτύπων.

Με την επιτυχή́ ολοκλήρωση του μαθήματος ο φοιτητής θα είναι σε θέση:
• Να διαθέτει προχωρημένες γνώσεις σε αλγορίθμους, τεχνικές και μεθοδολογίες αναγνώρισης προτύπων, όπως στην Μπεϋζιανή θεωρία ταξινόμησης, σε γραμμικούς και μη γραμμικούς ταξινομητές, σε Νευρωνικά δίκτυα, σε Κρυφά Μοντέλα Markov, σε αλγορίθμους ομαδοποίησης και τεχνικές επιλογής χαρακτηριστικών και μείωσης αριθμού διαστάσεων δεδομένων.
• Να αντιλαμβάνεται πώς συνδυάζονται γνώσεις πιθανοτήτων, στατιστικής, γραμμικής άλγεβρας και βελτιστοποίησης για τη δημιουργία αλγορίθμων αναγνώρισης προτύπων.
• Να αναλύει προβλήματα πραγματικών δεδομένων (ανοικτής πρόσβασης), στα οποία απαιτείται η σχεδίαση/ανάπτυξη/υλοποίηση συστημάτων ταξινόμησης αντικειμένων.
• Να εκτιμά το εφικτό των προβλημάτων αυτών, να επιλέγει τους κατάλληλους αλγορίθμους/τεχνικές και να προβαίνει στην αποτίμηση και συγκριτική μελέτη των επιδόσεων εναλλακτικών λύσεων.
• Να διαχειρίζεται τον φόρτο και την πολυπλοκότητα τέτοιων προβλημάτων πραγματικών δεδομένων σε περιβάλλον ομαδικής εργασίας.
• Να κατέχει προχωρημένες προγραμματιστικές δεξιότητες σε περιβάλλον ανάπτυξης λογισμικού Python/MATLAB/GNU Octave για την υλοποίηση αλγορίθμων, τεχνικών και μεθόδων ταξινόμησης αντικειμένων.
• Να εκτιμά και να επαναχρησιμοποιεί υφιστάμενες υλοποιήσεις συναρτήσεων ανοιχτού κώδικα, σχετικών με το πεδίο της αναγνώρισης προτύπων, όπως των συναρτήσεων της βιβλιοθήκης scikit-learn. 
• Να διακρίνει έννοιες συναφείς της αναγνώρισης προτύπων, στα συγγενή επιστημονικά πεδία της Μηχανικής Μάθησης, της Ανάλυσης Δεδομένων και της Τεχνητής Νοημοσύνης.
";
        }

        private static string AIDesc()
        {
            return @"Αντικείμενο μαθήματος:
                     1. Εισαγωγικές γνώσεις βασικών εννοιών στην Τεχνητή Νοημοσύνη και τα Έμπειρα Συστήματα.
                     2. Επίλυση προβλημάτων σε επιλεγμένες περιοχές, όπως για παράδειγμα οι γενετικοί αλγόριθμοι με μεθόδους τεχνητής νοημοσύνης.
                     3. Βασικές γνώσεις στη Μηχανική Μάθηση και στα Νευρωνικά Δίκτυα.
                     
                     Μαθησιακά αποτελέσματα:
                     Με την ολοκλήρωση του μαθήματος οι φοιτητές/τριες αναμένεται ότι :
                     • θα γνωρίζουν τις βασικές έννοιες της Τεχνητής Νοημοσύνης (ΤΝ) και των Έμπειρων Συστημάτων (ΕΣ),
                     • θα μπορούν να αναγνωρίζουν, να περιγράφουν και να αναπαριστούν προβλήματα λογικής,
                     • θα αναπτύσσουν αλγόριθμους αναζήτησης λύσης,
                     • θα εστιάζουν, θαεμβαθύνουν, θα διακρίνουν και θα καταδεικνύουν τρόπους επίλυσης προβλημάτων με επιλεγμένες μεθόδους τεχνητής νοημοσύνης (πχ. γενετικοί αλγόριθμοι, ασαφή λογική),
                     • θα ελέγχουν και θα διαχειρίζονται με συστηματικό τρόπο την Ασάφεια και την Αβεβαιότητα σε συστήματα κανόνων,
                     • θα γνωρίζουν και θα προσδιορίζουν τα σημασιολογικά δίκτυα, καθώς επίσης και θα εφαρμόζουν συμπερασματολογία σε αυτά,
                     • θα κατέχουν βασικές γνώσεις στη Μηχανική Μάθηση και στα Νευρωνικά Δίκτυα.
";
        }

        private static string DataAnalyticsDesc()
        {
            return @"Αντικείμενο μαθήματος:
Το μάθημα προσφέρει γνώσεις σχετικά με τη σχεδίαση και υλοποίηση μεθόδων και τεχνικών Αναλυτικής Δεδομένων (ΑΔ), η οποία αποτελεί μέρος μιας από τις πιο σύγχρονες τάσεις στην περιοχή της Πληροφορικής, αυτής της Επιστήμης Δεδομένων (Data Science). Αναλυτικά περιλαμβάνει:
1. Εισαγωγή στην Αναλυτική Δεδομένων - Προπαρασκευή δεδομένων (Data Preprocessing) για τους σκοπούς της αναλυτικής.
2. Αλγόριθμοι και τεχνικές Αναλυτικής Δεδομένων: κατηγοριοποίηση/ταξινόμηση (classification), συσταδοποίηση (clustering), εξόρυξη συχνών προτύπων (frequent pattern mining).
3. Ειδικά – προηγμένα θέματα (αναλυτική δεδομένων ήχου/εικόνας, γεωγραφικής πληροφορίας).
4. Εργαστηριακές ασκήσεις σε δημοφιλείς γλώσσες προγραμματισμού (R, Python).

Μαθησιακά αποτελέσματα:
Μετά την επιτυχή ολοκλήρωση του μαθήματος, οι φοιτητές:
• Θα έχουν εμβαθύνει στις έννοιες και τα χαρακτηριστικά της Αναλυτικής Δεδομένων.
• Θα αναγνωρίζουν και θα εφαρμόζουν τα διάφορα στάδια προπαρασκευής δεδομένων.
• Θα επιλέγουν μεταξύ διαφορετικών αλγορίθμων και τεχνικών για την εκάστοτε ανάλυση αναλόγως της φύσης των δεομένων.
• Θα είναι σε θέση να χρησιμοποιούν τη γνώση και την κατανόηση που απέκτησαν ως μελλοντικοί Επιστήμονες Δεδομένων (Data Scientists).
• Θα είναι πλήρως ενημερωμένοι για περαιτέρω εξειδίκευση στο χώρο της Επιστήμης Δεδομένων.
";
        }

        private static string DbDesc()
        {
            return @"Αντικείμενο μαθήματος:
Το μάθημα προσφέρει γνώσεις σχετικά με τη σχεδίαση και χρήση των Βάσεων Δεδομένων (ΒΔ), οι οποίες αποτελούν κομβικά συστατικά ενός οποιουδήποτε Πληροφοριακού Συστήματος (ΠΣ). Πιο συγκεκριμένα περιλαμβάνει:
1. Θεωρητικό υπόβαθρο (Σχεσιακό Μοντέλο, Σχεσιακή Άλγεβρα),
2. Εκμάθηση της γλώσσας SQL (η οποία αποτελεί το de-facto standard των συστημάτων διαχείρισης ΒΔ),
3. Τεχνικές σχεδίασης Σχεσιακών ΒΔ, συμπεριλαμβανομένης της θεωρίας κανονικοποίησης,
4. Εργαστηριακές ασκήσεις σε ένα δημοφιλές σύστημα διαχείρισης ΒΔ (PostgreSQL).

Μαθησιακά αποτελέσματα:
Μετά την επιτυχή ολοκλήρωση του μαθήματος, οι φοιτητές:
• Θα κατανοούν θέματα σχετικά με το απαιτούμενο θεωρητικό υπόβαθρο των ΒΔ, όπως το Σχεσιακό Μοντέλο και η γλώσσα SQL, ως κομβικών συστατικών ενός ΠΣ.
• Θα αξιοποιούν τη θεωρητική γνώση για να σχεδιάζουν και να αναλύουν τα δεδομένα ενός ΠΣ.
• Θα χρησιμοποιούν τη γλώσσα SQL έχοντας διδαχθεί τη θεωρητικό υπόβαθρο της Σχεσιακής Άλγεβρας.
• Θα ενσωματώνουν τις τεχνικές σχεδίασης Σχεσιακών Βάσεων Δεδομένων για την αποτελεσματική κατασκευή και αξιοποίησή τους.
• Θα διακρίνουν τις λοιπές παραμέτρους για να σχεδιάζουν και να αναπτύσσουν Βάσεις Δεδομένων με διευρυμένες δυνατότητες.
• Θα έχουν σφαιρική ενημέρωση, ερευνητική και εμπειρική, για περαιτέρω εξειδίκευση στο χώρο των ΠΣ και των ΒΔ (επαγγελματικά ή/και ακαδημαϊκά.
";
        }

        private static string DbmsDesc()
        {
            return @"Αντικείμενο μαθήματος:
Το μάθημα προσφέρει γνώσεις σχετικά με την εσωτερική λειτουργία των Συστημάτων Διαχείρισης Βάσεων Δεδομένων (ΣΔΒΔ). Πιο συγκεκριμένα καλύπτονται τα εξής θέματα:
1. Φυσική οργάνωση ΒΔ (αρχεία και ευρετήρια).
2. Επεξεργασία και βελτιστοποίηση επερωτήσεων.
3. Διαχείριση δοσοληψιών (θέματα συνδρομικότητας και ανάνηψης).
4. Ειδικές αρχιτεκτονικές ΒΔ (κατανεμημένες, παράλληλες ΒΔ, αρχιτεκτονικές Big Data).
5. Εργαστηριακές ασκήσεις σε δύο δημοφιλή ΣΔΒΔ (PostgreSQL, MongoDB).

Μαθησιακά αποτελέσματα:
Μετά την επιτυχή ολοκλήρωση του μαθήματος, οι φοιτητές:
• Θα αναγνωρίζουν θα κατανοούν τη φυσική οργάνωση και ενδεδειγμένη δομή των Συστημάτων Διαχείρισης Βάσεων Δεδομένων (ΣΔΒΔ), ως κομβικών συστατικών ενός Πληροφοριακού Συστήματος (ΠΣ).
• Θα είναι σε θέση να χρησιμοποιούν τη γνώση και την κατανόηση αυτή για να σχεδιάζουν και να αναπτύσσουν δράσεις προγραμματισμού των ΣΔΒΔ.
• Θα βελτιστοποιούν τις επερωτήσεις εφαρμόζοντας τεχνικές και μεθόδους αποτελεσματικής επεξεργασίας τους.
• Θα διαχειρίζονται αποτελεσματικά θέματα που σχετίζονται με τις δοσοληψίες.
• Θα αναγνωρίζουν τα χαρακτηριστικά των ειδικών αρχιτεκτονικών ΒΔ ανάλογα με τον τύπο τους.
• Θα οργανώνουν και θα δημιουργούν την υποδομή για την ορθή λειτουργία των ΠΣ.
• Θα υιοθετούν επικοινωνιακή και συνεργατική διάθεση, ως στοιχεία απαραίτητα για περαιτέρω επιστημονική ή επαγγελματική εξειδίκευση στο χώρο των ΒΔ.
";
        }

        private static string GlobalWebProgrammingDesc()
        {
            return @"Αντικείμενο μαθήματος
Το μάθημα ασχολείται με τη θεωρητική μελέτη και την πρακτική εξάσκηση σε θέματα προγραμματισμού στο διαδίκτυο και στον παγκόσμιο ιστό, όπως προγραμματισμό sockets, την υλοποίηση εφαρμογών πελάτη-εξυπηρετητή και τις αρχιτεκτονικές 3-tier. Αναλυτικότερα περιλαμβάνει τα ακόλουθα:
1. Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)
2. Δικτυακός Προγραμματισμός¬ (socket programming, tcp-udp)
3. Πρωτόκολλο HTTP (περιγραφή, σύνδεση με το μοντέλο πελάτη εξυπηρετητή)
4. Προγραμματισμός HTTP: Υλοποίηση Web server
5. Παραλλαγές Αρχιτεκτονικής Πελάτη-Εξυπηρετητή (3-trier αρχιτεκτονικές)
6. Προγραμματισμός από την μεριά του εξυπηρετητή (Java servlets)
7. Μόνιμη αποθήκευση δεδομένων σε διαδικτυακές εφαρμογές

Μαθησιακά αποτελέσματα:
Με την ολοκλήρωση του μαθήματος οι φοιτητές/τριες αναμένεται ότι :
• θα μπορούν να παραθέσουν τις βασικές αρχιτεκτονικές για την ανάπτυξη εφαρμογών στο διαδίκτυο και στον παγκόσμιο ιστό, όπως είναι οι αρχιτεκτονικές client-server και 3-tier,
• θα γνωρίζουν τις βασικές τεχνολογίες για το διαδίκτυο και τον παγκόσμιο ιστό όπως είναι τα πρωτόκολλα IP, TCP, UDP και HTTP, η τεχνολογία sockets, οι διακομιστές ιστού (web servers) και οι διακομιστές εφαρμογών (application servers),
• θα μπορούν να αναπτύσσουν εφαρμογές για τον παγκόσμιο ιστό με χρήση κατάλληλου προγραμματιστικού περιβάλλοντος,
• θα μπορούν να υλοποιούν προγραμματισμό sockets (TCP sockets και UDP sockets),
• θα παράγουν εφαρμογές πελάτη-εξυπηρετητή,
• θα μπορούν να ενσωματώνουν στις εφαρμογές τους την αρχιτεκτονική 3-tier
";
        }

        private static string InternetInformationSystemsDesc()
        {
            return @"Αντικείμενο μαθήματος:
1. Δικτυοκεντρικός Υπολογισμός (Network Computing)
• Τεχνολογίες διαδικτύου και παγκόσμιου ιστού
• Περιήγηση και ανάκτηση πληροφοριών (Discovery), λογισμικό φυλλομετρητών (Browsers) και διακομιστών (Servers)
• Μέσα επικοινωνίας (Communicatrion)
• Ηλεκτρονική συνεργασία (Collaborartion), εργαλεία τηλεσυνεργασίας
• Υποδομές Πληροφορικής

2. Ηλεκτρονικό Εμπόριο και Ηλεκτρονικό Επιχειρείν
• Επιχειρηματικά μοντέλα στο ηλεκτρονικό επιχειρείν
• Συστατικά του ηλεκτρονικού εμπορίου και του ηλεκτρονικού επιχειρείν
• Υπηρεσίες προς τον καταναλωτή
• Συμπεριφορά Καταναλωτών και έρευνα αγοράς
• Ηλεκτρονικό εμπόριο σε επιχειρήσεις και οργανισμούς
• Υποστηρικτικές υπηρεσίες στο ηλεκτρονικό εμπόριο
• Θέματα υλοποίησης του ηλεκτρονικού επιχειρείν

3. Νέες Τεχνολογίες και Εφαρμογές
• Διείσδυση των νέων τεχνολογιών στα δικτυοκεντρικά πληροφοριακά συστήματα
• Κινητή υπολογιστική (Mobile Computing, Wireless Computing)
     ◦ Τεχνολογίες
     ◦ Υποδομές
     ◦ Εφαρμογές για την υποστήριξη των πελατών
• Υπολογιστική νέφους (Cloud Computing)
     ◦ Χαρακτηριστικά και μοντέλα της υπολογιστικής νέφους
     ◦ Τύποι υπολογιστικού νέφους
     ◦ Διαμοιρασμός πόρων
     ◦ Κλιμάκωση-Επέκταση
     ◦ Πλεονεκτήματα και μειονεκτήματα του υπολογισμού στο νέφος
• Εφαρμογή της κινητής υπολογιστικής και της υπολογιστικής νέφους
• Η πανταχού παρούσα υπολογιστική - Διάχυτος υπολογισμός (Pervasive-Ubiquitous Computing)
     ◦ Αξιοποίηση ετερογενών συσκευών
     ◦ Eμπόριο βασισμένο στην τοποθεσία
     ◦ Κινητό εμπόριο
     ◦ Έξυπνα σπίτια και έξυπνα σχολεία

4. Κατανεμημένα Συστήματα Βασισμένα σε Κείμενο
• Τι είναι τα κατανεµηµένα συστήµατα
• Ο παγκόσμιος ιστός
     ◦ Οργάνωση
     ◦ Χώροι ονομάτων (URI, URN και URL)
• Τύποι εγγράφων στον παγκόσμιο ιστό
• Αρχιτεκτονική και υποδομή του παγκόσμιου ιστού
• Πρωτόκολλο HTTP
     ◦ Συνδέσεις
     ◦ Μηνύματα
• Εξυπηρετητές ιστού
     ◦ Εξυπηρετητής Apache
     ◦ Αναπαραγωγή και Συσταδοποίηση των εξυπηρετητών ιστού
• Tο μοντέλο πελάτη-εξυπηρετητή
• Ασφάλεια επικοινωνίας πελάτη-εξυπηρετητή
• Εξυπηρετητές εφαρμογών ιστού

5. Βασικές και Προηγμένες Τεχνικές Προγραμματισμού και Λειτουργίας στον Παγκόσμιο Ιστό
• Νέες τεχνολογίες στην πλευρά του πελάτη
     ◦ Γλώσσες σήμανσης HTML και HTML5
     ◦ Κανόνες μορφοποίησης (CSS)
     ◦ JavaScript και βιβλιοθήκες JQuery και jQuery Mobile
• Η γλώσσα eXtensible Markup Language (XML)
     ◦ Document Type Definition (DTD)
     ◦ Σχήμα XML (XML Schema)
     ◦ Extensible Stylesheet Language (XSL)
• To πρότυπο ανταλλαγής δεδομένων JSON
• Ασύγχρονη επικοινωνία (AJAX)
• Άλλες τεχνολογίες
     ◦ Python
     ◦ JavaScript βιβλιοθήκες Underscore.js, MooTools και Node.js
     ◦ Java Applets

6. Διαδικτυακός Προγραμματισμός με Java: Servlets και JSP
• H γλώσσα προγραμματισμού Java
• Java Servlets
     ◦ Παραδείγματα
     ◦ Μειονεκτήματα
• Διαχείριση συνεδριών
• Αυθεντικοποίηση μέσω σύνδεσης σε βάση δεδομένων
• Java Server Pages (JSP) και βιβλιοθήκες δομημένης ανάπτυξης εφαρμογών ιστού
• Αρχιτεκτονική Model-View-Controller (MVC)

Μαθησιακά αποτελέσματα:
Με την ολοκλήρωση του μαθήματος οι φοιτητές θα είναι σε θέση:
• Να γνωρίζουν τις νέες τεχνολογικές τάσεις που αφορούν τα πληροφοριακά συστήματα στο διαδίκτυο.
• Να περιγράφουν τον ρόλο των δικτυοκεντρικών πληροφοριακών συστημάτων στο σύγχρονο επιχειρηματικό περιβάλλον και στη δικτυακή οικονομία (Networked Economy).
• Να γνωρίζουν τις εφαρμογές που έχουν τα δικτυοκεντρικά πληροφοριακά συστήματα στο ηλεκτρονικό επιχειρείν (e-business) και στο ηλεκτρονικό εμπόριο (e-commerce).
• Να γνωρίζουν τις τεχνολογίες που χρησιμοποιούνται στον δικτυοκεντρικό υπολογισμό (Network Computing).
• Να προσδιορίζουν τις αλλαγές, τις προοπτικές και τους κινδύνους που έχει επιφέρει η ανάπτυξη της κινητής υπολογιστικής, της υπολογιστικής νέφους και του διάχυτου υπολογισμού στα δικτυοκεντρικά πληροφοριακά συστήματα και κατ’ επέκταση στις επιχειρηματικές διαδικασίες.
• Να γνωρίζουν τα χαρακτηριστικά των υποδομών που απαιτούνται για τη λειτουργία και την προώθηση των δικτυοκεντρικών πληροφοριακών συστημάτων.
• Να χρησιμοποιούν JavaScript βιβλιοθήκες (π.χ. jQuery, Underscore.js).
• Να υλοποιούν μικροεφαρμογές (Java Applets/Servlets) με χρήση της γλώσσας προγραμματισμού Java.
• Να δημιουργούν ιστοσελίδες με δυναμικό περιεχόμενο με την τεχνολογία Java Server Pages (JSP).
• Να αξιοποιούν μοντέρνες τεχνικές διαδικτυακού προγραμματισμού, όπως πλαισίων εφαρμογών ιστού (Struts, Spring).
• Να γνωρίζουν τη χρησιμότητα των υπηρεσιών ιστού, του πρωτοκόλλου SOAP, της περιγραφικής γλώσσας WSDL και του προτύπου UDDI.
• Να δημιουργούν και να συνθέτουν υπηρεσίες ιστού (web services).
• Να αναγνωρίζουν τις βασικές έννοιες, τα πλεονεκτήματα και τον τρόπο υλοποίησης της υπηρεσιοστραφούς αρχιτεκτονικής (SOA).
• Να καταγράφουν τις λειτουργικές προδιαγραφές που απαιτεί η ανάπτυξη ενός δικτυοκεντρικού πληροφοριακού συστήματος και να προτείνουν τη μεθοδολογία ανάπτυξης που θα υιοθετηθεί.
• Να αξιοποιούν τα εργαλεία και τις τεχνικές που παρουσιάστηκαν στο μάθημα ώστε να αναπτύσσουν ολοκληρωμένες διαδικτυακές εφαρμογές και βάσεις δεδομένων.
";
        }

        private static string NetworksDesc()
        {
            return @"Αντικείμενο μαθήματος:
Στο μάθημα αυτό περιγράφονται με εισαγωγικό, αλλά πλήρη, τρόπο οι βασικές έννοιες και αρχές δικτύωσης και τα πρωτόκολλα, πάνω στα οποία στηρίζονται τα διάφορα είδη δικτύων, με έμφαση στα πρωτόκολλα του Διαδικτύου.

Συγκεκριμένα αναλύονται:

Βασικές έννοιες και αρχές δικτύωσης
• είδη δικτύων (δίκτυα μεταγωγής, διαδίκτυα), σχεδίαση (αρχιτεκτονική αναφοράς OSI και αρχιτεκτονική TCP/IP)

Σύνδεσμοι και μετάδοση πληροφορίας
• διάδοση και μετάδοση σήματος μέσα από ένα σύνδεσμο, ταχύτητα μετάδοσης, πολυπλεξία
• αλγόριθμοι και τεχνολογίες προσπέλασης σε κοινό μέσο
• αξιόπιστη μετάδοση

Δίκτυα Μεταγωγής
• προώθηση και τεχνολογίες μεταγωγής

Διαδίκτυα
• γενικές αρχές διαδικτύωσης, δρομολόγηση, είδη αλγόριθμων δρομολόγησης
• δίκτυα IP: διευθυνσιοδότηση, ARP, προώθηση, δρομολόγηση (OSPF,BGP), κατακερματισμός, πρωτόκολλο ICMP

Επικοινωνία από άκρο σε άκρο
• επικοινωνία διεργασιών (βασικοί μηχανισμοί)
• πρωτόκολλα UDP και TCP

Ασύρματες Επικοινωνίες
• Αρχές λειτουργίας κινητών επικοινωνιών
• Πρωτόκολλα πρόσβασης στο μέσο σε τοπικά ασύρματα δίκτυα

Επίδοση Εφαρμογών
• Κωδικοποίηση και ποιότητα υπηρεσιών
• πρωτόκολλα για μεταφορά βίντεο

Μαθησιακά αποτελέσματα:
Με την επιτυχή ολοκλήρωση του μαθήματος ο φοιτητής / τρια θα:
• Κατανοεί θεμελιώδεις έννοιες (π.χ. Αρχιτεκτονικές δικτύων: Μεταγωγής, Μεταγωγή κυκλώματος και μεταγωγή πακέτου, Τύποι δικτύων (τοπικά δίκτυα, μητροπολιτικά δίκτυα, δίκτυα ευρείας περιοχής, ενσύρματα και ασύρματα δίκτυα), Τοπολογίες δικτύων (πλέγμα, αρτηρία, δακτύλιος, αστέρας).
• Θα αναγνωρίζει τα Χαρακτηριστικά απόδοσης (π.χ) καθυστέρηση, εύρος ζώνης, ρυθμαπόδοση, ρυθμός απώλειας πακέτων.
• Θα προσδιορίζει και θα ταξινομεί τα στάδια Σχεδίασης Δικτύων: Διαστρωμάτωση, Πρωτόκολλα και Πρότυπα, Συνδεσμοστραφείς και ασυνδεσμικές υπηρεσίες.
• Θα διακρίνει το μοντέλο αναφοράς OSI, τη στοίβα πρωτοκόλλων TCP/IP και τη χρήση τους στους Οργανισμούς Τυποποίησης
• Θα είναι σε θέση να προσεγγίζει και να ορίζει το Φυσικό επίπεδο: αναλογική και ψηφιακή αναπαράσταση, Κωδικοποίηση και διαμόρφωση, Μέσα μετάδοσης, Ανίχνευση και Διόρθωση σφαλμάτων, Πολυπλεξία.
• Θα διακρίνει το Επίπεδο Συνδέσμου Μετάδοσης Δεδομένων: πλαισίωση, έλεγχος σφαλμάτων (πρωτόκολλα ARQ), έλεγχος ροής, πρότυπα και πρωτόκολλα δευτέρου επιπέδου (DSL, ISDN).
• Θα έχει εμπεδώσει τα επίπεδα του Ελέγχου πολλαπλής πρόσβασης: διευθυνσιοδότηση, πολλαπλή πρόσβαση με και χωρίς ανταγωνισμό, τεχνολογίες τοπικών δικτύων (Ethernet, Token Ring, Gigabit Ethernet), Επαναλήπτες, γέφυρες, κατανεμητές και μεταγωγείς.
• Θα διαχειρίζεται τα Ασύρματα τοπικά δίκτυα (wifi) και δίκτυα κινητών επικοινωνιών (3η και 4η γενιά).
• Θα υλοποιεί τις εφαρμογές των Δικτύων Μεταγωγής (μεταγωγή πακέτου και εικονικά κυκλώματα, μεταγωγείς) και θα σχεδιάζει/αναπτύσσει τη Διαδικτύωση (δρομολόγηση, αλγόριθμοι δρομολόγησης διανυσμάτων απόστασης και κατάστασης συνδέσμων), τον Έλεγχο συμφόρησης, Το πρωτόκολλο IP (διευθυνσιοδότηση, πρωτόκολλα δρομολόγησης OSPF και BGP, κατακερματισμός).
• Θα κατανοεί τις αρχές πίσω από τις υπηρεσίες του επιπέδου μεταφοράς δεδομένων (Πολύπλεξη/αποπολύπλεξη(multiplexing/demultiplexing, αξιόπιστη μεταφορά δεδομένων, έλεγχος ροής (flow control), έλεγχος συμφόρησης (congestion control) και θα τηρεί τα πρωτόκολλα επιπέδου μεταφοράς του Διαδικτύου, UDP: ασυνδεσμική μεταφορά, TCP: συνδεσμική μεταφορά.
• Θα ελέγχει το επίπεδο συμφόρησης του TCP.
• Θα αναπτύσσει και θα εφαρμόζει εννοιολογικά, σχεδιαστικά θέματα πρωτοκόλλων δικτυακών εφαρμογών.
• Θα αξιοποιεί μοντέλα υπηρεσιών επιπέδου μεταφοράς, μοντέλο πελάτη εξυπηρετητή (client-server), μοντέλο ομότιμων (peer-to-peer), δημοφιλή πρωτόκολλα επιπέδου εφαρμογής: HTTP, SMTP / POP3 / IMAP, DNS.
• Θα αναπτύσσει νέα πρωτόκολλα και εφαρμογές αξιολογώντας την κάθε περίπτωση.
";
        }

        private static string MultimediaSystemsDesc()
        {
            return @"Αντιεκίμενο μαθήματος:
Το μάθημα Συστήματα Πολυμέσων ασχολείται με την επιστημονική περιοχή στην οποία συναντώνται και γονιμοποιούνται πληθώρα επιστημονικών πεδίων, όπως η επεξεργασία σήματος, η θεωρία πληροφορίας και οι επικοινωνίες, με στόχο τη Δημιουργία, την Αποθήκευση/Συμπίεση και τη Διανομή του Πολυμεσικού Περιεχομένου. Σκοπός, επομένως, του παρόντος μαθήματος είναι να παρουσιάσει με ενιαίο τρόπο τις θεμελιώδεις έννοιες της πολυμεσικής επεξεργασίας, τα προβλήματα που καλείται να επιλύσει η σχεδίαση πολυμεσικών συστημάτων και τις σημαντικότερες τεχνικές ψηφιοποίησης, συμπίεσης και διανομής πολυμεσικού περιεχομένου.

Το περιεχόμενο του μαθήματος χωρίζεται σε τέσσερα μέρη: Δημιουργίας Πολυμεσικού Περιεχομένου, Συμπίεσης Πολυμέσων, Διανομής Πολυμέσων και Σύγχρονων Τάσεων. Κάθε μέρος αποτελείται από μία ή περισσότερες ενότητες και κάθε ενότητα δύναται να διδαχθεί σε περισσότερες από μία διαλέξεις.

Μέρος Ι: Δημιουργία Πολυμεσικού Περιεχομένου
Ενότητα 1: Εισαγωγή στα Πολυμέσα – Παρελθόν, Παρόν και Μέλλον
Ενότητα 2: Λήψη Ψηφιακών Δεδομένων
Ενότητα 3: Αναπαράσταση και Πρότυπα Διαμόρφωσης Μέσων
Ενότητα 4: Θεωρία Χρώματος

Μέρος ΙΙ: Συμπίεση Πολυμέσων
Ενότητα 5: Επισκόπηση Συμπίεσης
Ενότητα 6: Συμπίεση Εικόνας
Ενότητα 7: Συμπίεση Video
Ενότητα 8: Συμπίεση Ήχου
Ενότητα 9: Συμπίεση Γραφικών

Μέρος ΙΙΙ: Διανομή Πολυμέσων
Ενότητα 10: Ενσύρματη και Ασύρματη Δικτύωση Πολυμέσων
Ενότητα 11: Ψηφιακή Διαχείριση Δικαιωμάτων

Μέρος ΙV: Σύγχρονες Τάσεις
Ενότητα 12: MPEG-4, Πολυμεσικές Βάσεις Δεδομένων και Αναζήτηση Πληροφορίας, Πολυμεσικά Πλαίσια

Μαθησιακά αποτελέσματα:
Με την επιτυχή́ ολοκλήρωση του μαθήματος ο φοιτητής/τρια θα είναι σε θέση:
• Να διαθέτει προχωρημένες γνώσεις σε αλγορίθμους, τεχνικές και μεθοδολογίες δημιουργίας, συμπίεσης και δικτύωσης ψηφιακού περιεχομένου, όπως συμπίεσης χωρίς/με απώλειες εικόνας/ήχου/βίντεο/γραφικών (JPEG, JPEG-2000, MPEG-4), ασύρματης δικτύωσης (π.χ., Bluetooth) και ψηφιακής διαχείρισης δικαιωμάτων (π.χ., λύσεις DRM στη μουσική βιομηχανία).
• Να αντιλαμβάνεται πώς συνδυάζονται γνώσεις επεξεργασίας σήματος, θεωρίας χρώματος, ψυχοακουστικής, θεωρίας της πληροφορίας, συμπίεσης και δικτύωσης για τη δημιουργία και λειτουργία συστημάτων πολυμέσων.
• Να κατέχει τη δεξιότητα να αναλύει προβλήματα πραγματικών δεδομένων (ανοικτής πρόσβασης), στα οποία απαιτείται η σχεδίαση/ανάπτυξη/υλοποίηση συστημάτων επεξεργασίας/ανάλυσης πολυμεσικού περιεχομένου, να εκτιμά το εφικτό των προβλημάτων αυτών, να επιλέγει τους κατάλληλους αλγορίθμους/τεχνικές και να προβαίνει στην αποτίμηση και συγκριτική μελέτη των επιδόσεων εναλλακτικών λύσεων.
• Να διαχειρίζεται τον φόρτο και την πολυπλοκότητα τέτοιων προβλημάτων πραγματικών δεδομένων σε περιβάλλον ομαδικής εργασίας.
• Να κατέχει προχωρημένες προγραμματιστικές δεξιότητες σε περιβάλλον ανάπτυξης λογισμικού Python/MATLAB/GNU Octave για την υλοποίηση αλγορίθμων, τεχνικών και μεθόδων επεξεργασίας πολυμεσικού περιεχομένου.
• Να αναγνωρίζει και να επαναχρησιμοποιεί υφιστάμενες υλοποιήσεις συναρτήσεων ανοιχτού κώδικα, σχετικών με το πεδίο των Συστημάτων Πολυμέσων, όπως των συναρτήσεων της βιβλιοθήκης ffmpeg.
• Να διακρίνει συναφείς της πολυμεσικής επεξεργασίας έννοιες, στα συγγενή επιστημονικά πεδία της Επεξεργασίας Σήματος, της Θεωρίας της Πληροφορίας , της Συμπίεσης Δεδομένων και της Δικτύωσης Δεδομένων.
";
        }

        private static string ImageAnalysisDesc()
        {
            return @"Αντικείμενο μαθήματος:
Το μάθημα πραγματεύεται την ανάπτυξη αλγορίθμων που επιτρέπουν σε μηχανές να κατανοούν τον οπτικό κόσμο. Εντάσσεται δε, στο ευρύτερο επιστημονικό πεδίο της Τεχνητής Νοημοσύνης. Σκοπός, επομένως, του παρόντος μαθήματος είναι να παρουσιάσει με ενιαίο τρόπο τις ευρύτερα χρησιμοποιούμενες τεχνικές και μεθοδολογίες για προβλήματα Ανάλυσης Εικόνας.

Το περιεχόμενο του μαθήματος χωρίζεται στις ακόλουθες 10 ενότητες:
• ΕΝΟΤΗΤΑ 1: Εισαγωγή στην Ανάλυση Εικόνας
• ΕΝΟΤΗΤΑ 2: Σημειακοί, Αλγεβρικοί και Γεωμετρικοί Τελεστές
• ΕΝΟΤΗΤΑ 3: Κατάτμηση και Ανάλυση Εικόνας σε Περιοχές
• ΕΝΟΤΗΤΑ 4: Μετρήσεις Αντικειμένου Εικόνας
• ΕΝΟΤΗΤΑ 5: Ανάλυση Έγχρωμης και Πολυφασματικής Εικόνας
• ΕΝΟΤΗΤΑ 6: Μοντέλο Γεωμετρικών Προβολών
• ΕΝΟΤΗΤΑ 7: Εισαγωγή στην Τριδιάστατη Όραση
• ΕΝΟΤΗΤΑ 8: Στατική Στερεοσκοπική Ανάλυση
• ΕΝΟΤΗΤΑ 9: Δυναμική Στερεοσκοπική Ανάλυση
• ΕΝΟΤΗΤΑ 10: Ειδικά Θέματα Ανάλυσης Εικόνας (Σύντηξη Αισθητηρίων – Βάσεις Δεδομένων Εικόνων)
Μαθησιακά αποτελέσματα:
Με την επιτυχή ολοκλήρωση του μαθήματος ο/η φοιτητής/φοιτήτρια θα είναι σε θέση:
• να κατηγοριοποιεί τα είδη των Τελεστών
• να αναπτύσσει αλγόριθμους επεξεργασίας διδιάστατης εικόνας
• να κατατέμνει εικόνες και να τις αναλύει σε περιοχές
• να ανιχνεύει και να συνδέει ακμές
• να εκτελεί μετρήσεις αντικειμένων σε εικόνες, όπως εμβαδού, περιμέτρου, μήκους, πλάτους κ.λπ., και να υπολογίζει περιγραφείς σχήματος αντικειμένων
• να αναλύει έγχρωμες και πολυφασματικές εικόνες
• να κατανοεί το μοντέλο των κεντρικών και παράλληλων προβολών
• να αναπτύσσει και να εφαρμόζει αλγόριθμους στατικής και δυναμικής στερεοσκοπικής ανάλυσης
• να αναπτύσσει και να χρησιμοποιεί αλγόριθμους σύντηξης αισθητηρίων
• να αξιοποιεί τους κατάλληλους με βάση το περιεχόμενο αλγόριθμους ανάκτησης από βάσεις δεδομένων εικόνων
";
        }

        private static string SoftEngDesc()
        {
            return @"Αντικείμενο μαθήματος
Συμβολή του μαθήματος στην κάλυψη των τεχνολογικών απαιτήσεων:
Οι φοιτητές εκτίθενται σε σύγχρονες τεχνικές μοντελοποίησης λογισμικού, στον αρχιτεκτονικό σχεδιασμό και στη σύγχρονη γλώσσα μοντελοποίησης UML.

1. Μοντέλα κύκλου ζωής λογισμικού με έμφαση στη Rational Unified Process.
2. Γλώσσες μοντελοποίησης με έμφαση στη UML.
3. Προϋπολογισμός κόστους λογισμικού.
4. Ανάλυση απαιτήσεων, σχεδιασμός, υλοποίηση και γλώσσες προγραμματισμού.
5. Έλεγχος, συντήρηση και εργαλεία CASE.

Μαθησιακά αποτελέσματα:
Με την επιτυχή ολοκλήρωση αυτού του μαθήματος ο φοιτητής θα είναι σε θέση να:
• Συντάσσει δομημένα έγγραφα ανάλυσης απαιτήσεων λογισμικού
• Σχεδιάζει αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα
• Παράγει κώδικα βασισμένο στο στάδιο του σχεδιασμού, ο οποίος θα ανταποκρίνεται στα αντίστοιχα διαγράμματα
• Χρησιμοποιεί το μοντέλο κύκλου ζωής λογισμικού Rational Unified Process
";
        }

        private static string DesignPatternsDesc()
        {
            return @"Αντικείμενο μαθήματος
To μάθημα ασχολείται με τη θεωρητική μελέτη και την πρακτική εργαστηριακή εξάσκηση σε θέματα σχεδίασης αποδοτικού λογισμικού, διαχειρίσιμου πηγαίου κώδικα και χρήση προτύπων σχεδίασης λογισμικού που διευκολύνουν την επέκταση, επαναχρησιμοποίηση και αποτελεσματικότητα των εφαρμογών λογισμικού.
Βασίζεται στην έννοια των προτύπων ανάπτυξης λογισμικού (software design patterns) που αποτελούν το «παράδειγμα» καλής πρακτικής στην προσέγγιση υλοποίησης σε ένα επαναλαμβανόμενο πρόβλημα προγραμματισμού συστήματος και λογικής.
Περιλαμβάνει την παρουσίαση προτύπων ανάπτυξης λογισμικού επιχειρώντας να θέσει τις βάσεις για υψηλότερου επιπέδου προγραμματιστικές επιδόσεις και δεξιότητες.
Παρουσιάζονται και γίνεται εξάσκηση στα δημοφιλή μεταξύ άλλων software designs των Singleton, Builder, Prototype, Factory, και AbstractFactory που είναι και γνωστά ως η ομάδα των τεσσάρων «Gang of Four». Ο υψηλότερου επιπέδου, αποδοτικός και αποτελεσματικός προγραμματισμός τόσο σε αντικειμενοστρεφείς όσο και άλλες γλώσσες προγραμματισμού απαιτεί τη γνώση και εφαρμογή προτύπων στην ανάπτυξη λογισμικού. Επιπλέον γίνεται εξάσκηση και εμβάθυνση στην πρακτική βελτίωση υπάρχοντος κώδικα με εφαρμογή επτά βασικών αρχών σχεδίασης λογισμικού.

Ενότητες
1. Αναγκαιότητα των Κλάσεων
2. Συσχετίσεις μεταξύ κλάσεων και UML
3. Πολυμορφισμός & Αρχή της Ενσωμάτωσης
4. Αρχή της Χαμηλής Σύζευξης & Προηγμένες Αρχές Σχεδίασης Λογισμικού
5. Αρχή της Μοναδικής Αρμοδιότητας & Αρχή Ανοικτής-Κλειστής Σχεδίασης
6. Αρχή Υποκατάστασης της Liskov & Αρχή της Αντιστροφής των Εξαρτήσεων
7. Αρχή του Διαχωρισμού των Διασυνδέσεων
8. Εφαρμογή αρχών στα Πρότυπα Σχεδίασης Λογισμικού
9. Προσαρμογέας & Σύνθετο & Γέφυρα
10. Μοναδιαίο & Επισκέπτης & Παρατηρητής
11. Εργοστάσιο
12. Επανασχεδίαση, Αναδόμηση, Επαναπαραγοντοποίηση
13. Εφαρμογές για συστήματα ελέγχου εκδόσεων λογισμικού
14. Μεθοδολογική ανάλυση μελέτης περίπτωσης λογισμικού
15. Εισαγωγή στις ευέλικτες μεθοδολογίες ανάπτυξης λογισμικού και πρότυπα

Μαθησιακά αποτελέσματα:
Με την επιτυχή ολοκλήρωση αυτού του μαθήματος οι φοιτητές θα είναι σε θέση:
• Να εξηγούν και να εφαρμόζουν προηγμένες αρχές σχεδίασης λογισμικού (π.χ. single responsibility, open-closed κλπ).
• Να δημιουργούν πηγαίο κώδικα ακολουθώντας πρότυπο ανάπτυξης λογισμικού.
• Να αναλύουν κριτικά πηγαίο κώδικα και να τον αναδιαμορφώνουν με βάση πρότυπα ανάπτυξης λογισμικού.
• Να διακρίνουν και να αναπτύσσουν λύσεις σε επαναλαμβανόμενα προβλήματα ανάπτυξης λογισμικού με χρήση πρότυπα και αρχές ανάπτυξης λογισμικού.
• Να εξασκούνται σε σύγχρονες τεχνικές σχεδίασης αποδοτικού πηγαίου κώδικα για αποτελεσματικό λογισμικό, καθώς και σε σύγχρονες τεχνικές σχεδίασης αποδοτικού πηγαίου κώδικα για αποτελεσματικό λογισμικό.
• Να μαθαίνουν αποτελεσματικές τεχνικές ανάπτυξης και αναδιοργάνωσης πηγαίου κώδικα για αυξημένη αποδοτικότητα.
• Να αξιολογούν και να εντοπίζουν περιπτώσεις λογισμικού.
";
        }
    }
}
