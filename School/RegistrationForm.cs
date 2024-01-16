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
    public partial class RegistrationForm : Form
    {
        private CheckSuperuserPasswordClass check = new CheckSuperuserPasswordClass();

        void delete_nurse(KursachContext db, Nurse nurse)
        {
            if (nurse != null)
            {
                var post = SelectClass.select_post(db, comboBoxPosts.Text);
                if (post == null)
                {
                    MessageBox.Show("Такой должности не существует!");
                    return;
                }

                db.Nurses.Remove(nurse);
                db.SaveChanges();
            }
            else
                MessageBox.Show("Запись не существует!");
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            CheckSuperuserPasswordForm form = new CheckSuperuserPasswordForm(check);
            form.ShowDialog();
            if (check.flag == false)
                Close();

            using (KursachContext db = new())
            {
                var query = from Post in db.Postes
                            orderby Post.NamePost
                            select new { Post.NamePost };

                if (query != null)
                {
                    foreach (var item in query)
                    {
                        comboBoxPosts.Items.Add(item.NamePost);
                    }
                    comboBoxPosts.Text = comboBoxPosts.Items[0].ToString();
                }
                else
                    MessageBox.Show("Такой должности не существует!");
            }
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
                comboBoxPosts.Text == String.Empty ||
                dateTimePickerBirthday.Text == String.Empty ||
                maskedTextBoxPhone.Text == String.Empty)
                {
                    MessageBox.Show("Не заполнены все обязательные поля!");
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
                            var post = SelectClass.select_post(db, comboBoxPosts.Text);
                            if (post == null)
                            {
                                MessageBox.Show("Такой должности не существует!");
                                return;
                            }

                            Nurse nurse = new Nurse();
                            nurse.Add(textBoxLastname.Text,
                                textBoxName.Text,
                                textBoxPatronymic.Text,
                                Char.Parse(comboBoxGender.Text),
                                //DateOnly.Parse(maskedTextBoxBirthday.Text),
                                DateOnly.Parse(dateTimePickerBirthday.Value.ToLongDateString()),
                                maskedTextBoxPhone.Text,
                                textBoxEmail.Text,
                                textBoxLogin.Text,
                                textBoxPassword.Text,
                                post,
                            "admin");

                            db.Nurses.Add(nurse);

                            db.SaveChanges();

                            MessageBox.Show("Успешно");
                        }
                        else
                            MessageBox.Show("Такой логин уже существует!");
                    }
                }
                else
                    MessageBox.Show("Такой логин уже существует!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                try
                {
                    delete_nurse(db, SelectClass.select_nurses(db,
                             textBoxLastname.Text,
                             textBoxName.Text,
                             textBoxPatronymic.Text,
                             DateOnly.Parse(dateTimePickerBirthday.Value.ToLongDateString())));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                try
                {
                    var post = SelectClass.select_post(db, comboBoxPosts.Text);
                    if (post == null)
                    {
                        MessageBox.Show("Такой должности не существует!");
                        return;
                    }

                    var query = from Nurse in db.Nurses

                                select new
                                {
                                    Nurse.Lastname,
                                    Nurse.Name,
                                    Nurse.Patronymic,
                                    Nurse.Gender,
                                    Nurse.Birthday,
                                    Nurse.Phone,
                                    Nurse.Email,
                                    Nurse.Postes.NamePost,
                                    Nurse.Login,
                                    Nurse.Password
                                };

                    dataGridViewListAdmin.DataSource = query.ToList();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
        }

        private void comboBoxGender_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxPosts_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
