namespace ClassLibrary1.Entity
{
    public class Student : User
    {
        public VaccinationCertificate? vaccinationCertificate { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public List<StudentAndParent> Students_Parents { get; } = new List<StudentAndParent>();
        public List<Parent> Parents { get; } = new List<Parent>();


        public ICollection<Allergy>? Allergies { get; set; }
        public ICollection<InformationOfHospitalization>? Hospitalizations { get; set; }
        public ICollection<PreviousIllness>? PreviousIllnesses { get; set; }

        public void Add(string Lastname, string Name, string Patronymic,
                        char Gender, DateOnly Birthday, string Phone, string Email,
                        string Login, string Password, DateOnly DateOfIssue, SchoolClass SchoolClass, DirectoryOfMedicalInstitution DirMedInst, string Privilege)
        {
            this.Lastname = Lastname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Phone = Phone;
            this.Email = Email;
            this.Login = Login;
            this.Password = Password;
            this.SchoolClass = SchoolClass;
            this.Privilege = Privilege;

            vaccinationCertificate = new VaccinationCertificate();
            vaccinationCertificate.Add(DateOfIssue, DirMedInst, Id);
        }

        public void Add_Allergy(DirectoryOfAllergy dir_allergy, int AgeOfOnset, string TypeReaction)
        {
            if (Allergies == null)
                Allergies = new List<Allergy>();

            Allergy allergy = new Allergy();
            allergy.Allergyes = dir_allergy;
            allergy.AgeOfOnset = AgeOfOnset;
            allergy.TypeReaction = TypeReaction;

            Allergies.Add(allergy);
        }

        public void Add_Previous_Illness(DirectoryOfDiagnoses dir_previous_illness, DateOnly DateBegin, DateOnly DateEnd)
        {
            if (DateBegin > DateEnd)
                return;

            if (PreviousIllnesses == null)
                PreviousIllnesses = new List<PreviousIllness>();

            PreviousIllness pi = new PreviousIllness();
            pi.DirectoryOfDiagnoses = dir_previous_illness;
            pi.DateBegin = DateBegin;
            pi.DateEnd = DateEnd;

            PreviousIllnesses.Add(pi);
        }

        public void Add_Hospitalisation(DirectoryOfDiagnoses dir_previous_illness, DirectoryOfMedicalInstitution dir_med_inst, DateOnly DateHospitalization, DateOnly DateReturn)
        {
            if (DateHospitalization > DateReturn)
                return;

            if (Hospitalizations == null)
                Hospitalizations = new List<InformationOfHospitalization>();


            InformationOfHospitalization infHosp = new InformationOfHospitalization();
            infHosp.DirectoryOfDiagnosess = dir_previous_illness;
            infHosp.DirectoryOfMedicalInstitutions = dir_med_inst;
            infHosp.DateHospitalization = DateHospitalization;
            infHosp.DateReturn = DateReturn;

            Hospitalizations.Add(infHosp);
        }     
    }
}
