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
        
        // COEFFICIENT TABLES
        public DbSet<Coefficient> Coefficients { get; set; }
        public DbSet<PostGraduateInstitutionHasCoefficient> PostGraduateInstitutionHasCoefficients { get; set; }
        public DbSet<UserHasCoefficient> UserHasCoefficients { get; set; }
        public DbSet<CourseHasCoefficient> CourseHasCoefficients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDataToCourses(modelBuilder);
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
                
                new Course
                {
                    Id = 1, Name = "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού", UUID = "ΠΛΘΕΤΚΑΕ01", Semester = 7, Description = "", Content = "", AudioFileName = ""
                },
                
                new Course
                {
                    Id = 2, Name = "Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών", UUID = "ΠΛΠΛΗ37-3", Semester = 3, Description = "", Content = "", AudioFileName = ""
                },
                
                new Course
                {
                    Id = 3, Name = "Αντικειμενοστρεφής Προγραμματισμός", UUID = "ΠΛΠΛΗ37-2", Semester = 2, Description = "", Content = "", AudioFileName = ""
                },
                
                new Course
                {
                    Id = 4, Name = "Εικονική Πραγματικότητα", UUID = "ΠΛΕΙΚ03", Semester = 7, Description = "", Content = "", AudioFileName = ""
                },
                
                new Course
                {
                    Id = 5, Name = "Ευφυείς Πράκτορες", UUID = "ΠΛΕΥΠΡ01", Semester = 8, Description = "", Content = "", AudioFileName = ""
                },
                
                new Course
                {
                    Id = 6, Name = "Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών", UUID = "ΠΛΤΑΗΠ01", Semester = 7, Description = "", Content = "", AudioFileName = ""
                }
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

                // Android
                
                new CourseHasCoefficient
                {
                    CourseId = 1,
                    CoefficientName = "MobileAppDev",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 1,
                    CoefficientName = "SoftwareEngineering",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 1,
                    CoefficientName = "WebDev",
                    Value = 5
                },

                // Αντικειμενοστρεφής Ανάπτυξη
                
                new CourseHasCoefficient
                {
                    CourseId = 2,
                    CoefficientName = "SoftwareEngineering",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 2,
                    CoefficientName = "WebDev",
                    Value = 4
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 2,
                    CoefficientName = "MobileAppDev",
                    Value = 3
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 2,
                    CoefficientName = "DatabaseEngineering",
                    Value = 1
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 2,
                    CoefficientName = "GameDev",
                    Value = 1
                },
                
                // OOP
                
                new CourseHasCoefficient
                {
                    CourseId = 3,
                    CoefficientName = "SoftwareEngineering",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 3,
                    CoefficientName = "MobileAppDev",
                    Value = 2
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 3,
                    CoefficientName = "WebDev",
                    Value = 1
                },
                
                // VR
                
                new CourseHasCoefficient
                {
                    CourseId = 4,
                    CoefficientName = "GameDev",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 4,
                    CoefficientName = "ComputerVisionAndGraphics",
                    Value = 7
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 4,
                    CoefficientName = "AI_ML",
                    Value = 2
                },
                
                // intelligent agents
                
                new CourseHasCoefficient
                {
                    CourseId = 5,
                    CoefficientName = "AI_ML",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 5,
                    CoefficientName = "GameDev",
                    Value = 8
                },
                
                // video games
                
                new CourseHasCoefficient
                {
                    CourseId = 6,
                    CoefficientName = "GameDev",
                    Value = 10
                },
                
                new CourseHasCoefficient
                {
                    CourseId = 6,
                    CoefficientName = "SoftwareEngineering",
                    Value = 3
                }
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
                new Question { Id = 60, Content = "Μέσω του μαθήματος Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών , οι φοιτητές μαθάινουν να παράγουν εφαρμογές με _______ και ταχύ ρυθμό.", CourseId = 2 }
            );

            // ANSWERS
            modelBuilder.Entity<Answer>().HasData(
                
                // OOP
                new Answer { Id = 1, QuestionId = 1, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Σωστό" },
                new Answer { Id = 2, QuestionId = 2, Answer1 = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα", Answer2 = "Να γνωρίζουν τις βασικές αρχές της γλώσσας C#", Answer3 = "Να μπορούν να αξιοποιήσουν τις βασικές αλγοριθμικές δομές σε γλώσσα C++", Answer4 = "Να μπορούν να υλοποιούν προγραμματισμό sockets (TCP sockets και UDP sockets).", CorrectAnswer = "Να δημιουργούν τάξεις, διεπαφές και αντικείμενα." },
                new Answer { Id = 3, QuestionId = 3, Answer1 = "Να μπορούν να σχεδιάζουν και να υλοποιούν αλγόριθμους για την αποτελεσματική κατασκευή συνδυαστικών αντικειμένων.", Answer2 = "Να αναγνωρίζουν και να κατανοούν σύγχρονες τεχνικές σχεδίασης ολοκληρωμένων εφαρμογών λογισμικού με υπηρεσίες.", Answer3 = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης.", Answer4 = "Να σχεδιάζουν αρχιτεκτονικά σχέδια λογισμικού βασισμένα σε γλώσσες μοντελοποίησης και διαγράμματα.", CorrectAnswer = "Να εντοπίζουν, αξιολογούν και αξιοποιούν λογισμικό που υλοποιείται σύμφωνα με τις βασικές αρχές της αντικειμενοστρεφούς σχεδίασης." },
                new Answer { Id = 4, QuestionId = 4, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Λάθος" },
                new Answer { Id = 5, QuestionId = 5, Answer1 = "Java", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "Java" },
                new Answer { Id = 6, QuestionId = 6, Answer1 = "Ανάγνωση", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "Ανάγνωση" },
                new Answer { Id = 7, QuestionId = 7, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Σωστό" },
                new Answer { Id = 8, QuestionId = 8, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Λάθος" },
                new Answer { Id = 9, QuestionId = 9, Answer1 = "Εξαιρέσεις", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "Εξαιρέσεις" },
                new Answer { Id = 10, QuestionId = 10, Answer1 = "Αυτόνομη εργασία", Answer2 = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)", Answer3 = "Προσαρμογή σε νέες καταστάσεις", Answer4 = "Σχεδιασμός και διαχείριση έργων", CorrectAnswer = "Αρχιτεκτονική Πελάτη-Εξυπηρετητή (Client-Server)" },
                
                // VR
                new Answer { Id = 11, QuestionId = 11, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Σωστό" },
                new Answer { Id = 12, QuestionId = 12, Answer1 = "γραφικά", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "γραφικά" },
                new Answer { Id = 13, QuestionId = 13, Answer1 = "ευφυών", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "ευφυών" },
                new Answer { Id = 14, QuestionId = 14, Answer1 = "Υφή επιφάνειας αντικειμένων. Διαχείριση πηγών φωτός, ήχων, κάμερας. Animations.", Answer2 = "Ανάπτυξη εφαρμογών εικονικής πραγματικότητας στην πλατφόρμα Unity3D.", Answer3 = "Κόσμοι τρισδιάστατων γραφικών. Τρισδιάστατα μοντέλα αντικειμένων.", Answer4 = "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού.", CorrectAnswer = "Δομή και λειτουργία ενός ηλεκτρονικού παιχνιδιού." },
                new Answer { Id = 15, QuestionId = 15, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Λάθος" },
                new Answer { Id = 16, QuestionId = 16, Answer1 = "Unity3D", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "Unity3D" },
                new Answer { Id = 17, QuestionId = 17, Answer1 = "Σωστό", Answer2 = "Λάθος", Answer3 = null, Answer4 = null, CorrectAnswer = "Σωστό" },
                new Answer { Id = 18, QuestionId = 18, Answer1 = "συνιστώσες", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "συνιστώσες" },
                new Answer { Id = 19, QuestionId = 19, Answer1 = "Μετρήσεις Αντικειμένου Εικόνας", Answer2 = "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση.", Answer3 = "Δομή και την λειτουργία ενός ευφυούς πράκτορα μέσα σε ένα περιβάλλον.", Answer4 = "Αντιδρασιακοί πράκτορες (Reactive Agents) και Βουλητικοί πράκτορες (Deliberative Agents).", CorrectAnswer = "Εισαγωγή στα Γραφικά με Υπολογιστές, συστήματα απεικόνισης, χρώμα, γεωμετρικά σχήματα, μετασχηματισμοί, κίνηση." },
                new Answer { Id = 20, QuestionId = 20, Answer1 = "VRML: sensors και animation, γενικές αρχές μοντελοποίησης σκελετού, πρότυπα μοντελοποίησης κίνησης σώματος (H-Anim, κ.ά.), scripting, ενσωμάτωση σε εφαρμογές, PROTOs, προτεινόμενες πρακτικές σχεδιασμού και ανάπτυξης.", Answer2 = "VRML: σύνταξη, υλοποιήσεις, βασικά εργαλεία, γεωμετρία, μετασχηματισμοί, επαναχρησιμοποίηση κόμβων, εξωτερικές αναφορές, υλικά/χρώμα, φωτισμός, υφή, viewpoints, background, ήχος, κείμενο, billboards, HUDs.", Answer3 = "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης.", Answer4 = "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης.", CorrectAnswer = "Σχεδιασμός Κατανεμημένων Περιβαλλόντων Μάθησης." },

                // android
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" },
                new Answer { Id = 1, QuestionId = 1, Answer1 = "", Answer2 = null, Answer3 = null, Answer4 = null, CorrectAnswer = "" }
            );
        }
    }
}
