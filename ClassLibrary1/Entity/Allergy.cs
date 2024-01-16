using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class Allergy : Entity
    { 
        public int AgeOfOnset { get; set; }
        public string TypeReaction { get; set; } = null!;

        public DirectoryOfAllergy? Allergyes { get; set; }
        public Student Student { get; set; } = null!;
    }
}
