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
    public partial class NurseHome : Form
    {
        User user;
        public NurseHome()
        {
            InitializeComponent();
        }

        public NurseHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStudentForm form = new EditStudentForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListStudentsForm form = new ListStudentsForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VaccinationCalendar form = new VaccinationCalendar();
            form.ShowDialog();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NurseHome_Load(object sender, EventArgs e)
        {
            LabelLastname.Text = "Фамилия: " + user.Lastname;
            LabelName.Text = "Имя: " + user.Name;
            LabelPatronymic.Text = "Отчество: " + user.Patronymic;
            LabelGender.Text = "Пол: " + user.Gender;
            LabelBirthday.Text = "День рождения: " + user.Birthday;
            LabelEmail.Text = "Email: " + user.Email;
            LabelPhone.Text = "Телефон: " + user.Email;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditSchoolClass form = new EditSchoolClass();
            form.ShowDialog();
        }
    }
}
