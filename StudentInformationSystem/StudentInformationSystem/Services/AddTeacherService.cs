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
    internal class AddTeacherService
    {
        public void AddTeacherServices(TeacherViewModel newTeacher)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"INSERT INTO TeacherDetails VALUES(@TeacherName,@TeacherId,@EmailId,@PhoneNumber, @Department,@Course)";

            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"TeacherName", newTeacher.TeacherName);
            command.Parameters.AddWithValue(@"TeacherId", newTeacher.TeacherId);
            command.Parameters.AddWithValue(@"EmailId", newTeacher.Emailid);
            command.Parameters.AddWithValue(@"PhoneNumber", newTeacher.PhoneNumber);
            command.Parameters.AddWithValue(@"Department", newTeacher.Department);
            command.Parameters.AddWithValue(@"Course", newTeacher.Course);
            command.ExecuteNonQuery();
        }
    }

}
