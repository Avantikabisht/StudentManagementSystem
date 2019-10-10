using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using System.Windows;
using System.Data;
using System.Data.SqlClient;



namespace Student.DAL
{
     public class LoginDl
    {
         LoginDetails login = new LoginDetails();
         SqlHelper sqhelp = new SqlHelper();


         public int ValidateUserType(LoginDetails login)
         {
             int result;


             if (login.usertype == "ADMIN")
             {
                 result = sqhelp.ValidateUserType(login, "spCheckLoginDetails");
                 //login.UserId = sqhelp.GetId(login, "spGetUserId");
             }
             else
             {
                 result = sqhelp.ValidateUserType(login, "spCheckStudentLoginDetails");
                // login.UserId = sqhelp.GetId(login, "spGetStudentId");
             }
             return result;
            
             
         }
    }
}
