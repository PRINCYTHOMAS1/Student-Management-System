using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Models;
using System.Data;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class StudentDetailsService
    {
        public StudentDetailsModel GetByEmail(string email)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM StudentDetails WHERE EmailId=@EmailId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", email);
            var reader = command.ExecuteReader();
            StudentDetailsModel studdetails = null;
            while (reader.Read())
            {
                studdetails = new StudentDetailsModel();
                studdetails.StudentName = reader.GetString(0);
                studdetails.RegisterNumber = reader.GetString(1);
                studdetails.Emailid = reader.GetString(2);
                studdetails.PhoneNumber = reader.GetInt64(3);
                studdetails.Department = reader.GetString(4);
                studdetails.Course = reader.GetString(5);
                studdetails.StaffAdvisor = reader.GetString(6);
                studdetails.CurrentSemester = reader.GetInt32(7);
            }
            reader.Close();
            return studdetails;
        }
    }
}
