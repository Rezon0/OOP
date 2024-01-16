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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text == String.Empty ||
                textBoxLastname.Text == String.Empty ||
                textBoxLogin.Text == String.Empty ||
                textBoxPassword.Text == String.Empty ||
                comboBoxGender.Text == String.Empty ||
                textBoxEmail.Text == String.Empty ||
                comboBoxSchoolClass.Text == String.Empty ||
                comboBoxMedInstitute.Text == String.Empty ||
                dateTimePickerBirthday.Text == String.Empty ||
                maskedTextBoxPhone.Text == String.Empty)
                {
                    MessageBox.Show("Не заполнены все обязательные поля!");
                    return;
                }

                if (DateOnly.Parse(dateTimePickerBirthday.Value.ToLongDateString()) > DateOnly.Parse(dateTimePickerDateVaccinationCertifficate.Value.ToLongDateString()))
                {
                    MessageBox.Show("Дата рождения не может быть меньше даты выдачи прививочного сертификата!");
                    return;
                }

                if (textBoxPassword.Text.Length < 8)
                {
                    MessageBox.Show("Придумайте пароль длиной не менее 8 символов!");
                    return;
                }

                if (comboBoxGender.Text == "М" || comboBoxGender.Text == "Ж")
                {
                    using (KursachContext db = new())
                    {
                        if (SelectClass.FindLogin(db, textBoxLogin.Text) == true)
                        {
                            var schoolClass = SelectClass.select_school_class(db, comboBoxSchoolClass.Text);
                            if (schoolClass == null)
                            {
                                MessageBox.Show("Такого класса не существует!");
                                return;
                            }
                            var medInst = SelectClass.select_dir_med_inst(db, comboBoxMedInstitute.Text);
                            if (medInst == null)
                            {
                                MessageBox.Show("Такого медучреждения не существует!");
                                return;
                            }

                            Student student = new Student();
                            student.Add(textBoxLastname.Text,
                                textBoxName.Text,
                                textBoxPatronymic.Text,
                                Char.Parse(comboBoxGender.Text),
                                DateOnly.Parse(dateTimePickerBirthday.Value.ToLongDateString()),
                                maskedTextBoxPhone.Text,
                                textBoxEmail.Text,
                                textBoxLogin.Text,
                                textBoxPassword.Text,
                                DateOnly.Parse(dateTimePickerDateVaccinationCertifficate.Value.ToLongDateString()),
                                schoolClass,
                                medInst,
                            "user");

                            schoolClass.Students.Add(student);

                            db.Students.Add(student);

                            schoolClass.Quantity_Students++;
                            db.SchoolClasses.Update(schoolClass);

                            db.SaveChanges();

                            List<Vaccination> vaccinationList = SelectClass.select_vaccinations_list(db, "Профилактическая прививка (делается один раз)");

                                foreach (var item in vaccinationList)
                                {
                                    Vaccination Vaccination = SelectClass.select_vaccinations(db, item.NameVaccination);
                                    VaccinationAndCertificate vac = new VaccinationAndCertificate
                                    {
                                        Vaccination = Vaccination,
                                        VaccinationCertificate = student.vaccinationCertificate,
                                        DateVaccine = DateOnly.MinValue,
                                        ReactionOfVaccine = ""
                                    };

                                    Vaccination.VaccinationAndCertificates.Add(vac);
                                student.vaccinationCertificate.VaccinationAndCertificates.Add(vac);

                                    db.VaccinationCertificates.Update(student.vaccinationCertificate);
                                    db.Vaccinations.Update(Vaccination);
                                    db.VaccinationsAndCertificates.Add(vac);

                                    db.SaveChanges();
                                }

                            MessageBox.Show("Успешно");
                        }
                        else
                            MessageBox.Show("Такой логин уже существует!");
                    } 
                }
                else
                    MessageBox.Show("Такого пола уже существует!");


            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных!");
            }

            //DateOnly date = DateOnly.Parse(maskedTextBoxBirthday.Text);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                var query = from DirectoryOfMedicalInstitution in db.DirectoryOfMedicalInstitutions
                            orderby DirectoryOfMedicalInstitution.NameMedInst
                            select new { DirectoryOfMedicalInstitution.NameMedInst };

                foreach (var item in query)
                {
                    comboBoxMedInstitute.Items.Add(item.NameMedInst);
                }


                var query1 = from SchoolClass in db.SchoolClasses
                             orderby SchoolClass.NameClass
                             select new { SchoolClass.NameClass };


                foreach (var item in query1)
                {
                    comboBoxSchoolClass.Items.Add(item.NameClass);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSchoolClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMedInstitute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxBirthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDateVaccinationCertifficate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxSchoolClass_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxMedInstitute_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxGender_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
