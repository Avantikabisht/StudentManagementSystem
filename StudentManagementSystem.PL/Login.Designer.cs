namespace StudentManagementSystem.PL
{
    partial class Login
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
            this.LbSchoolName = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LbUserType = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxSchool = new System.Windows.Forms.ComboBox();
            this.schoolNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet = new StudentManagementSystem.PL.StudentManagementDataSet();
            this.RadioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.RadioBtnStudent = new System.Windows.Forms.RadioButton();
            this.LbName = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.schoolNameTableAdapter = new StudentManagementSystem.PL.StudentManagementDataSetTableAdapters.SchoolNameTableAdapter();
            this.TxtNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LbSchoolName
            // 
            this.LbSchoolName.AutoSize = true;
            this.LbSchoolName.Location = new System.Drawing.Point(249, 210);
            this.LbSchoolName.Name = "LbSchoolName";
            this.LbSchoolName.Size = new System.Drawing.Size(92, 17);
            this.LbSchoolName.TabIndex = 0;
            this.LbSchoolName.Text = "School Name";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(353, 324);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(121, 22);
            this.TxtBoxName.TabIndex = 1;
            this.TxtBoxName.TextChanged += new System.EventHandler(this.TxtBoxName_TextChanged);
            // 
            // LbUserType
            // 
            this.LbUserType.AutoSize = true;
            this.LbUserType.Location = new System.Drawing.Point(249, 276);
            this.LbUserType.Name = "LbUserType";
            this.LbUserType.Size = new System.Drawing.Size(38, 17);
            this.LbUserType.TabIndex = 2;
            this.LbUserType.Text = "User";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(353, 374);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(121, 22);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // comboBoxSchool
            // 
            this.comboBoxSchool.DataSource = this.schoolNameBindingSource;
            this.comboBoxSchool.DisplayMember = "SchoolName";
            this.comboBoxSchool.FormattingEnabled = true;
            this.comboBoxSchool.Location = new System.Drawing.Point(353, 210);
            this.comboBoxSchool.Name = "comboBoxSchool";
            this.comboBoxSchool.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSchool.TabIndex = 4;
            this.comboBoxSchool.ValueMember = "SchoolId";
            this.comboBoxSchool.SelectedIndexChanged += new System.EventHandler(this.comboBoxSchool_SelectedIndexChanged);
            // 
            // schoolNameBindingSource
            // 
            this.schoolNameBindingSource.DataMember = "SchoolName";
            this.schoolNameBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // studentManagementDataSet
            // 
            this.studentManagementDataSet.DataSetName = "StudentManagementDataSet";
            this.studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RadioBtnAdmin
            // 
            this.RadioBtnAdmin.AutoSize = true;
            this.RadioBtnAdmin.Location = new System.Drawing.Point(353, 271);
            this.RadioBtnAdmin.Name = "RadioBtnAdmin";
            this.RadioBtnAdmin.Size = new System.Drawing.Size(72, 21);
            this.RadioBtnAdmin.TabIndex = 5;
            this.RadioBtnAdmin.TabStop = true;
            this.RadioBtnAdmin.Text = "ADMIN";
            this.RadioBtnAdmin.UseVisualStyleBackColor = true;
            this.RadioBtnAdmin.CheckedChanged += new System.EventHandler(this.RadioBtnAdmin_CheckedChanged);
            // 
            // RadioBtnStudent
            // 
            this.RadioBtnStudent.AutoSize = true;
            this.RadioBtnStudent.Location = new System.Drawing.Point(469, 271);
            this.RadioBtnStudent.Name = "RadioBtnStudent";
            this.RadioBtnStudent.Size = new System.Drawing.Size(95, 21);
            this.RadioBtnStudent.TabIndex = 6;
            this.RadioBtnStudent.TabStop = true;
            this.RadioBtnStudent.Text = "STUDENT";
            this.RadioBtnStudent.UseVisualStyleBackColor = true;
            this.RadioBtnStudent.CheckedChanged += new System.EventHandler(this.RadioBtnStudent_CheckedChanged);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(249, 324);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(45, 17);
            this.LbName.TabIndex = 7;
            this.LbName.Text = "Name";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(249, 379);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(69, 17);
            this.LbPassword.TabIndex = 8;
            this.LbPassword.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(353, 439);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(121, 31);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // schoolNameTableAdapter
            // 
            this.schoolNameTableAdapter.ClearBeforeFill = true;
            // 
            // TxtNewUser
            // 
            this.TxtNewUser.Location = new System.Drawing.Point(520, 439);
            this.TxtNewUser.Name = "TxtNewUser";
            this.TxtNewUser.Size = new System.Drawing.Size(121, 31);
            this.TxtNewUser.TabIndex = 10;
            this.TxtNewUser.Text = "NEW USER";
            this.TxtNewUser.UseVisualStyleBackColor = true;
            this.TxtNewUser.Click += new System.EventHandler(this.TxtNewUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 659);
            this.Controls.Add(this.TxtNewUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.RadioBtnStudent);
            this.Controls.Add(this.RadioBtnAdmin);
            this.Controls.Add(this.comboBoxSchool);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LbUserType);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.LbSchoolName);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbSchoolName;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label LbUserType;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox comboBoxSchool;
        private System.Windows.Forms.RadioButton RadioBtnAdmin;
        private System.Windows.Forms.RadioButton RadioBtnStudent;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private StudentManagementDataSet studentManagementDataSet;
        private System.Windows.Forms.BindingSource schoolNameBindingSource;
        private StudentManagementDataSetTableAdapters.SchoolNameTableAdapter schoolNameTableAdapter;
        private System.Windows.Forms.Button TxtNewUser;

    }
}