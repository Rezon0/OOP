namespace School
{
    partial class EditSchoolClass
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
            this.comboBoxSchoolClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSchoolClass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSchoolClass
            // 
            this.comboBoxSchoolClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSchoolClass.FormattingEnabled = true;
            this.comboBoxSchoolClass.Location = new System.Drawing.Point(19, 64);
            this.comboBoxSchoolClass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxSchoolClass.Name = "comboBoxSchoolClass";
            this.comboBoxSchoolClass.Size = new System.Drawing.Size(413, 53);
            this.comboBoxSchoolClass.Sorted = true;
            this.comboBoxSchoolClass.TabIndex = 76;
            this.comboBoxSchoolClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSchoolClass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 75;
            this.label2.Text = "Существующие классы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "Название класса";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(19, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 78);
            this.button1.TabIndex = 78;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSchoolClass
            // 
            this.textBoxSchoolClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSchoolClass.Location = new System.Drawing.Point(19, 211);
            this.textBoxSchoolClass.MaxLength = 3;
            this.textBoxSchoolClass.Name = "textBoxSchoolClass";
            this.textBoxSchoolClass.Size = new System.Drawing.Size(413, 50);
            this.textBoxSchoolClass.TabIndex = 79;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(257, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 78);
            this.button2.TabIndex = 80;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditSchoolClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSchoolClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSchoolClass);
            this.Name = "EditSchoolClass";
            this.Text = "Создание класса";
            this.Load += new System.EventHandler(this.EditSchoolClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBoxSchoolClass;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxSchoolClass;
        private Button button2;
    }
}