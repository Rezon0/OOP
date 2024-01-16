using ClassLibrary1.Entity;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
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
    public partial class StudentHome : Form
    {
        User user;

        public StudentHome()
        {
            InitializeComponent();
        }

        public StudentHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VaccinationCalendar form = new VaccinationCalendar(user.Privilege, user.Id);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            LabelLastname.Text = "Фамилия: " + user.Lastname;
            LabelName.Text = "Имя: " + user.Name;
            LabelPatronymic.Text = "Отчество: " + user.Patronymic;
            LabelGender.Text = "Пол: " + user.Gender;
            LabelBirthday.Text = "День рождения: " + user.Birthday;
            LabelEmail.Text = "Email: " + user.Email;
            LabelPhone.Text = "Телефон: " + user.Email;
        }
    }
}
