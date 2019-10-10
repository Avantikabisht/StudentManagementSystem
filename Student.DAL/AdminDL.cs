using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using System.Data;
using System.Data.SqlClient;

namespace Student.DAL
{
   public  class AdminDL
    {
     
       public void createadmin(AdminDetails admindetails)
       {
           SqlHelper sqhelp = new SqlHelper();
           sqhelp.InsertTable(admindetails,"spInsertAdminDetails",true);
       }
    }
}
