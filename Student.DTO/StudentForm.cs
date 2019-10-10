using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DTO
{
    public class StudentForm
    {
        public string StudentName { get; set; }
        public string StudentPassword { get; set; }
        public string StudentSchoolName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress{ get; set; }
        public string StudentPhone { get; set; }
        public int SchoolId { get; set; }

    }
}
