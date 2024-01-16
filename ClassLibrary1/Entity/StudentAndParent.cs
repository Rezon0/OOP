using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class StudentAndParent : Entity
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid ParentId { get; set; }
        public Parent Parent { get; set; }

        public string? Representation { get; set; }
    }
}
