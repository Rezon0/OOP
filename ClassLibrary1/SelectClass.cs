using ClassLibrary1.Entity;

namespace ClassLibrary1
{
    public class SelectClass
    {
        // ВЫБОРКА В СПИСКЕ ДОЛЖНОСТЕЙ
        public static Post select_post(KursachContext db, string NamePost)
        {
            var SelectPostes = db.Postes
                .Where(b => b.NamePost == NamePost)
                .FirstOrDefault();

            return SelectPostes;
        }

        // ВЫБОРКА В СПИСКЕ КЛАССА ПРИВИВОК
        public static ClassVaccination select_class_vaccinations(KursachContext db, string NameClassVaccination)
        {
            var SelectClassVaccinations = db.ClassVaccinations
                .Where(b => b.NameClassVaccination == NameClassVaccination)
                .FirstOrDefault();

            return SelectClassVaccinations;
        }

        // ВЫБОРКА В СПИСКЕ ПРИВИВОК
        public static Vaccination select_vaccinations(KursachContext db, string NameNameVaccination)
        {
            var SelectVaccinations = db.Vaccinations
                .Where(b => b.NameVaccination == NameNameVaccination)
                .FirstOrDefault();

            return SelectVaccinations;
        }

        public static List<Vaccination> select_vaccinations_list(KursachContext db, string NameClassVaccination)
        {
            var SelectVaccinations = db.Vaccinations
                .Where(b => b.ClassVaccination.NameClassVaccination == NameClassVaccination)
                .ToList();

            return SelectVaccinations;
        }

        // ВЫБОРКА В СПИСКЕ УЧЕБНЫХ КЛАССОВ
        public static SchoolClass select_school_class(KursachContext db, string NameClass)
        {
            var SelectSchoolClasses = db.SchoolClasses
                .Where(b => b.NameClass == NameClass)
                .FirstOrDefault();

            return SelectSchoolClasses;
        }

        public static SchoolClass select_school_class(KursachContext db, Student student)
        {
            var SelectSchoolClasses = db.SchoolClasses
                .Where(b => b.Id == student.SchoolClass.Id)
                .FirstOrDefault();

            return SelectSchoolClasses;
        }

        // ВЫБОРКА В СПИСКЕ МЕДУЧРЕЖДЕНИЙ
        public static DirectoryOfMedicalInstitution select_dir_med_inst(KursachContext db, string NameMedInst)
        {
            var SelectDirMedInst = db.DirectoryOfMedicalInstitutions
                .Where(b => b.NameMedInst == NameMedInst)
                .FirstOrDefault();


            return SelectDirMedInst;
        }

        // ВЫБОРКА В СПИСКЕ АЛЛЕРГИЙ
        public static DirectoryOfAllergy select_dir_allergy(KursachContext db, string NameAllergen)
        {
            var SelectDirAllergyes = db.DirectoryOfAllergys
                .Where(b => b.NameAllergen == NameAllergen)
                .FirstOrDefault();

            return SelectDirAllergyes;
        }

        // ВЫБОРКА В СПИСКЕ ЗАКОННОГО ПРЕДСТАВИТЕЛЯ
        public static DirectoryOfRepresentation select_dir_representation(KursachContext db, string NameRepresentation)
        {
            var SelectDirRepresentation = db.DirectoryOfRepresentations
                .Where(b => b.NameRepresentation == NameRepresentation)
                .FirstOrDefault();

            return SelectDirRepresentation;
        }

        // ВЫБОРКА ШКОЛЬНИКОВ
        public static Student select_students(KursachContext db, string LastName, string Name, string Patronymic, DateOnly Birthday)
        {
            var SelectStudent = db.Students
                .Where(b => b.Name == Name && b.Lastname == LastName && b.Patronymic == Patronymic && b.Birthday == Birthday)
                .FirstOrDefault();

            return SelectStudent;
        }

        public static Student select_students(KursachContext db, Guid Id)
        {
            var SelectStudent = db.Students
                .Where(b => b.Id == Id)
                .FirstOrDefault();

            return SelectStudent;
        }

        public static Student select_students(KursachContext db, string Login)
        {
            var SelectStudent = db.Students
                .Where(b => b.Login == Login)
                .FirstOrDefault();

            return SelectStudent;
        }

        // ВЫБОРКА МЕДСЕСТЕР
        public static Nurse select_nurses(KursachContext db, string LastName, string Name, string Patronymic, DateOnly Birthday)
        {
            var SelectNurse = db.Nurses
                .Where(b => b.Name == Name && b.Lastname == LastName && b.Patronymic == Patronymic && b.Birthday == Birthday)
                .FirstOrDefault();

            return SelectNurse;
        }

        // ВЫБОРКА СРЕДИ USER
        public static User select_users(KursachContext db, string Login)
        {
            var SelectNurses = db.Nurses
                .Where(b => b.Login == Login)
                .FirstOrDefault();

            if(SelectNurses != null)
                return SelectNurses;

            var SelectStudents = db.Students
                .Where(b => b.Login == Login)
                .FirstOrDefault();

            if (SelectStudents != null)
                return SelectStudents;

            return null;
        }

        // ВЫБОРКА В СПИСКЕ РОДИТЕЛЕЙ
        public static Parent select_parents(KursachContext db, string LastName, string Name, string Patronymic, DateOnly Birthday, string Phone)
        {
            var SelectParent = db.Parents
                .Where(b => b.Name == Name && b.Lastname == LastName && b.Patronymic == Patronymic && b.Birthday == Birthday && b.Phone == Phone)
                .FirstOrDefault();

            return SelectParent;
        }

        // ВЫБОРКА В СПИСКЕ ДИАГНОЗОВ
        public static DirectoryOfDiagnoses select_dir_diagnoses(KursachContext db, string NameDiagnoses)
        {
            var SelectDirDiagnoses = db.DirectoryOfDiagnoseses
                .Where(b => b.NameDiagnoses == NameDiagnoses)
                .FirstOrDefault();

            return SelectDirDiagnoses;
        }


        // ВЫБОРКА ПРИВИВОЧНЫХ СЕРТИФИКАТОВ
        public static VaccinationCertificate select_vaccination_certificate(KursachContext db, Guid ID_Student)
        {
            var selectVC = db.VaccinationCertificates
                .Where(b => b.ID_Student == ID_Student)
                .FirstOrDefault();
            return selectVC;
        }

        // ВЫБОРКА ПРИВИВОЧНЫХ СЕРТИФИКАТОВ - ПРИВИВОК
        public static VaccinationAndCertificate select_vaccination_and_certificate(KursachContext db, Vaccination vaccination, VaccinationCertificate vaccinationCertificate)
        {
            var selectVAC = db.VaccinationsAndCertificates
                .Where(b => b.VaccinationId == vaccination.Id && b.VaccinationCertificateId == vaccinationCertificate.Id)
                .FirstOrDefault();
            return selectVAC;
        }

        // ВЫБОРКА ПЕРЕНЕСЕННЫХ ЗАБОЛЕВАНИЙ
        public static PreviousIllness select_revious_illness(KursachContext db, Student student, DirectoryOfDiagnoses DirectoryOfDiagnoses, DateOnly DateBegin, DateOnly DateEnd)
        {
            var selectPI = db.PreviousIllnesses
                .Where(b => b.DateBegin == DateBegin && b.DateEnd == DateEnd && b.DirectoryOfDiagnoses.Id == DirectoryOfDiagnoses.Id && b.Student == student)
                .FirstOrDefault();
            return selectPI;
        }

        // ВЫБОРКА ГОСПИТАЛИЗАЦИЙ
        public static InformationOfHospitalization select_information_of_hospitalisation(KursachContext db, Student student, DirectoryOfDiagnoses directoryOfDiagnoses, DirectoryOfMedicalInstitution directoryOfMedicalInstitution, DateOnly DateBegin, DateOnly DateEnd)
        {
            var selectIoH = db.InformationOfHospitalizations
                .Where(b => b.Students == student && b.DirectoryOfDiagnosess == directoryOfDiagnoses && b.DirectoryOfMedicalInstitutions == directoryOfMedicalInstitution && b.DateHospitalization == DateBegin && b.DateReturn == DateEnd)
                .FirstOrDefault();
            return selectIoH;
        }

        // ВЫБОРКА АЛЛЕРГИЙ
        public static Allergy select_allergy(KursachContext db, Student student, DirectoryOfAllergy DirectoryOfAllergy, int AgeBegin, string TypeReaction)
        {
            var selectAllergy = db.Allergyes
                .Where(b => b.Student == student && b.Allergyes == DirectoryOfAllergy && b.AgeOfOnset == AgeBegin && b.TypeReaction == TypeReaction)
                .FirstOrDefault();
            return selectAllergy;
        }

        public static Allergy select_allergy(KursachContext db, Student student)
        {
            var selectAllergy = db.Allergyes
                .Where(b => b.Student == student)
                .FirstOrDefault();
            return selectAllergy;
        }

        // ВЫБОРКА СРЕДИ VaccinationAndCertificate
        public static VaccinationAndCertificate select_VAC(KursachContext db, VaccinationCertificate vc, Vaccination v)
        {
            var selectAllergy = db.VaccinationsAndCertificates
                .Where(b => b.VaccinationCertificateId == vc.Id && b.VaccinationId == v.Id)
                .FirstOrDefault();
            return selectAllergy;
        }


        public static bool FindLogin(KursachContext db, string Login)
        {
            var selectLoginStudent = db.Students
                .Where(b => b.Login == Login)
                .FirstOrDefault();

            var selectLoginNurse = db.Nurses
                .Where(b => b.Login == Login)
                .FirstOrDefault();

            if (selectLoginStudent == null && selectLoginNurse == null)
                return true;
            else
                return false;
        }

        public static bool CheckStudent(KursachContext db, string IdStudent)
        {
            try
            {
                if (select_students(db, Guid.Parse(IdStudent)) != null)
                    return true;
                else
                    return false;
            } catch (System.FormatException)
            {
                return false;
            }
        }
    }
}
