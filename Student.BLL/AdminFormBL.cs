using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using Student.DAL;
using System.Data;

namespace Student.BLL
{
   public class AdminFormBL
    {
       AdminFormDL adminformdl = new AdminFormDL();
       public void UpdateAdminPassword(AdminInformation admin,string name,int schoolid)
       {
           adminformdl.UpdateAdminPassword(admin, name,schoolid);

       }
       public void AddStudent(AdminInformation admin,int schoolid)
       {
           adminformdl.AddStudent(admin,schoolid);
       }
       public DataTable  ShowReport(int schoolid)
       {
           DataTable dt= adminformdl.ShowReport(schoolid);
           return dt;
       }
    }
}
