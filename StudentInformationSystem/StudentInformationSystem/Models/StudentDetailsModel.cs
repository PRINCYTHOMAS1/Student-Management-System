using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Models
{
    internal class StudentDetailsModel
    {
        public string StudentName { get; set; }
        public string RegisterNumber { get; set; }
        public string Emailid { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string StaffAdvisor { get; set; }
        public int CurrentSemester { get; set; }
    }
}
