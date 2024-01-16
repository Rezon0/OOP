namespace School
{
    partial class VaccinationCalendar
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxVaccination = new System.Windows.Forms.ComboBox();
            this.comboBoxClassVaccination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.comboBoxSchoolClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxVaccination);
            this.groupBox4.Controls.Add(this.comboBoxClassVaccination);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(245, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(747, 135);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск прививки";
            // 
            // comboBoxVaccination
            // 
            this.comboBoxVaccination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxVaccination.FormattingEnabled = true;
            this.comboBoxVaccination.Location = new System.Drawing.Point(14, 102);
            this.comboBoxVaccination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVaccination.Name = "comboBoxVaccination";
            this.comboBoxVaccination.Size = new System.Drawing.Size(586, 28);
            this.comboBoxVaccination.Sorted = true;
            this.comboBoxVaccination.TabIndex = 124;
            this.comboBoxVaccination.SelectedIndexChanged += new System.EventHandler(this.comboBoxVaccination_SelectedIndexChanged);
            this.comboBoxVaccination.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVaccination_SelectionChangeCommitted);
            this.comboBoxVaccination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVaccination_KeyDown);
            // 
            // comboBoxClassVaccination
            // 
            this.comboBoxClassVaccination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClassVaccination.FormattingEnabled = true;
            this.comboBoxClassVaccination.Location = new System.Drawing.Point(18, 40);
            this.comboBoxClassVaccination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClassVaccination.Name = "comboBoxClassVaccination";
            this.comboBoxClassVaccination.Size = new System.Drawing.Size(582, 28);
            this.comboBoxClassVaccination.Sorted = true;
            this.comboBoxClassVaccination.TabIndex = 123;
            this.comboBoxClassVaccination.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassVaccination_SelectedIndexChanged);
            this.comboBoxClassVaccination.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClassVaccination_SelectionChangeCommitted);
            this.comboBoxClassVaccination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxClassVaccination_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Класс прививки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Наименование";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 211);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.comboBoxSchoolClass);
            this.groupBoxStudent.Controls.Add(this.label2);
            this.groupBoxStudent.Controls.Add(this.buttonFindStudent);
            this.groupBoxStudent.Controls.Add(this.label3);
            this.groupBoxStudent.Controls.Add(this.textBoxName);
            this.groupBoxStudent.Controls.Add(this.label4);
            this.groupBoxStudent.Controls.Add(this.textBoxLastname);
            this.groupBoxStudent.Controls.Add(this.label5);
            this.groupBoxStudent.Controls.Add(this.textBoxPatronymic);
            this.groupBoxStudent.Location = new System.Drawing.Point(7, 7);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStudent.Size = new System.Drawing.Size(195, 374);
            this.groupBoxStudent.TabIndex = 80;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Поиск студента";
            // 
            // comboBoxSchoolClass
            // 
            this.comboBoxSchoolClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSchoolClass.FormattingEnabled = true;
            this.comboBoxSchoolClass.Location = new System.Drawing.Point(7, 43);
            this.comboBoxSchoolClass.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxSchoolClass.Name = "comboBoxSchoolClass";
            this.comboBoxSchoolClass.Size = new System.Drawing.Size(173, 29);
            this.comboBoxSchoolClass.Sorted = true;
            this.comboBoxSchoolClass.TabIndex = 74;
            this.comboBoxSchoolClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxSchoolClass_SelectedIndexChanged);
            this.comboBoxSchoolClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSchoolClass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Класс";
            // 
            // buttonFindStudent
            // 
            this.buttonFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindStudent.Location = new System.Drawing.Point(4, 299);
            this.buttonFindStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFindStudent.Name = "buttonFindStudent";
            this.buttonFindStudent.Size = new System.Drawing.Size(173, 61);
            this.buttonFindStudent.TabIndex = 73;
            this.buttonFindStudent.Text = "Найти школьника";
            this.buttonFindStudent.UseVisualStyleBackColor = true;
            this.buttonFindStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(7, 115);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 26);
            this.textBoxName.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Фамилия";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastname.Location = new System.Drawing.Point(7, 186);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastname.MaxLength = 50;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(173, 26);
            this.textBoxLastname.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPatronymic.Location = new System.Drawing.Point(7, 255);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(173, 26);
            this.textBoxPatronymic.TabIndex = 43;
            // 
            // VaccinationCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 378);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VaccinationCalendar";
            this.Text = "Календарь прививок";
            this.Load += new System.EventHandler(this.VaccinationCalendar_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClassVaccination;
        private System.Windows.Forms.ComboBox comboBoxVaccination;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupBox groupBoxStudent;
        private ComboBox comboBoxSchoolClass;
        private Label label2;
        private Button buttonFindStudent;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private TextBox textBoxLastname;
        private Label label5;
        private TextBox textBoxPatronymic;
    }
}