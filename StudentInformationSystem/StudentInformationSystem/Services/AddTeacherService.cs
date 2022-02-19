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
        public int AddTeacherServices(TeacherViewModel newTeacher,string password)
        {
            try
            {
                ConnectionManager.EnsureConnection();
                var sql = $"INSERT INTO LoginTable Values(@EmailId,@password,@userrole);" +
                    $"INSERT INTO TeacherDetails VALUES(@TeacherName,@TeacherId,@PhoneNumber,@EmailId, @Department,@Course)";

                var command = new SqlCommand(sql, ConnectionManager.connection);
                command.Parameters.AddWithValue(@"password", password);
                command.Parameters.AddWithValue(@"userrole", "Teacher");
                command.Parameters.AddWithValue(@"TeacherName", newTeacher.TeacherName);
                command.Parameters.AddWithValue(@"TeacherId", newTeacher.TeacherId);
                command.Parameters.AddWithValue(@"EmailId", newTeacher.Emailid);
                command.Parameters.AddWithValue(@"PhoneNumber", newTeacher.PhoneNumber);
                command.Parameters.AddWithValue(@"Department", newTeacher.Department);
                command.Parameters.AddWithValue(@"Course", newTeacher.Course);
                int i = command.ExecuteNonQuery();
                return i;
            }
            catch (Exception) { return 0; }
        }
    }

}
