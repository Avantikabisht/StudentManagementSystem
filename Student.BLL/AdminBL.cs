using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DAL;
using Student.DTO;

namespace Student.BLL
{
    public class AdminBL
    {
        AdminDL admindl = new AdminDL();
        public void CreateAdminData(AdminDetails admindetails)
        {
            admindl.createadmin(admindetails);
        }
    }
}
