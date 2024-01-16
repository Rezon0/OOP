namespace School
{
    partial class LoginForm
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.buttonNoAuthorization = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.Location = new System.Drawing.Point(169, 623);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(537, 98);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "ВОЙТИ";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AccessibleName = "";
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(169, 325);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(537, 50);
            this.textBoxLogin.TabIndex = 9;
            this.textBoxLogin.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AccessibleName = "";
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(169, 482);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(537, 50);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Tag = "";
            // 
            // labelEnter
            // 
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnter.Location = new System.Drawing.Point(158, 76);
            this.labelEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(550, 118);
            this.labelEnter.TabIndex = 6;
            this.labelEnter.Text = "АВТОРИЗАЦИЯ";
            this.labelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNoAuthorization
            // 
            this.buttonNoAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoAuthorization.Location = new System.Drawing.Point(169, 759);
            this.buttonNoAuthorization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNoAuthorization.Name = "buttonNoAuthorization";
            this.buttonNoAuthorization.Size = new System.Drawing.Size(537, 143);
            this.buttonNoAuthorization.TabIndex = 12;
            this.buttonNoAuthorization.Text = "Продолжить без авторизации";
            this.buttonNoAuthorization.UseVisualStyleBackColor = true;
            this.buttonNoAuthorization.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 93);
            this.button3.TabIndex = 13;
            this.button3.Text = "Загрузить бд";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistration.Location = new System.Drawing.Point(169, 941);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(537, 98);
            this.buttonRegistration.TabIndex = 14;
            this.buttonRegistration.Text = "РЕГИСТРАЦИЯ";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 1074);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonNoAuthorization);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelEnter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxPassword;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonNoAuthorization;
        private Button button3;
        private Button buttonRegistration;
    }
}