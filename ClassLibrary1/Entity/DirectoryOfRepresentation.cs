using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class DirectoryOfRepresentation : AbstractDirectory
    {
        public string NameRepresentation { get; set; } = null!;

        //public ICollection<Student_Parent> Student_Parents { get; set; } = null!;

        public override void Add(string NameRepresentation)
        {
            this.NameRepresentation = NameRepresentation;
        }
    }
}
