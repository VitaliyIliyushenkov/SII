namespace Ex_system
{
    partial class Expert_system
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
            this.cmbTemperature = new System.Windows.Forms.ComboBox();
            this.btnDiagnose = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbCough = new System.Windows.Forms.ComboBox();
            this.cmbHeadache = new System.Windows.Forms.ComboBox();
            this.cmbRunnyNose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFatigue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbThroatPain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDrowsiness = new System.Windows.Forms.ComboBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTemperature
            // 
            this.cmbTemperature.FormattingEnabled = true;
            this.cmbTemperature.Location = new System.Drawing.Point(12, 35);
            this.cmbTemperature.Name = "cmbTemperature";
            this.cmbTemperature.Size = new System.Drawing.Size(121, 24);
            this.cmbTemperature.TabIndex = 0;
            // 
            // btnDiagnose
            // 
            this.btnDiagnose.Location = new System.Drawing.Point(140, 35);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(95, 23);
            this.btnDiagnose.TabIndex = 1;
            this.btnDiagnose.Text = "Результат";
            this.btnDiagnose.UseVisualStyleBackColor = true;
            this.btnDiagnose.Click += new System.EventHandler(this.btnDiagnose_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(241, 38);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
            // 
            // cmbCough
            // 
            this.cmbCough.FormattingEnabled = true;
            this.cmbCough.Location = new System.Drawing.Point(12, 83);
            this.cmbCough.Name = "cmbCough";
            this.cmbCough.Size = new System.Drawing.Size(121, 24);
            this.cmbCough.TabIndex = 3;
            // 
            // cmbHeadache
            // 
            this.cmbHeadache.FormattingEnabled = true;
            this.cmbHeadache.Location = new System.Drawing.Point(12, 132);
            this.cmbHeadache.Name = "cmbHeadache";
            this.cmbHeadache.Size = new System.Drawing.Size(121, 24);
            this.cmbHeadache.TabIndex = 4;
            // 
            // cmbRunnyNose
            // 
            this.cmbRunnyNose.FormattingEnabled = true;
            this.cmbRunnyNose.Location = new System.Drawing.Point(12, 181);
            this.cmbRunnyNose.Name = "cmbRunnyNose";
            this.cmbRunnyNose.Size = new System.Drawing.Size(121, 24);
            this.cmbRunnyNose.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кашель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Головная боль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Насморк";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Усталость";
            // 
            // cmbFatigue
            // 
            this.cmbFatigue.FormattingEnabled = true;
            this.cmbFatigue.Location = new System.Drawing.Point(12, 233);
            this.cmbFatigue.Name = "cmbFatigue";
            this.cmbFatigue.Size = new System.Drawing.Size(121, 24);
            this.cmbFatigue.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Боль в горле";
            // 
            // cmbThroatPain
            // 
            this.cmbThroatPain.FormattingEnabled = true;
            this.cmbThroatPain.Location = new System.Drawing.Point(12, 286);
            this.cmbThroatPain.Name = "cmbThroatPain";
            this.cmbThroatPain.Size = new System.Drawing.Size(121, 24);
            this.cmbThroatPain.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сонливость";
            // 
            // cmbDrowsiness
            // 
            this.cmbDrowsiness.FormattingEnabled = true;
            this.cmbDrowsiness.Location = new System.Drawing.Point(12, 337);
            this.cmbDrowsiness.Name = "cmbDrowsiness";
            this.cmbDrowsiness.Size = new System.Drawing.Size(121, 24);
            this.cmbDrowsiness.TabIndex = 14;
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(245, 83);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(543, 355);
            this.dgvPatients.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 17;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(139, 154);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Возраст";
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(12, 367);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(95, 23);
            this.btnSaveToDatabase.TabIndex = 21;
            this.btnSaveToDatabase.Text = "Сохранить";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // Expert_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDrowsiness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbThroatPain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFatigue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRunnyNose);
            this.Controls.Add(this.cmbHeadache);
            this.Controls.Add(this.cmbCough);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDiagnose);
            this.Controls.Add(this.cmbTemperature);
            this.Name = "Expert_system";
            this.Text = "Expert System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTemperature;
        private System.Windows.Forms.Button btnDiagnose;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbCough;
        private System.Windows.Forms.ComboBox cmbHeadache;
        private System.Windows.Forms.ComboBox cmbRunnyNose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFatigue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbThroatPain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDrowsiness;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveToDatabase;
    }
}

