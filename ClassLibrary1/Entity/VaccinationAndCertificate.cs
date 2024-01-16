using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class VaccinationAndCertificate : Entity
    {
        public Guid VaccinationId { get; set; }
        public Vaccination Vaccination { get; set; }

        public Guid VaccinationCertificateId { get; set; }
        public VaccinationCertificate VaccinationCertificate { get; set; }

        public DateOnly DateVaccine { get; set; }
        public string ReactionOfVaccine { get; set; }

    }
}
