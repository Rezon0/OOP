namespace ClassLibrary1.Entity
{
    public class SchoolClass : Entity
    {
        public string NameClass { get; set; } = null!;
        public int Quantity_Students { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public void Add(string NameClass)
        {
            this.NameClass = NameClass;
        }
    }
}
