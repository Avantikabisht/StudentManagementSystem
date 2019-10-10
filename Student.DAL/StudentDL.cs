using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Student.DTO;

namespace Student.DAL
{
    public class StudentDL
    {
        StudentForm studentform = new StudentForm();
        SqlHelper sqhelp = new SqlHelper();
        public void AddStudentDetails(StudentForm studentform, string studentname, int schoolid)
        {
            sqhelp.InsertData(studentform, "spInsertStudentDetails", true, studentname,schoolid);

        }
        public void UpdateDetails(StudentForm studentform, string studentname,int schoolid)
        {
            sqhelp.UpdateData(studentform, "spupdateStudentDetails", true, studentname,schoolid);
        }

        public DataTable ShowStudentReport(string studentname)
        {
            DataTable dt=sqhelp.show("spShowReportStudent",studentname);
           return dt;
            
        }

    }
}
