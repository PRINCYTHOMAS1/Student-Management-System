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
    internal class AddStudentService
    {
        public void AddDataLoginTable(Login login)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"INSERT INTO LoginTable VALUES(@EmailId,@Password,@UserRole)";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", login.EmailId);
            command.Parameters.AddWithValue(@"Password", login.Password);
            command.Parameters.AddWithValue(@"UserRole", login.UserRole);
            command.ExecuteNonQuery();
        }
        public void AddStudentServices(StudentDetailsModel newstudent)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"INSERT INTO StudentDetails VALUES(@StudentName,@RegisterNumber,@EmailId,@PhoneNumber," +
                $"@Department,@Course,@StaffAdvisor,@CurrentSemester)";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"StudentName", newstudent.StudentName);
            command.Parameters.AddWithValue(@"RegisterNumber", newstudent.RegisterNumber);
            command.Parameters.AddWithValue(@"EmailId", newstudent.Emailid);
            command.Parameters.AddWithValue(@"PhoneNumber", newstudent.PhoneNumber);
            command.Parameters.AddWithValue(@"Department", newstudent.Department);
            command.Parameters.AddWithValue(@"course", newstudent.Course);
            command.Parameters.AddWithValue(@"StaffAdvisor", newstudent.StaffAdvisor);
            command.Parameters.AddWithValue(@"CurrentSemester", newstudent.CurrentSemester);
            command.ExecuteNonQuery();
        }
    }
}
