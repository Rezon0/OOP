using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class PreviousIllness : Entity
    {
        public DateOnly DateBegin { get; set; }
        public DateOnly? DateEnd { get; set; }

        public Student Student { get; set; } = null!;
        public DirectoryOfDiagnoses DirectoryOfDiagnoses { get; set; } = null!;
    }
}
