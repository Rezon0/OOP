namespace School
{
    partial class NoAutorisationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewVaccination = new System.Windows.Forms.DataGridView();
            this.ProfilacticRadioButton = new System.Windows.Forms.GroupBox();
            this.ProfilacticRadioButton2 = new System.Windows.Forms.RadioButton();
            this.RequiredRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).BeginInit();
            this.ProfilacticRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonBack);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(2507, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1894, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы авторизованы как N/A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.Location = new System.Drawing.Point(22, 39);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(284, 89);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Выйти";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 94);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прививки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewVaccination
            // 
            this.dataGridViewVaccination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccination.Location = new System.Drawing.Point(35, 460);
            this.dataGridViewVaccination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewVaccination.Name = "dataGridViewVaccination";
            this.dataGridViewVaccination.RowHeadersWidth = 82;
            this.dataGridViewVaccination.RowTemplate.Height = 33;
            this.dataGridViewVaccination.Size = new System.Drawing.Size(2485, 822);
            this.dataGridViewVaccination.TabIndex = 5;
            this.dataGridViewVaccination.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewVaccination_CellFormatting);
            this.dataGridViewVaccination.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.VaccinationTable_DataError);
            // 
            // ProfilacticRadioButton
            // 
            this.ProfilacticRadioButton.Controls.Add(this.ProfilacticRadioButton2);
            this.ProfilacticRadioButton.Controls.Add(this.RequiredRadioButton);
            this.ProfilacticRadioButton.Location = new System.Drawing.Point(35, 305);
            this.ProfilacticRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfilacticRadioButton.Name = "ProfilacticRadioButton";
            this.ProfilacticRadioButton.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfilacticRadioButton.Size = new System.Drawing.Size(316, 148);
            this.ProfilacticRadioButton.TabIndex = 6;
            this.ProfilacticRadioButton.TabStop = false;
            // 
            // ProfilacticRadioButton2
            // 
            this.ProfilacticRadioButton2.AutoSize = true;
            this.ProfilacticRadioButton2.Location = new System.Drawing.Point(9, 89);
            this.ProfilacticRadioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfilacticRadioButton2.Name = "ProfilacticRadioButton2";
            this.ProfilacticRadioButton2.Size = new System.Drawing.Size(258, 36);
            this.ProfilacticRadioButton2.TabIndex = 1;
            this.ProfilacticRadioButton2.Text = "Профилактические";
            this.ProfilacticRadioButton2.UseVisualStyleBackColor = true;
            this.ProfilacticRadioButton2.CheckedChanged += new System.EventHandler(this.RequiredRadioButton_CheckedChanged);
            // 
            // RequiredRadioButton
            // 
            this.RequiredRadioButton.AutoSize = true;
            this.RequiredRadioButton.Checked = true;
            this.RequiredRadioButton.Location = new System.Drawing.Point(9, 20);
            this.RequiredRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RequiredRadioButton.Name = "RequiredRadioButton";
            this.RequiredRadioButton.Size = new System.Drawing.Size(204, 36);
            this.RequiredRadioButton.TabIndex = 0;
            this.RequiredRadioButton.TabStop = true;
            this.RequiredRadioButton.Text = "Обязательные";
            this.RequiredRadioButton.UseVisualStyleBackColor = true;
            this.RequiredRadioButton.CheckedChanged += new System.EventHandler(this.RequiredRadioButton_CheckedChanged);
            // 
            // NoAutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2544, 1310);
            this.Controls.Add(this.ProfilacticRadioButton);
            this.Controls.Add(this.dataGridViewVaccination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NoAutorisationForm";
            this.Text = "Не выполнен вход";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccination)).EndInit();
            this.ProfilacticRadioButton.ResumeLayout(false);
            this.ProfilacticRadioButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewVaccination;
        private System.Windows.Forms.GroupBox ProfilacticRadioButton;
        private System.Windows.Forms.RadioButton ProfilacticRadioButton2;
        private System.Windows.Forms.RadioButton RequiredRadioButton;
    }
}

