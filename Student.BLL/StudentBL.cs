using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DTO;
using System.Data;
using Student.DAL;

namespace Student.BLL
{
    public class StudentBL
    {
        StudentDL studentdl = new StudentDL();
        StudentForm studentform = new StudentForm();
        public void AddStudentDetails(StudentForm studentform,string studentname,int schoolid)
        {
            studentdl.AddStudentDetails(studentform,studentname,schoolid);


        }
        public void UpdateDetails(StudentForm studentform, string studentname,int schoolid){
            studentdl.UpdateDetails(studentform,studentname,schoolid);
        }

        public DataTable ShowStudentReport(string studentname)
        {
            DataTable dt=studentdl.ShowStudentReport(studentname);
            return dt;
        }
    }
}
