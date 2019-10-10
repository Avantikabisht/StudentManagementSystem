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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        /*
         
         */
        
        LoginDetails login = new LoginDetails();
        LoginBL loginbl = new LoginBL();
        
        
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet.SchoolName' table. You can move, or remove it, as needed.
            this.schoolNameTableAdapter.Fill(this.studentManagementDataSet.SchoolName);
           
        }
        
        private void comboBoxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            login.school = comboBoxSchool.Text;
             login.schoolid =Convert.ToInt16(comboBoxSchool.SelectedValue);
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            login.name = TxtBoxName.Text;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            login.password = TxtPassword.Text;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (RadioBtnAdmin.Checked)
                login.usertype = "ADMIN";

            else
                login.usertype = "STUDENT";
           
            int result= loginbl.ValidateUserDetails(login);
            if(result==1 && login.usertype=="ADMIN")
            {

                MessageBox.Show("Login Successful  "+login.usertype);
                AdminForm form = new AdminForm(login);
                form.Show();

               }
            else
                if(result==1 && login.usertype=="STUDENT")
                {
                    MessageBox.Show("Login Successful  " + login.usertype);
                    Student form = new Student(login);
                    form.Show();

                }
                else

            {
                MessageBox.Show("Invalid Username Or Password");
            }
            
            
        }

        private void RadioBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioBtnStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtNewUser_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            obj.Show();

        }
    }
}
