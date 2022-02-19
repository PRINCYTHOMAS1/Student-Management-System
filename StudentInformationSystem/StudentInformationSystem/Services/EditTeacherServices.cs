using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Services
{
    internal class EditTeacherServices
    {
        public TeacherViewModel TeacherGetByRegisterNumber(string TeacherId)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM TeacherDetails WHERE TeacherId=@TeacherId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"TeacherId",TeacherId);
            var reader = command.ExecuteReader();
            TeacherViewModel teacherView = null;
            while (reader.Read())
            {
                teacherView = new TeacherViewModel();
                teacherView.TeacherName = reader.GetString(0);
                teacherView.TeacherId = reader.GetString(1);
                teacherView.PhoneNumber = reader.GetInt64(2);
                teacherView.Emailid = reader.GetString(3);
                teacherView.Department = reader.GetString(4);
                teacherView.Course = reader.GetString(5);
            }
            reader.Close();
            return teacherView;
        }
        public int EditTeacherService(TeacherViewModel editteacher)

        {
            ConnectionManager.EnsureConnection();
                var sql = $"UPDATE TeacherDetails SET TeacherName = @TeacherName,TeacherId=@TeacherId," +
                    $"PhoneNumber=@PhoneNumber,EmailId=@EmailId,Department=@Department,Course=@Course WHERE TeacherId=@TeacherId   ";
                var command = new SqlCommand(sql, ConnectionManager.connection);
                command.Parameters.AddWithValue(@"TeacherName", editteacher.TeacherName);
                command.Parameters.AddWithValue(@"TeacherId", editteacher.TeacherId);
                command.Parameters.AddWithValue(@"PhoneNumber", editteacher.PhoneNumber);
                command.Parameters.AddWithValue(@"EmailId", editteacher.Emailid);
                command.Parameters.AddWithValue(@"Department", editteacher.Department);
                command.Parameters.AddWithValue(@"course", editteacher.Course);
                int i = command.ExecuteNonQuery();
                return i;
           
        }
    }
}
