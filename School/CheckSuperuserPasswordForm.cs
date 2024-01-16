using ClassLibrary1;
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
    public partial class CheckSuperuserPasswordForm : Form
    {
        CheckSuperuserPasswordClass check;

        public CheckSuperuserPasswordForm(CheckSuperuserPasswordClass check)
        {
            InitializeComponent();
            this.check = check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                if (textBox1.Text == db.getPassword())
                    check.flag = true;
                else
                    check.flag = false;
            }

            Close();
        }

        private void CheckSuperuserPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
