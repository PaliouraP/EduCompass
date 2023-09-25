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
        public DbSet<Coefficient> Coefficients { get; set; }
        public DbSet<PrerequisiteCourse> PrerequisiteCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().HasData();

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
                
                // Security
                new PostGraduateInstitutionHasCoefficient
                {
                    PostGraduateInstitutionId = 2,
                    CoefficientName = "Security",
                    HasCoefficient = true
                }
            );

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
                    //SoftwareEngineering = true,
                },
                
                new PostGraduateInstitution
                {
                    Id = 4,Name = "Πανεπιστήμιο Πειραιώς", Department = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=576&Itemid=814&lang=el",
                    //ComputerNetworks = true, Security = true, WebDev = true
                },
                
                new PostGraduateInstitution
                {
                    Id = 5, Name = "Πανεπιστήμιο Πειραιώς", Department = "Προηγμένες Τεχνολογίες Πληροφορικής και Υπηρεσίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=653&Itemid=812&lang=el",
                    //ComputerNetworks = true, Security = true
                },

                // ΟΠΑ (ΑΣΟΕΕ)
                
                new PostGraduateInstitution
                {
                    Id = 6, Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Ανάπτυξη και Ασφάλεια Πληροφοριακών Συστημάτων", Town = "Αθήνα", Hyperlink = "https://mscis.cs.aueb.gr/el/normal/home",
                    //Security = true, WebDev = true
                },

                new PostGraduateInstitution
                {
                    Id = 7, Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Επιστήμη Δεδομένων", Town = "Αθήνα", Hyperlink = "https://www.dept.aueb.gr/el/cs/content/%CF%80%CE%BC%CF%83-%CF%83%CF%84%CE%B7%CE%BD-%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B7-%CE%B4%CE%B5%CE%B4%CE%BF%CE%BC%CE%AD%CE%BD%CF%89%CE%BD",
                    //DatabaseEngineering = true,
                },

                // ΕΚΠΑ
                
                new PostGraduateInstitution
                {
                    Id = 8,Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Μηχανική Υπολογιστών, Τηλεποικοινωνιών και Δικτύων", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/eng",
                    //ComputerNetworks = true
                },
                
                new PostGraduateInstitution
                {
                    Id = 9,Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Τεχνολογίες Πληροφορικής και Τηλεποικοινωνιών", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/ict",
                    //ComputerNetworks = true, WebDev = true,
                },

                new PostGraduateInstitution
                {
                    Id = 10,Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Data Science and Information Technologies", Town = "Αθήνα", Hyperlink = "https://dsit.di.uoa.gr/",
                    // DatabaseEngineering = true
                },
                
                // ΠΑΜΑΚ
                
                new PostGraduateInstitution
                {
                    Id = 11,Name = "Πανεπιστήμιο Μακεδονίας", Department = "Προηγμένη Τεχνολογία Λογισμικού", Town = "Θεσσαλονίκη", Hyperlink = "https://mai.uom.gr/frontend/articles.php?cid=41&t=Proigmeni-Texnologia-Logismikou",
                    //SoftwareEngineering = true
                },
                
                new PostGraduateInstitution
                {
                    Id = 12,Name = "Πανεπιστήμιο Μακεδονίας", Department = "Ανάπτυξη Ψηφιακών Παιχνιδιών και Πολυμεσικών Εφαρμογών", Town = "Θεσσαλονίκη", Hyperlink = "https://gamedev.uowm.gr/",
                    //GameDev = true, ComputerVisionAndGraphics = true
                },
                
                new PostGraduateInstitution
                {
                    Id = 13,Name = "Πανεπιστήμιο Μακεδονίας", Department = "Ανάπτυξη Εφαρμογών Ιστού και Κινητών Συσκευών", Town = "Θεσσαλονίκη", Hyperlink = "https://mai.uom.gr/frontend/articles.php?cid=159&t=Anaptuksi-Efarmogwn-Istou-kai-Kinitwn-Suskeuwn",
                    //MobileAppDev = true, WebDev = true, UI_UX = true
                },
                
                // ΠΑΝΕΠΙΣΤΗΜΙΟ ΠΑΤΡΩΝ
                
                new PostGraduateInstitution
                {
                    Id = 14,Name = "Πανεπιστήμιο Πατρών", Department = "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", Town = "Πάτρα", Hyperlink = "https://hcimaster.upatras.gr/regulation/",
                    //UI_UX = true
                }
            );

            modelBuilder.Entity<Coefficient>().HasData(

                new Coefficient
                {
                    Name = "SoftwareEngineering", NameInGreek = "Τεχνολογία Λογισμικού"
                },
                
                new Coefficient
                {
                    Name = "AI_ML", LongName = "Artificial Intelligence and Machine Learning", NameInGreek = "Τεχνητή Νοημοσύνη και Μηχανική Μάθηση"
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
    }
}
