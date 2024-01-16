using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary1.Entity;
using Microsoft.EntityFrameworkCore;
using Npgsql;


namespace School
{
    public partial class ListStudentsForm : Form
    {
        //private void LoadTable()
        //{
        //    NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=kursach_oop; User Id=postgres; Password=123;");
        //    connection.Open();
        //    NpgsqlCommand command = new NpgsqlCommand();
        //    command.Connection = connection;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "select sc.\"NameClass\", s.\"Name\", s.\"Lastname\", s.\"Patronymic\", s.\"Birthday\" " +
        //        "from \"Students\" s join \"SchoolClasses\" sc on sc.\"Id\" = s.\"SchoolClassId\" " +
        //        $"where sc.\"NameClass\" like '%{textBoxClass.Text}%' and s.\"Name\" like '%{textBoxName.Text}%' " +
        //        $"and s.\"Lastname\" like '%{textBoxLastname.Text}%' and (s.\"Patronymic\" like '%{textBoxPatronymic.Text}%' or s.\"Patronymic\" is null)";

        //    //command.CommandText = "select sc.\"NameClass\", s.\"Name\", s.\"Lastname\", s.\"Patronymic\" " +
        //    //        "from \"Students\" s join \"SchoolClasses\" sc on sc.\"Id\" = s.\"SchoolClassId\" " +
        //    //        $"where sc.\"NameClass\" like '%%' and s.\"Name\" like '%%' " +
        //    //        $"and s.\"Lastname\" like '%%' and s.\"Patronymic\" like '%%'";

        //    NpgsqlDataReader dataReader = command.ExecuteReader();

        //    if (dataReader.HasRows)
        //    {
        //        DataTable dataTable = new DataTable();
        //        dataTable.Load(dataReader);
        //        dataGridViewStudents.DataSource = dataTable;
        //    }
        //    command.Dispose();
        //    connection.Close();
        //}

        public ListStudentsForm()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
   
        }

        private void ListStudentsForm_Load(object sender, EventArgs e)
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
            }
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

                    var query = from Student in db.Students
                                join SchoolClass in db.SchoolClasses on Student.SchoolClass.Id equals SchoolClass.Id
                                where SchoolClass.NameClass.Contains(comboBoxSchoolClass.Text)
                                && Student.Name.Contains(textBoxName.Text)
                                && Student.Lastname.Contains(textBoxLastname.Text)
                                && (Student.Patronymic.Contains(textBoxPatronymic.Text) || Student.Patronymic.Contains(null))
                                select new { 
                                    Класс = SchoolClass.NameClass, 
                                    Фамилия = Student.Lastname,
                                    Имя = Student.Name,
                                    Отчество = Student.Patronymic, 
                                    Дата_рождения = Student.Birthday,
                                    Email = Student.Email};

                    dataGridViewStudents.DataSource = query.ToList();

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
    }
}
