using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using System.Data;


namespace Student.DAL
{

    public class AdminFormDL
    {
        SqlHelper sqhelp = new SqlHelper();
        public void UpdateAdminPassword(AdminInformation admin,string name,int schoolid)
        {
            sqhelp.UpdateAdminPasssword(admin,name,schoolid,"spUpdateAdminPasssword",true);

        }
        public void AddStudent(AdminInformation admin,int schoolid)
        {
            sqhelp.AddStudent(admin,schoolid, "spAddStudent", true);
        }
        public DataTable ShowReport(int schoolid)
        {
           DataTable dt= sqhelp.showUserReport("spShowUserReport",schoolid);
           return dt;
        }
    }
}
