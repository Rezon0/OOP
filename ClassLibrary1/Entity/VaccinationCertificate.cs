namespace ClassLibrary1.Entity
{
    public class VaccinationCertificate : Entity
    {
        public Guid ID_Student { get; set; }

        public Student student { get; set; } = null!;

        public DateOnly DateOfIssue { get; set; }

        public DirectoryOfMedicalInstitution? DirectoryOfMedicalInstitution { get; set; }

        public List<VaccinationAndCertificate> VaccinationAndCertificates { get; set; } = new List<VaccinationAndCertificate>();

        public void Add(DateOnly DateOfIssue, DirectoryOfMedicalInstitution DirMedInst, Guid ID_Student)
        {
            this.DateOfIssue = DateOfIssue;
            this.ID_Student = ID_Student;
            DirectoryOfMedicalInstitution = DirMedInst;
        }
    }
}
