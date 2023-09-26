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
    }
}
