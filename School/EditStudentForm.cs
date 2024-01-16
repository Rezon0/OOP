using ClassLibrary1;
using ClassLibrary1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class EditStudentForm : Form
    {
        public void InsertComboBoxVaccination(KursachContext db, string classVaccination)
        {
            if (classVaccination == SelectClass.select_class_vaccinations(db, classVaccination).NameClassVaccination)
            {

                var query3 = from Vaccination in db.Vaccinations
                             join ClassVaccination in db.ClassVaccinations on Vaccination.ClassVaccination.Id equals ClassVaccination.Id
                             where ClassVaccination.NameClassVaccination == classVaccination
                             select new { Vaccination.NameVaccination };

                foreach (var item in query3)
                {
                    comboBoxVaccination.Items.Add(item.NameVaccination);
                }
                comboBoxVaccination.Text = comboBoxVaccination.Items[0].ToString();
            }
            else
            {
                MessageBox.Show("Такой класс ванкцинации не существует!");
            }
        }

        void add_vaccinationAndvaccinationCertifficate(KursachContext db, Vaccination Vaccination, VaccinationCertificate VaccinationCertificate, DateOnly DateVaccine, string ReactionOfVaccine)
        {
            VaccinationAndCertificate vac = new VaccinationAndCertificate
            {
                Vaccination = Vaccination,
                VaccinationCertificate = VaccinationCertificate,
                DateVaccine = DateVaccine,
                ReactionOfVaccine = ReactionOfVaccine
            };

            Vaccination.VaccinationAndCertificates.Add(vac);
            VaccinationCertificate.VaccinationAndCertificates.Add(vac);

            db.VaccinationCertificates.Update(VaccinationCertificate);
            db.Vaccinations.Update(Vaccination);
            db.VaccinationsAndCertificates.Add(vac);

            db.SaveChanges();

            update_vaccination_table(db);

            MessageBox.Show("Успешно!");
        }

        void add_parent(KursachContext db, string Lastname, string Name, string Patrmioc, char Gender, DateOnly Birthday, string Phone)
        {
            if (textBoxNameParent.Text == String.Empty ||
                textBoxLastnameParent.Text == String.Empty ||
                comboBoxGenderParent.Text == String.Empty ||
                dateTimePickerBirthdayParent.Text == String.Empty ||
                maskedTextBoxPhoneParent.Text == String.Empty)
            {
                MessageBox.Show("Не заполнены все обязательные поля!");
                return;
            }

            Parent parent = new Parent();

            parent.Add(Lastname, Name, Patrmioc, Gender, Birthday, Phone);

            db.Parents.Add(parent);

            db.SaveChanges();

            update_parent_table(db);

            MessageBox.Show("Успешно!");
        }

        void add_studentAndparent(KursachContext db, Student Student, Parent Parent, DirectoryOfRepresentation Representation)
        {
            if (Representation != null)
            {
                if(Parent != null)
                {
                    StudentAndParent sap = new StudentAndParent
                    {
                        Student = Student,
                        Parent = Parent,
                        Representation = Representation.NameRepresentation
                    };

                    Student.Students_Parents.Add(sap);
                    Parent.Students_Parents.Add(sap);

                    db.Students.Update(Student);
                    db.Parents.Update(Parent);
                    db.Students_Parents.Add(sap);

                    db.SaveChanges();

                    update_student_and_parent_table(db);

                    MessageBox.Show("Успешно!");
                }else
                    MessageBox.Show("Такого родителя не существует!");

            }
            else
                MessageBox.Show("Такого законного представительства не существует!");
        }

        void add_previous_illness(KursachContext db, Student student, DirectoryOfDiagnoses directoryOfDiagnoses, DateOnly DateBegin, DateOnly DateEnd)
        {
            student.Add_Previous_Illness(directoryOfDiagnoses, DateBegin, DateEnd);

            db.Students.Update(student);

            db.SaveChanges();

            update_previous_illnes_table(db);

            MessageBox.Show("Успешно!");
        }

        void add_hospitalisation(KursachContext db, Student student, DirectoryOfDiagnoses directoryOfDiagnoses, DirectoryOfMedicalInstitution directoryOfMedicalInstitution, DateOnly DateBegin, DateOnly DateEnd)
        {
            student.Add_Hospitalisation(directoryOfDiagnoses, directoryOfMedicalInstitution, DateBegin, DateEnd);

            db.Students.Update(student);

            db.SaveChanges();

            update_hospitalization_table(db);

            MessageBox.Show("Успешно!");
        }

        void add_allergy(KursachContext db, Student student, DirectoryOfAllergy DirectoryOfAllergy, int AgeBegin, string TypeReaction)
        {
            student.Add_Allergy(SelectClass.select_dir_allergy(db, DirectoryOfAllergy.NameAllergen), AgeBegin, TypeReaction);

            db.Students.Update(student);

            db.SaveChanges();

            update_allergy_table(db);

            MessageBox.Show("Успешно!");
        }

        void delete_allergy(KursachContext db, Student student, DirectoryOfAllergy DirectoryOfAllergy, int AgeBegin, string TypeReaction)
        {
            Allergy allergy = SelectClass.select_allergy(db, student, DirectoryOfAllergy, AgeBegin, TypeReaction);

            if (allergy != null)
            {
                db.Allergyes.Remove(allergy);

                db.SaveChanges();

                update_allergy_table(db);

                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void delete_hospitalisation(KursachContext db, Student student, DirectoryOfDiagnoses directoryOfDiagnoses, DirectoryOfMedicalInstitution directoryOfMedicalInstitution, DateOnly DateBegin, DateOnly DateEnd)
        {
            InformationOfHospitalization informationOfHospitalization = SelectClass.select_information_of_hospitalisation(db, student, directoryOfDiagnoses, directoryOfMedicalInstitution, DateBegin, DateEnd);

            if (informationOfHospitalization != null)
            {
                db.InformationOfHospitalizations.Remove(informationOfHospitalization);

                db.SaveChanges();

                update_hospitalization_table(db);

                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void delete_vaccinationAndvaccinationCertifficate(KursachContext db, Vaccination Vaccination, VaccinationCertificate VaccinationCertificate, DateOnly DateVaccine, string ReactionOfVaccine)
        {
            VaccinationAndCertificate vac = SelectClass.select_vaccination_and_certificate(db, Vaccination, VaccinationCertificate);

            if (vac != null)
            {
                db.VaccinationsAndCertificates.Remove(vac);

                db.SaveChanges();

                update_vaccination_table(db);

                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void delete_student(KursachContext db, Student student)
        {
            if (student != null)
            {
                SchoolClass sc;

                var query = from Student in db.Students
                            join SchoolClass in db.SchoolClasses on Student.SchoolClass.Id equals SchoolClass.Id
                            where Student.Id == student.Id
                            select new { SchoolClass.NameClass };

                if (query != null)
                {
                    sc = SelectClass.select_school_class(db, query.ToList()[0].NameClass);
                    sc.Students.Remove(student);

                    sc.Quantity_Students--;
                    db.SchoolClasses.Update(sc);
                }
                db.Students.Remove(student);

                db.SaveChanges();

                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void delete_parent(KursachContext db, Parent parent)
        {
            if (parent != null)
            {
                db.Parents.Remove(parent);
                db.SaveChanges();
                update_student_and_parent_table(db);
                update_parent_table(db);
                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void delete_previous_illnes(KursachContext db, Student student, string NamePI, DateOnly DateBegin, DateOnly DateEnd)
        {
            PreviousIllness previousIllness = SelectClass.select_revious_illness(db, student, SelectClass.select_dir_diagnoses(db, NamePI), DateBegin, DateEnd);

            if (previousIllness != null)
            {
                db.PreviousIllnesses.Remove(previousIllness);

                db.SaveChanges();

                update_previous_illnes_table(db);

                MessageBox.Show("Успешно!");
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        void update_vaccination_table(KursachContext db)
        {
                var query = from Student in db.Students
                            join VaccinationCertificate in db.VaccinationCertificates on Student.Id equals VaccinationCertificate.ID_Student
                            join VaccinationAndCertificate in db.VaccinationsAndCertificates on VaccinationCertificate.Id equals VaccinationAndCertificate.VaccinationCertificateId
                            join Vaccination in db.Vaccinations on VaccinationAndCertificate.VaccinationId equals Vaccination.Id
                            where Student.Id == Guid.Parse(comboBoxStudentId.Text)

                            select new
                            {
                                Фамилия = Student.Lastname,
                                Имя = Student.Name,
                                Отчество = Student.Patronymic,
                                Прививка = Vaccination.NameVaccination,
                                Дата_вакцинации = VaccinationAndCertificate.DateVaccine,
                                Реакция = VaccinationAndCertificate.ReactionOfVaccine
                            };


                dataGridViewVaccination.DataSource = query.ToList();
        }

        void update_allergy_table(KursachContext db)
        {
            var query = from Student in db.Students
                        join Allergy in db.Allergyes on Student.Id equals Allergy.Student.Id
                        join DirectoryOfAllergy in db.DirectoryOfAllergys on Allergy.Allergyes.Id equals DirectoryOfAllergy.Id
                        where Student.Id == Guid.Parse(comboBoxStudentId.Text)

                        select new
                        {
                            Фамилия = Student.Lastname,
                            Имя = Student.Name,
                            Отчество = Student.Patronymic,
                            Аллергия = DirectoryOfAllergy.NameAllergen,
                            Возраст_начала = Allergy.AgeOfOnset,
                            Реакция = Allergy.TypeReaction
                        };


            dataGridViewAllergy.DataSource = query.ToList();
        }

        void update_hospitalization_table(KursachContext db)
        {
            var query = from Student in db.Students
                        join Hospitalization in db.InformationOfHospitalizations on Student.Id equals Hospitalization.Students.Id
                        join DirectoryOfDiagnoses in db.DirectoryOfDiagnoseses on Hospitalization.DirectoryOfDiagnosess.Id equals DirectoryOfDiagnoses.Id
                        join DirectoryOfMedicalInstitution in db.DirectoryOfMedicalInstitutions on Hospitalization.DirectoryOfMedicalInstitutions.Id equals DirectoryOfMedicalInstitution.Id
                        where Student.Id == Guid.Parse(comboBoxStudentId.Text)

                        select new
                        {
                            Фамилия = Student.Lastname,
                            Имя = Student.Name,
                            Отчество = Student.Patronymic,
                            Дата_госпитализации = Hospitalization.DateHospitalization,
                            Дата_выписки = Hospitalization.DateReturn,
                            Диагноз = DirectoryOfDiagnoses.NameDiagnoses,
                            Мед_учреждение = DirectoryOfMedicalInstitution.NameMedInst
                        };


            dataGridViewHospitalization.DataSource = query.ToList();
        }

        void update_previous_illnes_table(KursachContext db)
        {
            var query = from Student in db.Students
                        join PI in db.PreviousIllnesses on Student.Id equals PI.Student.Id
                        join DirectoryOfDiagnoses in db.DirectoryOfDiagnoseses on PI.DirectoryOfDiagnoses.Id equals DirectoryOfDiagnoses.Id
                        where Student.Id == Guid.Parse(comboBoxStudentId.Text)

                        select new
                        {
                            Фамилия = Student.Lastname,
                            Имя = Student.Name,
                            Отчество = Student.Patronymic,
                            Дата_заболевания = PI.DateBegin,
                            Дата_выздоровления = PI.DateEnd,
                            Диагноз = DirectoryOfDiagnoses.NameDiagnoses
                        };

            dataGridViewPreviousIllness.DataSource = query.ToList();
        }

        void update_student_and_parent_table(KursachContext db)
        {
            var query = from Student in db.Students
                        join StudentAndParent in db.Students_Parents on Student.Id equals StudentAndParent.Student.Id
                        join Parent in db.Parents on StudentAndParent.Parent.Id equals Parent.Id
                        where Student.Id == Guid.Parse(comboBoxStudentId.Text)

                        select new
                        {
                            ID_школьника = Student.Id,
                            Фамилия_родителя = Parent.Lastname,
                            Имя_родителя = Parent.Name,
                            Отчество_родителя = Parent.Patronymic
                        };
            // НЕ СМОГ ОДНОВРЕМЕННО ФИО ОБОИХ ВЫВЕСТИ

            dataGridViewStudentAndParent.DataSource = query.ToList();
        }

        void update_parent_table(KursachContext db)
        {
            var query = from Parent in db.Parents

                        select new
                        {
                            Фамилия = Parent.Lastname,
                            Имя = Parent.Name,
                            Отчество = Parent.Patronymic,
                            Пол = Parent.Gender,
                            Дата_рождения = Parent.Birthday
                        };

            dataGridViewParents.DataSource = query.ToList();
        }

        void update_vaccinationAndvaccinationCertifficate(KursachContext db, Vaccination Vaccination, VaccinationCertificate VaccinationCertificate)
        {
            if (DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
            {
                MessageBox.Show("Дата вакцинации не может быть меньше даты рождения!");
                return;
            }

            VaccinationAndCertificate vac = SelectClass.select_VAC(db, VaccinationCertificate, Vaccination);

            if(vac != null)
            {
                vac.DateVaccine = DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString());
                vac.ReactionOfVaccine = textBoxTypeOfReactionVaccine.Text;
                db.VaccinationsAndCertificates.Update(vac);
                db.SaveChanges();

                update_vaccination_table(db);

                MessageBox.Show("Успешно!");
            }
            else
            {
                MessageBox.Show("Данная прививка еще не добавлена!");
            }
        }

        public EditStudentForm()
            {
                InitializeComponent();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        var schoolClass = SelectClass.select_school_class(db, comboBoxSchoolClass.Text);
                        if (schoolClass == null)
                        {
                            MessageBox.Show("Такого класса не существует!");
                            return;
                        }

                        comboBoxStudentId.Items.Clear();
                        comboBoxStudentId.Text = "";

                        var query = from Student in db.Students
                                    join SchoolClass in db.SchoolClasses on Student.SchoolClass.Id equals SchoolClass.Id
                                    where SchoolClass.NameClass.Contains(comboBoxSchoolClass.Text)
                                    && Student.Name.Contains(textBoxName.Text)
                                    && Student.Lastname.Contains(textBoxLastname.Text)
                                    && (Student.Patronymic.Contains(textBoxPatronymic.Text) || Student.Patronymic.Contains(null))
                                    select new { 
                                        Класс = SchoolClass.NameClass, 
                                        ID_школьника = Student.Id,
                                        Фамилия = Student.Lastname,
                                        Имя = Student.Name, 
                                        Отчество = Student.Patronymic, 
                                        Дата_рождения = Student.Birthday };

                        dataGridViewStudents.DataSource = query.ToList();

                        foreach (var item in query)
                        {
                            comboBoxStudentId.Items.Add(item.ID_школьника);
                        }

                        if (comboBoxStudentId.Items.Count != 0)
                            comboBoxStudentId.Text = comboBoxStudentId.Items[0].ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }

            private void button10_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    button10.Enabled = false;
                    if (SelectClass.CheckStudent(db, comboBoxStudentId.Text) == true)
                    {
                        tabControl1.Enabled = true;
                        tabControlParent.Enabled = true;
                        update_allergy_table(db);
                        update_vaccination_table(db);
                        update_hospitalization_table(db);
                        update_parent_table(db);
                        update_previous_illnes_table(db);
                        update_student_and_parent_table(db);
                }
                    else
                    {
                        MessageBox.Show("Такого школьника не существует!");
                    }
                }
                button10.Enabled = true;
        }

            private void EditStudentForm_Load(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    var query1 = from SchoolClass in db.SchoolClasses
                                 orderby SchoolClass.NameClass
                                 select new { SchoolClass.NameClass };


                    foreach (var item in query1)
                    {
                        comboBoxSchoolClass.Items.Add(item.NameClass);
                    }


                    var query2 = from ClassVaccination in db.ClassVaccinations
                                 orderby ClassVaccination.NameClassVaccination
                                 select new { ClassVaccination.NameClassVaccination };


                    foreach (var item in query2)
                    {
                        comboBoxClassVaccination.Items.Add(item.NameClassVaccination);
                    }
                    comboBoxClassVaccination.Text = comboBoxClassVaccination.Items[0].ToString();



                    var query3 = from DirectoryOfDiagnoses in db.DirectoryOfDiagnoseses
                                 orderby DirectoryOfDiagnoses.NameDiagnoses
                                 select new { DirectoryOfDiagnoses.NameDiagnoses };


                    foreach (var item in query3)
                    {
                        comboBoxDiagnosesPreviousIllness.Items.Add(item.NameDiagnoses);
                        comboBoxDiagnosesHospitalisations.Items.Add(item.NameDiagnoses);
                    }
                    comboBoxDiagnosesPreviousIllness.Text = comboBoxDiagnosesPreviousIllness.Items[0].ToString();
                    comboBoxDiagnosesHospitalisations.Text = comboBoxDiagnosesHospitalisations.Items[0].ToString();


                    var query4 = from DirectoryOfMedicalInstitution in db.DirectoryOfMedicalInstitutions
                                 orderby DirectoryOfMedicalInstitution.NameMedInst
                                 select new { DirectoryOfMedicalInstitution.NameMedInst };


                    foreach (var item in query4)
                    {
                        comboBoxMedicalInstitutionHospitalisation.Items.Add(item.NameMedInst);
                    }
                    comboBoxMedicalInstitutionHospitalisation.Text = comboBoxMedicalInstitutionHospitalisation.Items[0].ToString();



                    var query5 = from DirectoryOfAllergy in db.DirectoryOfAllergys
                                 orderby DirectoryOfAllergy.NameAllergen
                                 select new { DirectoryOfAllergy.NameAllergen };


                    foreach (var item in query5)
                    {
                        comboBoxAllergy.Items.Add(item.NameAllergen);
                    }
                    comboBoxAllergy.Text = comboBoxAllergy.Items[0].ToString();


                    var query6 = from DirectoryOfRepresentation in db.DirectoryOfRepresentations
                                 orderby DirectoryOfRepresentation.NameRepresentation
                                 select new { DirectoryOfRepresentation.NameRepresentation };


                    foreach (var item in query6)
                    {
                        comboBoxRepresentationsParent.Items.Add(item.NameRepresentation);
                    }
                    comboBoxRepresentationsParent.Text = comboBoxRepresentationsParent.Items[0].ToString();
                }


                tabControlParent.Enabled = false;
                tabControl1.Enabled = false;
            }

            private void button6_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    if (SelectClass.select_dir_allergy(db, comboBoxAllergy.Text) == null)
                    {
                        MessageBox.Show("Такой аллергии не существует!");
                        return;
                    }

                    if (numericUpDownAgeBegin.Text == String.Empty || textBoxTypeOfReactionAllergy.Text == String.Empty)
                    {
                        MessageBox.Show("Не заполнены все обязательные поля!");
                        return;
                    }

                    add_allergy(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                             SelectClass.select_dir_allergy(db, comboBoxAllergy.Text),
                                             int.Parse(numericUpDownAgeBegin.Text),
                                             textBoxTypeOfReactionAllergy.Text);
                }
            }

            private void button8_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        if (DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата вакцинации не может быть меньше даты рождения!");
                            return;
                        }

                        if (SelectClass.select_class_vaccinations(db, comboBoxClassVaccination.Text) == null)
                        {
                            MessageBox.Show("Такого класса прививок не существует!");
                            return;
                        }

                        if (SelectClass.select_vaccinations(db, comboBoxVaccination.Text) == null)
                        {
                            MessageBox.Show("Такой прививки не существует!");
                            return;
                        }

                        add_vaccinationAndvaccinationCertifficate(
                            db,
                            SelectClass.select_vaccinations(db, comboBoxVaccination.Text),
                            SelectClass.select_vaccination_certificate(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Id),
                            DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString()),
                            textBoxTypeOfReactionVaccine.Text
                            );
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }

            private void comboBoxStudentId_TextChanged(object sender, EventArgs e)
            {
                tabControl1.Enabled = false;
                tabControlParent.Enabled = false;
            }

            private void comboBoxClassVaccination_SelectedIndexChanged(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    comboBoxVaccination.Items.Clear();
                    InsertComboBoxVaccination(db, comboBoxClassVaccination.Text);

                    if (comboBoxClassVaccination.Text == "Профилактическая прививка (делается один раз)")
                    {
                        button8.Enabled = false;
                        button9.Enabled = false;
                }
                    else
                    {
                        button8.Enabled = true;
                        button9.Enabled = true;
                    }
                }
            }

            private void button9_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {

                        if (DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата вакцинации не может быть меньше даты рождения!");
                            return;
                        }

                        if (SelectClass.select_class_vaccinations(db, comboBoxClassVaccination.Text) == null)
                        {
                            MessageBox.Show("Такого класса прививок не существует!");
                            return;
                        }

                        if (SelectClass.select_vaccinations(db, comboBoxVaccination.Text) == null)
                        {
                            MessageBox.Show("Такой прививки не существует!");
                            return;
                        }

                        delete_vaccinationAndvaccinationCertifficate(
                            db,
                            SelectClass.select_vaccinations(db, comboBoxVaccination.Text),
                            SelectClass.select_vaccination_certificate(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Id),
                            DateOnly.Parse(dateTimePickerDateVaccine.Value.ToLongDateString()),
                            textBoxTypeOfReactionVaccine.Text
                            );
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }

            private void button7_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        if (DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата заболевания не может быть меньше даты рождения!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата выздоровления не может быть меньше даты рождения!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()) > DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()))
                        {
                            MessageBox.Show("Дата заболевания не может быть меньше даты выздоровления!");
                            return;
                        }

                        if (SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesPreviousIllness.Text) == null)
                        {
                            MessageBox.Show("Такого диагноза не существует!");
                            return;
                        }

                        add_previous_illness(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                                 SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesPreviousIllness.Text),
                                                 DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()),
                                                 DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }

            }

            private void button1_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        if (DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата заболевания не может быть меньше даты рождения!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата выздоровления не может быть меньше даты рождения!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()) > DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()))
                        {
                            MessageBox.Show("Дата заболевания не может быть меньше даты выздоровления!");
                            return;
                        }

                        if (SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesPreviousIllness.Text) == null)
                        {
                            MessageBox.Show("Такого диагноза не существует!");
                            return;
                        }

                        delete_previous_illnes(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                                 comboBoxDiagnosesPreviousIllness.Text,
                                                 DateOnly.Parse(dateTimePickerPIDateBegin.Value.ToLongDateString()),
                                                 DateOnly.Parse(dateTimePickerPIDateEnd.Value.ToLongDateString()));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        if (DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата госпитализации не может быть меньше даты рождения!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()) < SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Birthday)
                        {
                            MessageBox.Show("Дата выписки не может быть меньше даты рождения!");
                            return;
                        }

                        if (SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesHospitalisations.Text) == null)
                        {
                            MessageBox.Show("Такого диагноза не существует!");
                            return;
                        }

                        if (SelectClass.select_dir_med_inst(db, comboBoxMedicalInstitutionHospitalisation.Text) == null)
                        {
                            MessageBox.Show("Такого медучреждения не существует!");
                            return;
                        }

                        if (dateTimePickerHospitalisationDateBegin.Text == String.Empty || dateTimePickerHospitalisationDateEnd.Text == String.Empty)
                        {
                            MessageBox.Show("Не заполнены все обязательные поля!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerHospitalisationDateEnd.Value.ToLongDateString()) < DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()))
                        {
                            MessageBox.Show("Дата госпитализации не может быть меньше даты выписки!");
                            return;
                        }

                        add_hospitalisation(db,
                                            SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                            SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesHospitalisations.Text),
                                            SelectClass.select_dir_med_inst(db, comboBoxMedicalInstitutionHospitalisation.Text),
                                            DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()),
                                            DateOnly.Parse(dateTimePickerHospitalisationDateEnd.Value.ToLongDateString()));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }

            }

            private void button3_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    try
                    {
                        if (SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesHospitalisations.Text) == null)
                        {
                            MessageBox.Show("Такого диагноза не существует!");
                            return;
                        }

                        if (SelectClass.select_dir_med_inst(db, comboBoxMedicalInstitutionHospitalisation.Text) == null)
                        {
                            MessageBox.Show("Такого медучреждения не существует!");
                            return;
                        }

                        if (dateTimePickerHospitalisationDateBegin.Text == String.Empty || dateTimePickerHospitalisationDateEnd.Text == String.Empty)
                        {
                            MessageBox.Show("Не заполнены все обязательные поля!");
                            return;
                        }

                        if (DateOnly.Parse(dateTimePickerHospitalisationDateEnd.Value.ToLongDateString()) < DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()))
                        {
                            MessageBox.Show("Дата госпитализации не может быть меньше даты выписки!");
                            return;
                        }

                        delete_hospitalisation(db,
                                            SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                            SelectClass.select_dir_diagnoses(db, comboBoxDiagnosesHospitalisations.Text),
                                            SelectClass.select_dir_med_inst(db, comboBoxMedicalInstitutionHospitalisation.Text),
                                            DateOnly.Parse(dateTimePickerHospitalisationDateBegin.Value.ToLongDateString()),
                                            DateOnly.Parse(dateTimePickerHospitalisationDateEnd.Value.ToLongDateString()));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    if (SelectClass.select_dir_allergy(db, comboBoxAllergy.Text) == null)
                    {
                        MessageBox.Show("Такой аллергии не существует!");
                        return;
                    }

                    if (numericUpDownAgeBegin.Text == String.Empty || textBoxTypeOfReactionAllergy.Text == String.Empty)
                    {
                        MessageBox.Show("Не заполнены все обязательные поля!");
                        return;
                    }

                    delete_allergy(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                             SelectClass.select_dir_allergy(db, comboBoxAllergy.Text),
                                             int.Parse(numericUpDownAgeBegin.Text),
                                             textBoxTypeOfReactionAllergy.Text);
                }
            }

            private void button11_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    delete_student(db, SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)));

                    button4_Click(null, null);
                }
            }

            private void button13_Click(object sender, EventArgs e)
            {
                if (comboBoxGenderParent.Text == "М" || comboBoxGenderParent.Text == "Ж")
                {
                    using (KursachContext db = new())
                    {
                        add_parent(db, textBoxLastnameParent.Text, textBoxNameParent.Text, textBoxPatronymicParent.Text, Char.Parse(comboBoxGenderParent.Text), DateOnly.Parse(dateTimePickerBirthdayParent.Value.ToLongDateString()), maskedTextBoxPhoneParent.Text);
                    }
                }
                else
                    MessageBox.Show("Такой логин уже существует!");
            }

            private void button14_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    add_studentAndparent(db,
                                      SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)),
                                      SelectClass.select_parents(db, textBoxLastnameParent.Text, textBoxNameParent.Text, textBoxPatronymicParent.Text, DateOnly.Parse(dateTimePickerBirthdayParent.Value.ToLongDateString()), maskedTextBoxPhoneParent.Text),
                                      SelectClass.select_dir_representation(db, comboBoxRepresentationsParent.Text));
                }
            }

            private void button12_Click(object sender, EventArgs e)
            {
                using (KursachContext db = new())
                {
                    delete_parent(db, SelectClass.select_parents(db, textBoxLastnameParent.Text, textBoxNameParent.Text, textBoxPatronymicParent.Text, DateOnly.Parse(dateTimePickerBirthdayParent.Value.ToLongDateString()), maskedTextBoxPhoneParent.Text));
                }

            }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_allergy_table(db);
            }
        }

        private void tabPage10_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_vaccination_table(db);
            } 
        }

        private void tabPage12_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_hospitalization_table(db);
            }
        }

        private void tabPage9_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_previous_illnes_table(db);
            }
        }

        private void tabPage11_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_student_and_parent_table(db);
            }
        }

        private void tabPage13_Enter(object sender, EventArgs e)
        {
            using(KursachContext db = new())
            {
                update_parent_table(db);
            }
        }

        private void comboBoxSchoolClass_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxAllergy_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxDiagnosesHospitalisations_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxMedicalInstitutionHospitalisation_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxDiagnosesPreviousIllness_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxClassVaccination_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxVaccination_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxRepresentationsParent_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxGenderParent_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                update_vaccinationAndvaccinationCertifficate(db, SelectClass.select_vaccinations(db, comboBoxVaccination.Text),
                                                                 SelectClass.select_vaccination_certificate(db, 
                                                                 SelectClass.select_students(db, Guid.Parse(comboBoxStudentId.Text)).Id));
            }
        }

        private void comboBoxStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
