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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                
                    new Course { UUID = "ΠΛΠΛΗ90", Name = "Τεχνολογίες Διαδικτύου", InIntro = true, Description = "Το μάθημα αναφέρεται σε εισαγωγικά θέματα Τεχνολογιών Διαδικτύου: Βασικές Αρχές και Λειτουργίες Διαδικτύου. Υπηρεσίες Διαδικτύου. " +
                        "Ο Παγκόσμιος Ιστός και το Μοντέλο Πελάτη – Εξυπηρετητή. Προγραμματισμός στο Διαδίκτυο από την πλευρά του πελάτη και από την πλευρά του εξυπηρετητή, Σχεδιασμός και Υλοποίηση Εφαρμογών στον Παγκόσμιο Ιστό. Αλληλεπιδραστικές " +
                        "Ιστοσελίδες με Χρήση Γλωσσών Σεναρίων (scripting languages). Ανάπτυξη Σύνθετης Εφαρμογής.", 
                        Year = 1, Semester = 1, ComputerNetworks = 8, WebDev = 8, SoftwareEngineering = 4, UI_UX = 1},
                    
                    new Course { UUID = "ΠΛΠΛΗ37-2", Name = "Αντικειμενοστρεφής Προγραμματισμός", InIntro = true, Description = "Αντικειμενοστρέφεια", Year = 1, Semester = 2, SoftwareEngineering = 10, WebDev = 1, MobileAppDev = 1},
                    
                    new Course { UUID = "ΠΛΠΛΗ02-2", Name = "Αρχές Προγραμματισμού", InIntro = true, Description = "", Year = 1, Semester = 1, SoftwareEngineering = 1}
                );
        }
    }
}
