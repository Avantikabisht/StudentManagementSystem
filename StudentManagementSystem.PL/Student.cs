using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.DTO;
using Student.BLL;

namespace StudentManagementSystem.PL
{
    public partial class Student : Form
    {
        LoginDetails login1;
        StudentBL studentbl = new StudentBL();
        string studentname;
        int schoolid;
        public Student(LoginDetails login)
        {
            InitializeComponent();
            login1 = login;
            label8.Text = login.name;
            studentname = login.name;
            label9.Text = login.school;
            schoolid = login.schoolid;
        }
        StudentForm studentform = new StudentForm();
        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet3.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.studentManagementDataSet3.Report);
            // TODO: This line of code loads data into the 'studentManagementDataSet2.Updates' table. You can move, or remove it, as needed.
            this.updatesTableAdapter.Fill(this.studentManagementDataSet2.Updates);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            studentbl.AddStudentDetails(studentform,studentname,schoolid);
        }

       

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            studentform.StudentPassword = TxtPassword.Text;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
                studentform.StudentGender = radioButtonMale.Text;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
                studentform.StudentGender = radioButtonFemale.Text;
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            studentform.StudentAddress = TxtAddress.Text;
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            studentform.StudentPhone = TxtPhone.Text;
        }


      

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            studentbl.UpdateDetails(studentform,studentname,schoolid);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            DataTable dt = studentbl.ShowStudentReport(studentname);
            dataGridView1.DataSource = dt;
            
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
