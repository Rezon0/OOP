using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class InformationOfHospitalization : Entity
    {
        public DateOnly DateHospitalization { get; set; }
        public DateOnly? DateReturn { get; set; }

        public DirectoryOfDiagnoses? DirectoryOfDiagnosess { get; set; }
        public DirectoryOfMedicalInstitution? DirectoryOfMedicalInstitutions { get; set; }
        public Student Students { get; set; } = null!;
    }
}
