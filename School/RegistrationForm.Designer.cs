namespace School
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPosts = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewListAdmin = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1974, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxGender);
            this.tabPage1.Controls.Add(this.dateTimePickerBirthday);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxPosts);
            this.tabPage1.Controls.Add(this.ButtonBack);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.maskedTextBoxPhone);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxLastname);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxPatronymic);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxLogin);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1958, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить/Удалить администратора";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.comboBoxGender.Location = new System.Drawing.Point(399, 122);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxGender.MaxLength = 1;
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(325, 53);
            this.comboBoxGender.Sorted = true;
            this.comboBoxGender.TabIndex = 128;
            this.comboBoxGender.Text = "М";
            this.comboBoxGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxGender_KeyDown);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(1179, 132);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(400, 50);
            this.dateTimePickerBirthday.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(841, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 90);
            this.button1.TabIndex = 88;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 37);
            this.label1.TabIndex = 67;
            this.label1.Text = "Введите данные администратора";
            // 
            // comboBoxPosts
            // 
            this.comboBoxPosts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPosts.FormattingEnabled = true;
            this.comboBoxPosts.Location = new System.Drawing.Point(815, 131);
            this.comboBoxPosts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxPosts.Name = "comboBoxPosts";
            this.comboBoxPosts.Size = new System.Drawing.Size(325, 53);
            this.comboBoxPosts.Sorted = true;
            this.comboBoxPosts.TabIndex = 87;
            this.comboBoxPosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPosts_KeyDown);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.Location = new System.Drawing.Point(406, 520);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(299, 90);
            this.ButtonBack.TabIndex = 66;
            this.ButtonBack.Text = "Добавить";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(815, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 68;
            this.label2.Text = "Должность*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1179, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 37);
            this.label6.TabIndex = 85;
            this.label6.Text = "Дата рождения*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 69;
            this.label3.Text = "Имя*";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(406, 425);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxPhone.Mask = "+7 (999) 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(318, 44);
            this.maskedTextBoxPhone.TabIndex = 84;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(14, 131);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(318, 44);
            this.textBoxName.TabIndex = 70;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(406, 282);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(318, 44);
            this.textBoxEmail.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 71;
            this.label4.Text = "Фамилия*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(399, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 37);
            this.label11.TabIndex = 82;
            this.label11.Text = "Email*";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastname.Location = new System.Drawing.Point(14, 282);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastname.MaxLength = 50;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(318, 44);
            this.textBoxLastname.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 37);
            this.label5.TabIndex = 73;
            this.label5.Text = "Отчество";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(399, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 37);
            this.label12.TabIndex = 80;
            this.label12.Text = "Пол*";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPatronymic.Location = new System.Drawing.Point(14, 429);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(318, 44);
            this.textBoxPatronymic.TabIndex = 74;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(822, 431);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.MaxLength = 32;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(318, 44);
            this.textBoxPassword.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(399, 361);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 37);
            this.label9.TabIndex = 75;
            this.label9.Text = "Телефон*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(815, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 37);
            this.label7.TabIndex = 78;
            this.label7.Text = "Пароль*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(815, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 37);
            this.label8.TabIndex = 76;
            this.label8.Text = "Логин*";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(822, 282);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.MaxLength = 32;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(318, 44);
            this.textBoxLogin.TabIndex = 77;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewListAdmin);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1958, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список администраторов";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridViewListAdmin
            // 
            this.dataGridViewListAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAdmin.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewListAdmin.Name = "dataGridViewListAdmin";
            this.dataGridViewListAdmin.RowHeadersWidth = 82;
            this.dataGridViewListAdmin.RowTemplate.Height = 41;
            this.dataGridViewListAdmin.Size = new System.Drawing.Size(1946, 627);
            this.dataGridViewListAdmin.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1998, 713);
            this.Controls.Add(this.tabControl1);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация администратора";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Label label1;
        private ComboBox comboBoxPosts;
        private Button ButtonBack;
        private Label label2;
        private Label label6;
        private Label label3;
        private MaskedTextBox maskedTextBoxPhone;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label11;
        private TextBox textBoxLastname;
        private Label label5;
        private Label label12;
        private TextBox textBoxPatronymic;
        private TextBox textBoxPassword;
        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox textBoxLogin;
        private TabPage tabPage2;
        private DataGridView dataGridViewListAdmin;
        private DateTimePicker dateTimePickerBirthday;
        private ComboBox comboBoxGender;
    }
}