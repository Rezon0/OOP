using ClassLibrary1;
using ClassLibrary1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace School
{
    public partial class VaccinationCalendar : Form
    {
        Guid Id;

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

        public VaccinationCalendar()
        {
            InitializeComponent();
        }

        public VaccinationCalendar(string user, Guid Id)
        {
            InitializeComponent();

            using (KursachContext db = new())
            {
                if (user == "user")
                {
                    this.Id = Id;
                    comboBoxSchoolClass.Enabled = false;
                    textBoxName.Enabled = false;
                    textBoxLastname.Enabled = false;
                    textBoxPatronymic.Enabled = false;
                    //maskedTextBoxBirthday.Enabled = false;

                    Student student = SelectClass.select_students(db, Id);
                    textBoxName.Text = student.Name;
                    textBoxLastname.Text = student.Lastname;
                    textBoxPatronymic.Text = student.Patronymic;
                    //maskedTextBoxBirthday.Text = student.Birthday.ToString();

                    var query = from Student in db.Students
                                join SchoolClass in db.SchoolClasses on Student.SchoolClass.Id equals SchoolClass.Id
                                where Student.Id == Id
                                select new { SchoolClass.NameClass };

                    if (query != null)
                        comboBoxSchoolClass.Text = query.ToList()[0].NameClass;

                    //buttonFindStudent.Visible = false;
                    //buttonFindStudent.Enabled = false;

                    //button4_Click(null, null);

                    buttonFindStudent.Text = "Найти прививку";
                }
            }


        }

        private void VaccinationCalendar_Load(object sender, EventArgs e)
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


                //InsertComboBoxVaccination(db, comboBoxClassVaccination.Text);
            }
        }

        private void comboBoxClassVaccination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //button4_Click(null, null);
        }

        private void comboBoxClassVaccination_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                comboBoxVaccination.Items.Clear();
                InsertComboBoxVaccination(db, comboBoxClassVaccination.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                try
                {
                    var query = from Student in db.Students
                                join SchoolClass in db.SchoolClasses on Student.SchoolClass.Id equals SchoolClass.Id
                                join VaccinationCertificate in db.VaccinationCertificates on Student.Id equals VaccinationCertificate.ID_Student
                                join VaccinationAndCertificate in db.VaccinationsAndCertificates on VaccinationCertificate.Id equals VaccinationAndCertificate.VaccinationCertificateId
                                join Vaccination in db.Vaccinations on VaccinationAndCertificate.VaccinationId equals Vaccination.Id
                                where SchoolClass.NameClass.Contains(comboBoxSchoolClass.Text)
                                && Student.Name.Contains(textBoxName.Text)
                                && Student.Lastname.Contains(textBoxLastname.Text)
                                && (Student.Patronymic.Contains(textBoxPatronymic.Text) || Student.Patronymic.Contains(null))
                                && Vaccination.NameVaccination.Contains(comboBoxVaccination.Text)

                                select new
                                {
                                    Класс = SchoolClass.NameClass,
                                    Фамилия = Student.Lastname,
                                    Имя = Student.Name,
                                    Отчество = Student.Patronymic,
                                    Прививка = Vaccination.NameVaccination,
                                    День_рождения = Student.Birthday,
                                    Дата_фактической_вакцинации = VaccinationAndCertificate.DateVaccine,
                                    Интервал = Vaccination.IntervalVaccination.Value,
                                    Дата_планируемой_прививки = Student.Birthday.AddDays(int.Parse(Vaccination.IntervalVaccination.Value.Days.ToString())),
                                };


                    dataGridView1.DataSource = query.ToList();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
        }

        private void comboBoxSchoolClass_KeyDown(object sender, KeyEventArgs e)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].ValueType == typeof(TimeSpan) && e.Value != null)
            {
                TimeSpan timeSpanValue = (TimeSpan)e.Value;

                if (timeSpanValue.Days > 365)
                {
                    e.Value = $"{timeSpanValue.Days / 365} год(а)";
                }
                else if (timeSpanValue.Days >= 31)
                {
                    e.Value = $"{timeSpanValue.Days / 31} месяц(ев)";
                }
                else
                {
                    e.Value = $"{timeSpanValue.Days} дней";
                }

                e.FormattingApplied = true; 
            }
        }

        private void comboBoxVaccination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBoxVaccination_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVaccination_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4_Click(null, null);
        }

        private void comboBoxSchoolClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
