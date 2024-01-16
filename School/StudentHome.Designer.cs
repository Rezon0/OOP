namespace School
{
    partial class StudentHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelBirthday = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.LabelLastname = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonBack);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1068, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы авторизованы как Пользователь ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.Location = new System.Drawing.Point(22, 38);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(284, 90);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Выйти";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 115);
            this.button1.TabIndex = 4;
            this.button1.Text = "Календарь прививок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelPhone);
            this.groupBox2.Controls.Add(this.LabelEmail);
            this.groupBox2.Controls.Add(this.LabelBirthday);
            this.groupBox2.Controls.Add(this.LabelGender);
            this.groupBox2.Controls.Add(this.LabelPatronymic);
            this.groupBox2.Controls.Add(this.LabelLastname);
            this.groupBox2.Controls.Add(this.LabelName);
            this.groupBox2.Location = new System.Drawing.Point(360, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(721, 860);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные пользователя";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPhone.Location = new System.Drawing.Point(43, 555);
            this.LabelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(159, 37);
            this.LabelPhone.TabIndex = 6;
            this.LabelPhone.Text = "Телефон: ";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEmail.Location = new System.Drawing.Point(43, 474);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(115, 37);
            this.LabelEmail.TabIndex = 5;
            this.LabelEmail.Text = "Email: ";
            // 
            // LabelBirthday
            // 
            this.LabelBirthday.AutoSize = true;
            this.LabelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBirthday.Location = new System.Drawing.Point(43, 395);
            this.LabelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBirthday.Name = "LabelBirthday";
            this.LabelBirthday.Size = new System.Drawing.Size(255, 37);
            this.LabelBirthday.TabIndex = 4;
            this.LabelBirthday.Text = "Дата рождения: ";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelGender.Location = new System.Drawing.Point(43, 316);
            this.LabelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(91, 37);
            this.LabelGender.TabIndex = 3;
            this.LabelGender.Text = "Пол: ";
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPatronymic.Location = new System.Drawing.Point(43, 237);
            this.LabelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(169, 37);
            this.LabelPatronymic.TabIndex = 2;
            this.LabelPatronymic.Text = "Отчество: ";
            // 
            // LabelLastname
            // 
            this.LabelLastname.AutoSize = true;
            this.LabelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLastname.Location = new System.Drawing.Point(43, 68);
            this.LabelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLastname.Name = "LabelLastname";
            this.LabelLastname.Size = new System.Drawing.Size(162, 37);
            this.LabelLastname.TabIndex = 1;
            this.LabelLastname.Text = "Фамилия: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(43, 154);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(96, 37);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Имя: ";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 1124);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentHome";
            this.Text = "Домашняя страница школьника";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelBirthday;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label LabelPatronymic;
        private System.Windows.Forms.Label LabelLastname;
        private System.Windows.Forms.Label LabelName;
    }
}