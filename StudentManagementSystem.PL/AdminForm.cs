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
    public partial class AdminForm : Form
    {
        LoginDetails login1;
        int schoolid;
        string adminname;
        public AdminForm(LoginDetails login)
        {
            InitializeComponent();
            login1 = login;
            adminname = login.name;
            schoolid = login.schoolid;
           
        }
        
       
        AdminInformation admin = new AdminInformation();
        AdminFormBL adminformbl = new AdminFormBL();

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet11.StudentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter3.Fill(this.studentManagementDataSet11.StudentReport);
            // TODO: This line of code loads data into the 'studentManagementDataSet10.StudentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter2.Fill(this.studentManagementDataSet10.StudentReport);
            // TODO: This line of code loads data into the 'studentManagementDataSet9.StudentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter1.Fill(this.studentManagementDataSet9.StudentReport);
            // TODO: This line of code loads data into the 'studentManagementDataSet8.StudentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter.Fill(this.studentManagementDataSet8.StudentReport);
            // TODO: This line of code loads data into the 'studentManagementDataSet7.SchoolName' table. You can move, or remove it, as needed.
            this.schoolNameTableAdapter.Fill(this.studentManagementDataSet7.SchoolName);
            // TODO: This line of code loads data into the 'studentManagementDataSet6.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.studentManagementDataSet6.Report);
            // TODO: This line of code loads data into the 'studentManagementDataSet5.Updates' table. You can move, or remove it, as needed.
            this.updatesTableAdapter.Fill(this.studentManagementDataSet5.Updates);

           
            label11.Text = login1.name;
            label12.Text = login1.school;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            admin.AdminPassword = TxtPassword.Text;
        }

      

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            adminformbl.UpdateAdminPassword(admin, adminname,schoolid);
        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {
            admin.StudenName = TxtStudentName.Text;
        }

        private void TxtStudentPassword_TextChanged(object sender, EventArgs e)
        {
            admin.StudentPassword = TxtStudentPassword.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            admin.StudentSchoolName = comboBox1.Text;
      
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            adminformbl.AddStudent(admin,schoolid);
        }

       

        private void label11_Click(object sender, EventArgs e)
        {
          

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
       
        private void BtnShow_Click(object sender, EventArgs e)
        {
          DataTable dt = adminformbl.ShowReport(schoolid);
          dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
