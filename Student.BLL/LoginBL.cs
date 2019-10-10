using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using Student.DAL;

namespace Student.BLL
{
    public class LoginBL
    {
        LoginDetails login = new LoginDetails();
        LoginDl logindl = new LoginDl();

        public int ValidateUserDetails(LoginDetails login)
        {
             int r=logindl.ValidateUserType(login);
             return r;
            
        }

    }
}
