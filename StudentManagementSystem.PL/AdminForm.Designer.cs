namespace StudentManagementSystem.PL
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentPassword = new System.Windows.Forms.TextBox();
            this.updatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet5 = new StudentManagementSystem.PL.StudentManagementDataSet5();
            this.updatesTableAdapter = new StudentManagementSystem.PL.StudentManagementDataSet5TableAdapters.UpdatesTableAdapter();
            this.studentReportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet11 = new StudentManagementSystem.PL.StudentManagementDataSet11();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet6 = new StudentManagementSystem.PL.StudentManagementDataSet6();
            this.reportTableAdapter = new StudentManagementSystem.PL.StudentManagementDataSet6TableAdapters.ReportTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.schoolNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet7 = new StudentManagementSystem.PL.StudentManagementDataSet7();
            this.schoolNameTableAdapter = new StudentManagementSystem.PL.StudentManagementDataSet7TableAdapters.SchoolNameTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentManagementDataSet8 = new StudentManagementSystem.PL.StudentManagementDataSet8();
            this.studentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentReportTableAdapter = new StudentManagementSystem.PL.StudentManagementDataSet8TableAdapters.StudentReportTableAdapter();
            this.studentManagementDataSet9 = new StudentManagementSystem.PL.StudentManagementDataSet9();
            this.studentReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentReportTableAdapter1 = new StudentManagementSystem.PL.StudentManagementDataSet9TableAdapters.StudentReportTableAdapter();
            this.studentManagementDataSet10 = new StudentManagementSystem.PL.StudentManagementDataSet10();
            this.studentReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentReportTableAdapter2 = new StudentManagementSystem.PL.StudentManagementDataSet10TableAdapters.StudentReportTableAdapter();
            this.studentReportTableAdapter3 = new StudentManagementSystem.PL.StudentManagementDataSet11TableAdapters.StudentReportTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(551, 73);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 22);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "School Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(370, 192);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 29);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Location = new System.Drawing.Point(370, 388);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(100, 29);
            this.BtnAddStudent.TabIndex = 7;
            this.BtnAddStudent.Text = "ADD DATA";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "School Name";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(278, 281);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(100, 22);
            this.TxtStudentName.TabIndex = 14;
            this.TxtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // TxtStudentPassword
            // 
            this.TxtStudentPassword.Location = new System.Drawing.Point(551, 281);
            this.TxtStudentPassword.Name = "TxtStudentPassword";
            this.TxtStudentPassword.Size = new System.Drawing.Size(100, 22);
            this.TxtStudentPassword.TabIndex = 15;
            this.TxtStudentPassword.TextChanged += new System.EventHandler(this.TxtStudentPassword_TextChanged);
            // 
            // updatesBindingSource
            // 
            this.updatesBindingSource.DataMember = "Updates";
            this.updatesBindingSource.DataSource = this.studentManagementDataSet5;
            // 
            // studentManagementDataSet5
            // 
            this.studentManagementDataSet5.DataSetName = "StudentManagementDataSet5";
            this.studentManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatesTableAdapter
            // 
            this.updatesTableAdapter.ClearBeforeFill = true;
            // 
            // studentReportBindingSource3
            // 
            this.studentReportBindingSource3.DataMember = "StudentReport";
            this.studentReportBindingSource3.DataSource = this.studentManagementDataSet11;
            // 
            // studentManagementDataSet11
            // 
            this.studentManagementDataSet11.DataSetName = "StudentManagementDataSet11";
            this.studentManagementDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.studentManagementDataSet6;
            // 
            // studentManagementDataSet6
            // 
            this.studentManagementDataSet6.DataSetName = "StudentManagementDataSet6";
            this.studentManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.schoolNameBindingSource;
            this.comboBox1.DisplayMember = "SchoolName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "SchoolId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // schoolNameBindingSource
            // 
            this.schoolNameBindingSource.DataMember = "SchoolName";
            this.schoolNameBindingSource.DataSource = this.studentManagementDataSet7;
            // 
            // studentManagementDataSet7
            // 
            this.studentManagementDataSet7.DataSetName = "StudentManagementDataSet7";
            this.studentManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolNameTableAdapter
            // 
            this.schoolNameTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "WELCOME ADMIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "ADD STUDENT DATA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // studentManagementDataSet8
            // 
            this.studentManagementDataSet8.DataSetName = "StudentManagementDataSet8";
            this.studentManagementDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentReportBindingSource
            // 
            this.studentReportBindingSource.DataMember = "StudentReport";
            this.studentReportBindingSource.DataSource = this.studentManagementDataSet8;
            // 
            // studentReportTableAdapter
            // 
            this.studentReportTableAdapter.ClearBeforeFill = true;
            // 
            // studentManagementDataSet9
            // 
            this.studentManagementDataSet9.DataSetName = "StudentManagementDataSet9";
            this.studentManagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentReportBindingSource1
            // 
            this.studentReportBindingSource1.DataMember = "StudentReport";
            this.studentReportBindingSource1.DataSource = this.studentManagementDataSet9;
            // 
            // studentReportTableAdapter1
            // 
            this.studentReportTableAdapter1.ClearBeforeFill = true;
            // 
            // studentManagementDataSet10
            // 
            this.studentManagementDataSet10.DataSetName = "StudentManagementDataSet10";
            this.studentManagementDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentReportBindingSource2
            // 
            this.studentReportBindingSource2.DataMember = "StudentReport";
            this.studentReportBindingSource2.DataSource = this.studentManagementDataSet10;
            // 
            // studentReportTableAdapter2
            // 
            this.studentReportTableAdapter2.ClearBeforeFill = true;
            // 
            // studentReportTableAdapter3
            // 
            this.studentReportTableAdapter3.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(370, 442);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(104, 26);
            this.BtnShow.TabIndex = 27;
            this.BtnShow.Text = "Show Report";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 652);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtStudentPassword);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentPassword;
        private StudentManagementDataSet5 studentManagementDataSet5;
        private System.Windows.Forms.BindingSource updatesBindingSource;
        private StudentManagementDataSet5TableAdapters.UpdatesTableAdapter updatesTableAdapter;
        private StudentManagementDataSet6 studentManagementDataSet6;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private StudentManagementDataSet6TableAdapters.ReportTableAdapter reportTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private StudentManagementDataSet7 studentManagementDataSet7;
        private System.Windows.Forms.BindingSource schoolNameBindingSource;
        private StudentManagementDataSet7TableAdapters.SchoolNameTableAdapter schoolNameTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private StudentManagementDataSet8 studentManagementDataSet8;
        private System.Windows.Forms.BindingSource studentReportBindingSource;
        private StudentManagementDataSet8TableAdapters.StudentReportTableAdapter studentReportTableAdapter;
        private StudentManagementDataSet9 studentManagementDataSet9;
        private System.Windows.Forms.BindingSource studentReportBindingSource1;
        private StudentManagementDataSet9TableAdapters.StudentReportTableAdapter studentReportTableAdapter1;
        private StudentManagementDataSet10 studentManagementDataSet10;
        private System.Windows.Forms.BindingSource studentReportBindingSource2;
        private StudentManagementDataSet10TableAdapters.StudentReportTableAdapter studentReportTableAdapter2;
        private StudentManagementDataSet11 studentManagementDataSet11;
        private System.Windows.Forms.BindingSource studentReportBindingSource3;
        private StudentManagementDataSet11TableAdapters.StudentReportTableAdapter studentReportTableAdapter3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnShow;
    }
}