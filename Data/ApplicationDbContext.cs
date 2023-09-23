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
            //SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                
                // ΠΡΩΤΟ ΕΤΟΣ
                
                    // πρώτο εξάμηνο
                
                    new Course { UUID = "ΠΛΠΛΗ90", Name = "Τεχνολογίες Διαδικτύου", InIntro = true, Description = "Το μάθημα αναφέρεται σε εισαγωγικά θέματα Τεχνολογιών Διαδικτύου: Βασικές Αρχές και Λειτουργίες Διαδικτύου. Υπηρεσίες Διαδικτύου. " +
                        "Ο Παγκόσμιος Ιστός και το Μοντέλο Πελάτη – Εξυπηρετητή. Προγραμματισμός στο Διαδίκτυο από την πλευρά του πελάτη και από την πλευρά του εξυπηρετητή, Σχεδιασμός και Υλοποίηση Εφαρμογών στον Παγκόσμιο Ιστό. Αλληλεπιδραστικές " +
                        "Ιστοσελίδες με Χρήση Γλωσσών Σεναρίων (scripting languages). Ανάπτυξη Σύνθετης Εφαρμογής.", 
                        Year = 1, Semester = 1, 
                        ComputerNetworks = 8, WebDev = 8, SoftwareEngineering = 4, UI_UX = 4},
                    
                    new Course { UUID = "ΠΛΜΑΘ24", Name = "Ανάλυση I", InIntro = false, Description = "", 
                        Year = 1, Semester = 1, 
                        AI_ML = 4,
                        },
                    
                    new Course { UUID = "ΠΛΠΛΗ68", Name = "Λογική Σχεδίαση Ψηφιακών Συστημάτων", InIntro = false, Description = "", 
                        Year = 1, Semester = 1,
                        ComputerNetworks = 4
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘΥ01", Name = "Μαθηματικά Υπολογιστών", InIntro = false, Description = "", 
                        Year = 1, Semester = 1, 
                        AI_ML = 4
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ01-1", Name = "Εισαγωγή στην Επιστήμη των Υπολογιστών", InIntro = false, Description = "", 
                        Year = 1, Semester = 1, 
                        AI_ML = 5
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ02-2", Name = "Αρχές Προγραμματισμού", InIntro = true, Description = "Βασικές αρχές Προγραμματισμού. Εξέλιξη Λογισμικού. Ανάλυση προβλήματος - σχεδιασμός - αναλυτικός αλγόριθμος και ανάπτυξη προγράμματος. " +
                            "Νόρμες προγραμμάτων. Βασικές δομές της C/C++. Τελεστές. Εντολές C++. Συναρτήσεις Χρήστη και Βιβλιοθήκης C++. Αριστοποίηση προγραμμάτων. Εισαγωγή στον αντικειμενοστραφή προγραμματισμό με C++. Είσοδος/'Εξοδος με αρχεία. Σειριακή" +
                            " και κατευθυνόμενη  προσπέλαση. Σύγκριση C++ με τον παραδοσιακό προγραμματισμό της FORTRAN ή και της PASCAL. Ασκήσεις/Εφαρμογές.", 
                        Year = 1, Semester = 1, 
                        SoftwareEngineering = 7 },
                    
                    // δεύτερο εξάμηνο
                    
                    new Course { UUID = "ΠΛΠΛΗ37-2", Name = "Αντικειμενοστρεφής Προγραμματισμός", InIntro = true, Description = "Το κύριο αντικείμενο του μαθήματος είναι η εισαγωγή στον αντικειμενοστρεφή προγραμματισμό με πλήρη ανάλυση της γλώσσας προγραμματισμού JAVA. " +
                        "Βασικές δομές, κληρονομικότητα, εντολές, ειδικές κλάσεις, εξαιρέσεις, ειδικά θέματα, βιβλιοθήκες/διαπροσωπίες,  προσπέλαση αρχείων και Βάσεων, κα.", 
                        Year = 1, Semester = 2, 
                        SoftwareEngineering = 10, WebDev = 1, MobileAppDev = 1},
                    
                    new Course { UUID = "ΠΛΜΑΘ25", Name = "Ανάλυση ΙΙ", InIntro = false, Description = "", 
                        Year = 1, Semester = 2, 
                        AI_ML = 5
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ52", Name = "Αρχιτεκτονική Υπολογιστών", InIntro = false, Description = "", 
                        Year = 1, Semester = 2, 
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ71", Name = "Διακριτά Μαθηματικά", InIntro = false, Description = "", 
                        Year = 1, Semester = 2, 
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ31", Name = "Δομές Δεδομένων", InIntro = false, Description = "", 
                        Year = 1, Semester = 2, 
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ02-3", Name = "Εφαρμοσμένη Άλγεβρα", InIntro = false, Description = "", 
                        Year = 1, Semester = 2, 
                    },
                    
                    
                // ΔΕΥΤΕΡΟ ΕΤΟΣ

                    // τρίτο εξάμηνο
                    
                    new Course { UUID = "ΠΛΠΛΗ37-3", Name = "Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών", InIntro = true, Description = "Το αντικείμενο του μαθήματος είναι η ανάπτυξη εφαρμογών βάσει του αντικειμενοστρεφούς " +
                        "μοντέλου ανάπτυξης λογισμικού. Η γλώσσα προγραμματισμού που χρησιμοποιείται ως βάση είναι η C#, που θεωρείται από τις πλέον σύγχρονες αντικειμενοστρεφείς γλώσσες. Στο πλαίσιο του μαθήματος δίνεται " +
                        "ιδιαίτερη έμφαση στα εργαλεία ανάπτυξης εφαρμογών, ολοκληρωμένα περιβάλλοντα ανάπτυξης (IDEs) και συγκεκριμένα το εργαλείο που χρησιμοποιείται είναι το Visual Studio Enterprise Edition. Με τη χρήση " +
                        "του Visual Studio και της C# ως γλώσσας προγραμματισμού, οι φοιτητές μαθαίνουν να αναπτύσσουν desktop, web, ή/και mobile εφαρμογές, γρήγορα, αποδοτικά και κυρίως με την όσο το δυνατόν μικρότερη πιθανότητα " +
                        "να κάνουν λάθη προγραμματισμού ή/και λογικής.", 
                        Year = 2, Semester = 3, 
                        SoftwareEngineering = 10, WebDev = 3, DatabaseEngineering = 1, GameDev = 1},
                    
                    new Course { UUID = "ΠΛΠΛΗ41-1", Name = "Λειτουργικά Συστήματα", InIntro = false, Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ06-1", Name = "Μαθηματικός Προγραμματισμός", InIntro = false, Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ08", Name = "Μεταγλωττιστές", InIntro = false, Description = "", 
                        Year = 2, Semester = 3, 
                        AI_ML = 6
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ23-1", Name = "Πιθανότητες και Στατιστική", InIntro = false, Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    // (ΤΑ ΕΠΙΛΟΓΗΣ) //
                    
                    new Course { UUID = "ΠΛΔΙΚ01", Name = "Δίκαιο της Πληροφορικής", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ35-1", Name = "Εφαρμογές Θεωρίας Γραφημάτων", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    new Course { UUID = "ΠΛΜΑΝΖ01", Name = "Μάνατζμεντ", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    new Course { UUID = "ΠΛΠΑΙΔ01", Name = "Παιδαγωγικά", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 3, 
                    },
                    
                    // τέταρτο εξάμηνο
                
                    new Course { UUID = "ΠΛΠΛΗ30-1", Name = "Βάσεις Δεδομένων", InIntro = true, Description = "Σκοπός του μαθήματος είναι αρχικά η κατανόηση των Βάσεων Δεδομένων (ΒΔ) ως συλλογές σχέσεων (πινάκων), " +
                            "μέσα από την παρουσίαση του θεωρητικού υπόβαθρου (Σχεσιακό Μοντέλο, Σχεσιακή Άλγεβρα) και της βασικής γλώσσας διεπαφής με αυτές (γλώσσα SQL), και κατόπιν η μελέτη τεχνικών σχεδίασης " +
                            "Σχεσιακών ΒΔ, με χρήση των αρχών της Θεωρίας Κανονικοποίησης.", 
                        Year = 2, Semester = 4, 
                        DatabaseEngineering = 10, WebDev = 5},
                
                    new Course { UUID = "ΠΛΔΠΙ01", Name = "Προγραμματισμός στο Διαδίκτυο και στον Παγκόσμιο Ιστό", InIntro = true, Description = "Το μάθημα ασχολείται με τη θεωρητική μελέτη και την πρακτική εξάσκηση " +
                            "σε θέματα προγραμματισμού στο διαδίκτυο και στον παγκόσμιο ιστό, όπως προγραμματισμό sockets, την υλοποίηση εφαρμογών πελάτη-εξυπηρετητή και τις αρχιτεκτονικές 3-tier.", 
                        Year = 2, Semester = 4, 
                        WebDev = 10, DatabaseEngineering = 5, SoftwareEngineering = 4, UI_UX = 3, Security = 3},
                    
                    new Course { UUID = "ΠΛΜΑΘ45", Name = "Αλγόριθμοι", InIntro = false, Description = "", 
                        Year = 2, Semester = 4, 
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ10-1", Name = "Αρχές και Εφαρμογές Σημάτων και Συστημάτων", InIntro = false, Description = "", 
                        Year = 2, Semester = 4, 
                        AI_ML = 8
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ44", Name = "Δίκτυα Υπολογιστών", InIntro = false, Description = "", 
                        Year = 2, Semester = 4, 
                        ComputerNetworks = 10
                    },
                    
                    // (ΤΑ ΕΠΙΛΟΓΗΣ) //
                    
                    new Course { UUID = "ΟΚΟΔΕ08", Name = "Επιχερησιακή Στρατηγική", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 4, 
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ46-1", Name = "Εφαρμοσμένη Συνδυαστική", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 4, 
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ73-1", Name = "Θεωρία Πληροφοριών και Κωδίκων", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 4, 
                        Security = 5, AI_ML = 3
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗΚΕΚ01", Name = "Πληροφορική στην Εκπαίδευση", InIntro = false, CourseType = "Optional", Description = "", 
                        Year = 2, Semester = 4, 
                    },
                
                // ΤΡΙΤΟ ΕΤΟΣ
                    
                    // πέμπτο εξάμηνο
                
                    new Course { UUID = "ΠΛΠΛΗ20", Name = "Αλληλεπίδραση Ανθρώπου-Υπολογιστή", InIntro = true, Description = "Σχεδιασμός του συστήματος διεπαφής με τον χρήστη, η ανθρώπινη πλευρά στην αλληλεπίδραση. " +
                            "Κλασσικά και σύγχρονα μέσα επικοινωνίας του υπολογιστή. Μοντέλα αλληλεπίδρασης και μοντέλα για τον χρήστη. Στόχοι, μέθοδοι, ανάλυση εργασιών. Χρηστικότητα, φιλικότητα λογισμικού.", 
                        Year = 3, Semester = 5, 
                        UI_UX = 10, SoftwareEngineering = 4},
                
                    new Course { UUID = "ΠΛΠΛΗ50", Name = "Αναγνώριση Προτύπων", InIntro = true, Description = "Αναγνώριση Προτύπων (pattern recognition) είναι η επιστημονική περιοχή που έχει στόχο την " +
                            "ταξινόμηση αντικειμένων σε κατηγορίες (κλάσεις) και συμπεριλαμβάνει το επιστημονικό πεδίο της Μηχανικής Μάθησης (machine learning). Σκοπός, επομένως, του παρόντος μαθήματος " +
                            "είναι να παρουσιάσει με ενιαίο τρόπο τις ευρύτερα χρησιμοποιούμενες τεχνικές και μεθοδολογίες για προβλήματα αναγνώρισης προτύπων.", 
                            Year = 3, Semester = 5, 
                            AI_ML = 10},
                    
                    new Course { UUID = "ΠΛΠΛΗ81-2", Name = "Πληροφοριακά Συστήματα", InIntro = false, Description = "", 
                        Year = 3, Semester = 5
                        
                    },

                    // τλες
                    new Course { UUID = "ΠΛΜΑΘ71", Name = "Λογικός Προγραμματισμός", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                            Year = 3, Semester = 5, 
                            AI_ML = 7
                        },
                
                    // πσυ
                    new Course { UUID = "ΠΛΚΡΥ01", Name = "Κρυπτογραφία", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                            Year = 3, Semester = 5, 
                            Security = 10
                        },
                
                    // πσυ + τλες
                    new Course { UUID = "ΠΛΠΛΗ33-2", Name = "Συστήματα Διαχείρισης Βάσεων Δεδομένων", InIntro = true, Description = "", CourseType = "ΠΣΥ, ΤΛΕΣ",
                            Year = 3, Semester = 5, 
                            DatabaseEngineering = 10
                        },
                    
                    // δυς
                
                    new Course { UUID = "ΠΛΠΘΕ01", Name = "Προηγμένα Θέματα Επικοινωνιών", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 3, Semester = 5, 
                        ComputerNetworks = 10
                    },
                
                    new Course { UUID = "ΠΛΠΡΟ01", Name = "Προηγμένη Αρχιτεκτονική Υπολογιστών", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                            Year = 3, Semester = 5, 
                            ComputerNetworks = 6
                        },
                    
                    // επιλογής
                
                    new Course { UUID = "ΠΛΘΕΠ01", Name = "Ειδικά Θέματα Επιχειρησιακής Έρευνας", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                            Year = 3, Semester = 5, 
                        },
                    
                    new Course { UUID = "ΠΛΛΟΔΙΜ01", Name = "Λογισμικό Διαχείρισης Μάθησης", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                            Year = 3, Semester = 5, 
                            SoftwareEngineering = 7
                        },
                
                    new Course { UUID = "ΠΛΛΟΔΙΜ01", Name = "Θεωρία Υπολογισμού", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 5, 
                    },
                
                    new Course { UUID = "ΠΛΛΟΔΙΜ01", Name = "Ουρές Αναμονής", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 5,
                        
                    },

                    // έκτο εξάμηνο
                
                    new Course { UUID = "ΠΛΠΛΗ46", Name = "Τεχνολογία Λογισμικού", InIntro = true, Description = "",
                        Year = 3, Semester = 6, 
                        SoftwareEngineering = 10
                    },
                
                    new Course { UUID = "ΠΛΠΛΗ18-1", Name = "Τεχνητή Νοημοσύνη και Έμπειρα Συστήματα", InIntro = true, Description = "",
                        Year = 3, Semester = 6, 
                        AI_ML = 10
                    },

                    // τλες
                
                    new Course { UUID = "ΠΛΒΙΟΠ01", Name = "Βιοπληροφορική", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                            Year = 3, Semester = 6, 
                            AI_ML = 5, ComputerVisionAndGraphics = 4
                        },
                
                    new Course { UUID = "ΠΛΠΛΗ24-01", Name = "Επεξεργασία Φυσικής Γλώσσας", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 3, Semester = 6, 
                        AI_ML = 6
                    },
                
                    new Course { UUID = "ΠΛΠΛΗ48", Name = "Συστήματα Πολυμέσων", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 3, Semester = 6, 
                        AI_ML = 6, ComputerVisionAndGraphics = 8
                    },
                
                    // πσυ
                
                    new Course { UUID = "ΠΛΑΝΑΔΕ01", Name = "Αναλυτική Δεδομένων", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                        Year = 3, Semester = 6, 
                        AI_ML = 10, DatabaseEngineering = 6
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ36-1", Name = "Συστήματα Υποστήριξης Αποφάσεων", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                        Year = 3, Semester = 6, 
                    },
                
                    new Course { UUID = "ΠΛΠΛΗ69-1", Name = "Συστημική Ανάλυση", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                        Year = 3, Semester = 6, 
                        AI_ML = 6
                    },
                
                    // δυς
                
                    new Course { UUID = "ΠΛΠΛΗ49", Name = "Δίκτυα Υψηλών Ταχυτήτων", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 3, Semester = 6, 
                        ComputerNetworks = 10
                    },
                    
                    new Course { UUID = "ΠΛΠΛΗ91-1", Name = "Προγραμματισμός Συστημάτων, Τηλεπικοινωνιών και Υπηρεσιών", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 3, Semester = 6, 
                        ComputerNetworks = 10
                    },
                
                    new Course { UUID = "ΠΛΠΛΗ53", Name = "Σχεδίαση Υπολογιστικών Συστημάτων", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 3, Semester = 6, 
                        ComputerNetworks = 10, Security = 4
                    },
                
                    // επιλογής
                
                    new Course { UUID = "ΠΛΔΙΠ01-1", Name = "Διδακτική της Πληροφορικής", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 6, 
                        SoftwareEngineering = 6, UI_UX = 6
                    },
                    
                    new Course { UUID = "ΠΛΕΑΚΔ01", Name = "Ευφυής Αλληλεπίδραση με Κοινωνικά Δίκτυα", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 6, 
                        ComputerNetworks = 10
                    },
                
                    new Course { UUID = "ΠΛΠΡΑΝ01", Name = "Παράλληλος Υπολογισμός", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 6, 
                        AI_ML = 5
                    },
                
                    new Course { UUID = "ΠΛΠΡΑΝΑΛ01", Name = "Πρότυπα Ανάπτυξης Λογισμικού", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 3, Semester = 6, 
                        SoftwareEngineering = 10
                    },
                
                // ΤΕΤΑΡΤΟ ΕΤΟΣ

                    // έβδομο εξάμηνο
                    
                    // τλες
                
                    new Course { UUID = "ΠΛΕΙΚ03", Name = "Εικονική Πραγματικότητα", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                            Year = 4, Semester = 7, 
                            GameDev = 10, ComputerVisionAndGraphics = 7, AI_ML = 2
                    },
                
                    new Course { UUID = "ΠΛΕΙΚ01", Name = "Ανάλυση Εικόνας", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                            Year = 4, Semester = 7, 
                            ComputerVisionAndGraphics = 10, AI_ML = 7
                    },
                    
                    new Course { UUID = "ΠΛΘΕΤΚΑΕ01", Name = "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 4, Semester = 7, 
                        SoftwareEngineering = 10, MobileAppDev = 10, WebDev = 5
                    },
                
                    // πσυ
                
                    new Course { UUID = "ΠΛΗΘΕΔ01", Name = "Θέματα Επιστήμης Δεδομένων", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                            Year = 4, Semester = 7, 
                            AI_ML = 8
                    },
                    
                    new Course { UUID = "ΠΛΜΑΘ34-4", Name = "Προσομοίωση Συστημάτων", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                        Year = 4, Semester = 7, 
                        AI_ML = 3, ComputerNetworks = 3
                    },
                    
                    // δυς
                
                    new Course { UUID = "ΠΛΚΑΕ01", Name = "Κινητές και Ασύρματες Επικοινωνίες", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 4, Semester = 7, 
                        ComputerNetworks = 10, Security = 4
                    },
                
                    new Course { UUID = "ΠΛΣΥΣ01-1", Name = "Κατανεμημένα και Πολυεπεξεργαστικά Υπολογιστικά Συστήματα", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 4, Semester = 7,
                        WebDev = 5, Security = 8, ComputerNetworks = 10, 
                    },
                
                    // πσυ + δυς
                
                    new Course { UUID = "ΠΛΠΛΗ47", Name = "Ασφάλεια Πληροφοριακών Συστημάτων", InIntro = true, Description = "", CourseType = "ΠΣΥ, ΔΥΣ",
                        Year = 4, Semester = 7, 
                        Security = 10, WebDev = 6, ComputerNetworks = 6
                    },
                
                    // επιλογης
                
                    new Course { UUID = "ΠΛΔΙΓ01", Name = "Διαχείριση Γνώσης", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                            Year = 4, Semester = 7, 
                    },
                
                    new Course { UUID = "ΠΛΑΠΡΟΔΙΔ01", Name = "Αξιολόγηση Προγραμμάτων Διδασκαλίας", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                    },
                
                    new Course { UUID = "ΠΛΕΠΔΙΠΡ01", Name = "Έξυπνες Πόλεις και Διαδίκτυο των Πραγμάτων", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        ComputerNetworks = 8, Security = 1, WebDev = 1
                    },
                
                    new Course { UUID = "ΠΛΗΛΜΚΔ01", Name = "Ηλεκτρονική Μάθηση και Κοινωνικά Δίκτυα", InIntro = true, Description = "Το μάθημα ασχολείται με την αξιοποίηση των Τεχνολογιών Πληροφορικής και Επικοινωνιών (ΤΠΕ) στην εκπαίδευση. Στόχος του συγκεκριμένου μαθήματος είναι η διδασκαλία των τεχνικών και των εργαλείων με τα οποία είναι δυνατός ο συγκερασμός των σύγχρονων πηγών ηλεκτρονικής μάθησης με τα ψηφιακά κοινωνικά δίκτυα, από τους παιδαγωγούς της ανώτερης εκπαίδευσης. Βασική επιδίωξη του μαθήματος είναι να μεταδώσει στους φοιτητές την ιδιαίτερη σημασία της κοινωνικής δικτύωσης σε θέματα που αφορούν κατά κύριο λόγο στην κατανεμημένη εκπαίδευση και το πως αυτή ενισχύει την συνεργασία μεταξύ των σχεδιαστών μαθημάτων αλλά και τον διαμοιρασμό του εκπαιδευτικού περιεχομένου.", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        SoftwareEngineering = 5, WebDev = 3
                    },
                
                    new Course { UUID = "ΠΛΟΔΕΓ01", Name = "Οχηματικά Δίκτυα Επόμενης Γενιάς", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        ComputerNetworks = 10, AI_ML = 5
                    },
                
                    new Course { UUID = "ΠΛΠΛΗ74", Name = "Ανάκτηση Πληροφορίας και Αναζήτηση στον Παγκόσμιο Ιστό", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        WebDev = 5, AI_ML = 5, ComputerNetworks = 3
                    },

                    new Course { UUID = "ΠΛΤΑΗΠ01", Name = "Τεχνολογίες Ανάπτυξης Ηλεκτρονικών Παιχνιδιών", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        GameDev = 10, SoftwareEngineering = 3
                    },
                
                    new Course { UUID = "ΠΛΥΠΛΟ01", Name = "Υπηρεσιοστρεφές Λογισμικό", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 7, 
                        WebDev = 10, DatabaseEngineering = 7, UI_UX = 4, SoftwareEngineering = 6
                    },
                
                    // όγδοο εξάμηνο
                    
                    // τλες
                    
                    new Course { UUID = "ΠΛΕΠΣΦΗ01", Name = "Επεξεργασία Σημάτων Φωνής και Ήχου", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 4, Semester = 8,
                        AI_ML = 10
                    },
                
                    new Course { UUID = "ΠΛΕΥΦΠΡ01", Name = "Ευφυείς Πράκτορες", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 4, Semester = 8, 
                        GameDev = 8, AI_ML = 10
                    },
                
                    new Course { UUID = "ΠΛΕΚΛ01", Name = "Εκπαιδευτικό Λογισμικό", InIntro = true, Description = "", CourseType = "ΤΛΕΣ",
                        Year = 4, Semester = 8, 
                        SoftwareEngineering = 7, UI_UX = 4, DatabaseEngineering = 1, WebDev = 1
                    },
                    
                    // πσυ
                
                    new Course { UUID = "ΠΛΔΙΠ01", Name = "Διοικητική Πληροφορική", InIntro = true, Description = "", CourseType = "ΠΣΥ",
                        Year = 4, Semester = 8, 
                        AI_ML = 4
                    },
                    
                    // δυς
                    
                    new Course { UUID = "ΠΛΑΣΦΔ01", Name = "Ασφάλεια Δικτύων", InIntro = true, Description = "", CourseType = "ΔΥΣ",
                        Year = 4, Semester = 8, 
                        Security = 10, ComputerNetworks = 6
                    },
                    
                    // πσυ + δυς
                
                    new Course { UUID = "ΠΛΗΕΠΚ01", Name = "Ηλεκτρονικό Επιχειρήν και Καινοτομία", InIntro = true, Description = "", CourseType = "ΠΣΥ, ΔΥΣ",
                        Year = 4, Semester = 8,
                        SoftwareEngineering = 6
                    },
                
                    new Course { UUID = "ΠΛΣΥΔ01", Name = "Πληροφοριακά Συστήματα στο Διαδίκτυο", InIntro = true, Description = "", CourseType = "ΠΣΥ, ΔΥΣ",
                        Year = 4, Semester = 8, 
                        WebDev = 10, DatabaseEngineering = 7, UI_UX = 5, Security = 3, ComputerNetworks = 3, SoftwareEngineering = 5
                    },
                
                    // επιλογης

                    new Course { UUID = "ΠΛΘΕΔΔΚΕ01", Name = "Προηγμένα Θέματα Διαχείρισης Δικτύων και Κινητών Επικοινωνιών", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 8, 
                        ComputerNetworks = 10
                    },
                
                    new Course { UUID = "ΠΛΣΥΣ02", Name = "Συστήματα ERP/CRM", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 8, 
                    },
                
                    new Course { UUID = "ΠΛΣΥΣ03", Name = "Συστήματα Διασφάλισης Ποιότητας", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 8,
                        
                    },
                
                    new Course { UUID = "ΠΛΤΕΒΕΦ01", Name = "Τεχνολογίες Blockchain και Εφαρμογές", InIntro = true, Description = "", CourseType = "ΕΠΙΛΟΓΗΣ",
                        Year = 4, Semester = 8,
                        AI_ML = 8, Security = 6, 
                    }
                
                );

            modelBuilder.Entity<PostGraduateInstitution>().HasData(
                
                // ΕΜΠ
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Μετσόβειο Πολυτεχνείο", Department = "Επιστήμη Δεδομένων και Μηχανική Μάθηση", Town = "Αθήνα", Hyperlink = "https://dsml.ece.ntua.gr/",
                    AI_ML = true, DatabaseEngineering = true, 
                },
                
                // ΠΑΠΕΙ
                
                new PostGraduateInstitution
                {
                    Name = "Πανεπιστήμιο Πειραιώς", Department = "Κυβερνοασφάλεια και Επιστήμη Δεδομένων", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=609&Itemid=813&lang=el",
                    AI_ML = true, Security = true, DatabaseEngineering = true
                },
                
                new PostGraduateInstitution
                {
                    Name = "Πανεπιστήμιο Πειραιώς", Department = "Προηγμένα Συστήματα Πληροφορικής - Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=626&Itemid=815&lang=el",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Πανεπιστήμιο Πειραιώς", Department = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=576&Itemid=814&lang=el",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Πανεπιστήμιο Πειραιώς", Department = "Προηγμένες Τεχνολογίες Πληροφορικής και Υπηρεσίες", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=653&Itemid=812&lang=el",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Πανεπιστήμιο Πειραιώς", Department = "Οργάνωση και Διοίκηση Υπηρεσιών Υγείας - Πληροφορική Υγείας", Town = "Πειραιάς", Hyperlink = "https://www.cs.unipi.gr/index.php?option=com_k2&view=item&layout=item&id=568&Itemid=817&lang=el"
                    
                },

                // ΟΠΑ (ΑΣΟΕΕ)
                
                new PostGraduateInstitution
                {
                    Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Ανάπτυξη και Ασφάλεια Πληροφοριακών Συστημάτων", Town = "Αθήνα", Hyperlink = "https://mscis.cs.aueb.gr/el/normal/home",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Επιστήμη Υπολογιστών", Town = "Αθήνα", Hyperlink = "http://grad.cs.aueb.gr/",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Επιστήμη Δεδομένων", Town = "Αθήνα", Hyperlink = "https://www.dept.aueb.gr/el/cs/content/%CF%80%CE%BC%CF%83-%CF%83%CF%84%CE%B7%CE%BD-%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B7-%CE%B4%CE%B5%CE%B4%CE%BF%CE%BC%CE%AD%CE%BD%CF%89%CE%BD",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Οικονομικό Πανεπιστήμιο Αθηνών", Department = "Ψηφιακές Μέθοδοι για τις Ανθρωπιστικές Επιστήμες", Town = "Αθήνα", Hyperlink = "https://www.dept.aueb.gr/el/MScdmh",
                    
                },
                
                // ΕΚΠΑ
                
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Μηχανική Υπολογιστών, Τηλεποικοινωνιών και Δικτύων", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/eng",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Τεχνολογίες Πληροφορικής και Τηλεποικοινωνιών", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/ict",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Πληροφορική", Town = "Αθήνα", Hyperlink = "https://www.di.uoa.gr/cs",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Αλγόριθμοι, Λογική και Διακριτά Μαθηματικά", Town = "Αθήνα", Hyperlink = "http://alma.di.uoa.gr/",
                    
                },
                
                new PostGraduateInstitution
                {
                    Name = "Εθνικό Καποδιστριακό Πανεπιστήμιο Αθηνών", Department = "Data Science and Information Technologies", Town = "Αθήνα", Hyperlink = "https://dsit.di.uoa.gr/"
                    
                }
            );
        }
    }
}
