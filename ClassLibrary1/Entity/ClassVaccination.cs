namespace ClassLibrary1.Entity
{
    public class ClassVaccination : AbstractDirectory
    {
        public string NameClassVaccination { get; set; } = null!;

        public ICollection<Vaccination> Vaccination { get; set; } = null!;

        public override void Add(string NameClassVaccination)
        {
            this.NameClassVaccination = NameClassVaccination;
        }
    }
}
