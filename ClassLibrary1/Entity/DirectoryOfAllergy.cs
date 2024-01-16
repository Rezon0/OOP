namespace ClassLibrary1.Entity
{
    public class DirectoryOfAllergy : AbstractDirectory
    {
        public string NameAllergen { get; set; } = null!;

        public ICollection<Allergy> Allergies { get; set; } = null!;

        public override void Add(string NameAllergen)
        {
            this.NameAllergen = NameAllergen;
        }
    }
}
