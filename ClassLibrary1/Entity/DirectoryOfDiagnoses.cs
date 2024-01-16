using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class DirectoryOfDiagnoses : AbstractDirectory
    {
        public string NameDiagnoses { get; set; } = null!;

        public ICollection<InformationOfHospitalization> InformationOfHospitalizations { get; set; } = null!;
        public ICollection<PreviousIllness> PreviousIllnesses { get; set; } = null!;

        public override void Add(string NameDiagnoses)
        {
            this.NameDiagnoses = NameDiagnoses;
        }
    }
}
