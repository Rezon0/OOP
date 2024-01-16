using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Entity;

namespace ClassLibrary1
{
    public class KursachContext : DbContext
    {
        private string password = "123";

        public string getPassword()
        {
            return password;
        }

        // объявляем сеты

        public DbSet<Parent> Parents { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<DirectoryOfMedicalInstitution> DirectoryOfMedicalInstitutions { get; set; }
        public DbSet<DirectoryOfAllergy> DirectoryOfAllergys { get; set; }
        public DbSet<DirectoryOfDiagnoses> DirectoryOfDiagnoseses { get; set; }
        public DbSet<ClassVaccination> ClassVaccinations { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<VaccinationCertificate> VaccinationCertificates { get; set; }
        public DbSet<VaccinationAndCertificate> VaccinationsAndCertificates { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAndParent> Students_Parents { get; set; }
        public DbSet<Allergy> Allergyes { get; set; }
        public DbSet<InformationOfHospitalization> InformationOfHospitalizations { get; set; }
        public DbSet<PreviousIllness> PreviousIllnesses { get; set; }

        public DbSet<DirectoryOfRepresentation> DirectoryOfRepresentations { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Post> Postes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // подключаемся к бд
            options.UseNpgsql($"Host=localhost; Database=kursach_oop; Username=postgres; Password={getPassword()}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
            .HasOne(e => e.vaccinationCertificate)
            .WithOne(e => e.student)
            .HasForeignKey<VaccinationCertificate>(e => e.ID_Student)
            .IsRequired();
        }
    }
}
