using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class DirectoryOfMedicalInstitution : Entity
    {
        public string NameMedInst { get; set; } = null!;
        public string AddressMedInst { get; set; } = null!;

        public ICollection<InformationOfHospitalization> InformationOfHospitalizations { get; set; } = null!;
        public ICollection<VaccinationCertificate> VaccinationCertificates { get; set; } = null!;

        public void Add(string NameMedInst, string AddressMedInst)
        {
            this.NameMedInst = NameMedInst;
            this.AddressMedInst = AddressMedInst;
        }
    }
}
