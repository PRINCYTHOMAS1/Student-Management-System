using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Services
{
    internal class TeacherViewProfileService
    {
        public TeacherViewModel TeacherGetByEmail(string email)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM TeacherDetails WHERE EmailId=@EmailId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", email);
            var reader = command.ExecuteReader();
            TeacherViewModel teacherDetails = null;
            while (reader.Read())
            {
                teacherDetails = new TeacherViewModel();
                teacherDetails.TeacherName = reader.GetString(0);
                teacherDetails.TeacherId = reader.GetString(1);
                teacherDetails.PhoneNumber = reader.GetInt64(2);
                teacherDetails.Emailid = reader.GetString(3);
                teacherDetails.Department = reader.GetString(4);
                teacherDetails.Course = reader.GetString(5);
               
            }
            reader.Close();
            return teacherDetails;
        }
    }
}
