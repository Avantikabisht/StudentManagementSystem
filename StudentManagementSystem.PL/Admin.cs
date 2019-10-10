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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        AdminDetails admindetails = new AdminDetails();
        AdminBL adminbl = new AdminBL();
        
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            admindetails.AdminPassword = TxtPassword.Text;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet4.SchoolName' table. You can move, or remove it, as needed.
            this.schoolNameTableAdapter.Fill(this.studentManagementDataSet4.SchoolName);

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            admindetails.AdminName = TxtName.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            admindetails.SchoolName = comboBox1.Text;
            admindetails.SchoolId = (int)comboBox1.SelectedValue;
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            adminbl.CreateAdminData(admindetails);
            Login form = new Login();
            form.Show();
        }
    }
}
