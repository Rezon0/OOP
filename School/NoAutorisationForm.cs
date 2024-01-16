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
using Npgsql;

namespace School
{
    public partial class NoAutorisationForm : Form
    {
        private void LoadTable(bool flag)
        {
            using (KursachContext db = new())
            {
                try
                {
                    string vaccine;
                    if (flag == false)
                    {
                        vaccine = "Профилактических прививок по эпидемическим показаниям";
                    }
                    else
                    {
                        vaccine = "Профилактическая прививка (делается один раз)";
                    }
                        
                    var query = from v in db.Vaccinations
                                join cv in db.ClassVaccinations on v.ClassVaccination.Id equals cv.Id
                                where cv.NameClassVaccination == vaccine
                                select new { 
                                    Название = v.NameVaccination, 
                                    Интервал = v.IntervalVaccination.Value };


                    dataGridViewVaccination.DataSource = query.ToList();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
        }

        public NoAutorisationForm()
        {
            InitializeComponent();
            LoadTable(true);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RequiredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RequiredRadioButton.Checked == true)
            {
                LoadTable(true);
            }

            if(ProfilacticRadioButton2.Checked == true)
            {
                LoadTable(false);
            }
        }

        public void EnterVaccinationTable(string name)
        {
            dataGridViewVaccination.Rows.Clear();
            // поменять названия столбцов
        }

        private void VaccinationTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewVaccination_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewVaccination.Columns[e.ColumnIndex].ValueType == typeof(TimeSpan) && e.Value != null)
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
    }
}
