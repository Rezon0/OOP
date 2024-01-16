namespace ClassLibrary1.Entity
{
    public class Vaccination : Entity
    {
        public string NameVaccination { get; set; } = null!;

        public TimeSpan? IntervalVaccination { get; set; }

        public List<VaccinationAndCertificate> VaccinationAndCertificates { get; set; } = new List<VaccinationAndCertificate>();

        public ClassVaccination? ClassVaccination { get; set; }

        public void Add(ClassVaccination ClassVaccination, string NameVaccination, TimeSpan IntervalVaccination)
        {
            this.NameVaccination = NameVaccination;
            this.IntervalVaccination = IntervalVaccination;
            this.ClassVaccination = ClassVaccination;
        }
    }
}
