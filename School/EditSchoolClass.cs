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
    public partial class EditSchoolClass : Form
    {
        public EditSchoolClass()
        {
            InitializeComponent();
        }

        private void EditSchoolClass_Load(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                var query1 = from SchoolClass in db.SchoolClasses
                             orderby SchoolClass.NameClass
                             select new { SchoolClass.NameClass };

                if (query1 != null)
                {
                    comboBoxSchoolClass.Items.Clear();

                    foreach (var item in query1)
                    {
                        comboBoxSchoolClass.Items.Add(item.NameClass);
                    }
                    comboBoxSchoolClass.Text = comboBoxSchoolClass.Items[0].ToString();
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSchoolClass.Text == String.Empty)
            {
                MessageBox.Show("Не заполнены все обязательные поля!");
                return;
            }

            using (KursachContext db = new())
            {
                textBoxSchoolClass.Text = textBoxSchoolClass.Text.Replace(" ", "");

                if (textBoxSchoolClass.Text != String.Empty)
                {
                    var schoolClass = SelectClass.select_school_class(db, textBoxSchoolClass.Text);

                    if (schoolClass == null)
                    {
                        schoolClass = new SchoolClass();
                        schoolClass.Add(textBoxSchoolClass.Text);

                        db.SchoolClasses.Add(schoolClass);
                        db.SaveChanges();

                        EditSchoolClass_Load(null, null);

                        MessageBox.Show("Успешно!");
                    }
                    else
                        MessageBox.Show("Такой класс уже существует!");
                }
                else
                    MessageBox.Show("Не заполнены все обязательные поля!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                textBoxSchoolClass.Text = textBoxSchoolClass.Text.Replace(" ", "");
                if (textBoxSchoolClass.Text != String.Empty)
                {
                    var schoolClass = SelectClass.select_school_class(db, textBoxSchoolClass.Text);

                    if (schoolClass != null)
                    {
                        foreach (var item in schoolClass.Students)
                        {
                            item.SchoolClass = null;
                        }

                        db.SchoolClasses.Remove(schoolClass);
                        db.SaveChanges();

                        EditSchoolClass_Load(null, null);

                        MessageBox.Show("Успешно!");
                    }
                    else
                        MessageBox.Show("Такой класс не существует!");
                }
                else
                    MessageBox.Show("Не заполнены все обязательные поля!");
            }
        }

        private void comboBoxSchoolClass_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
