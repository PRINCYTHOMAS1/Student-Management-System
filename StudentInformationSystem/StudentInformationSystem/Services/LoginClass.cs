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
    internal class LoginClass
    {
        public void GetById(string UserId,String password )
        {
            ConnectionManager.connection.Open();
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT {nameof(Models.Login.EmailId)},{nameof(Models.Login.Password)},{nameof(Models.Login.UserRole)} FROM {nameof(Models.Login)} WHERE {nameof (Models.Login.EmailId)} = @EmailId && {nameof(Models.Login.Password)}=@password";
            var command=new SqlCommand( sql,ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId",UserId);
            command.Parameters.AddWithValue(@"password", password);
            var reader = command.ExecuteReader();
            var Login = new Login();
            while( reader.Read() )
            {
                Login.EmailId = reader.GetString(0);
                Login.Password =reader.GetString(1);
            }
            if (Login.UserRole == "Student")
            {
                StudentPortalForm studentPortalForm = new StudentPortalForm();
                studentPortalForm.Show();
            }
            if (Login.UserRole == "Teacher")
            {
                TeachersPortalForm teacherportal=new TeachersPortalForm();
                teacherportal.Show();
            }
            //if (Login.Role == "Admin")
            //{
            //    StudentPortalForm studentPortalForm = new StudentPortalForm();
            //    studentPortalForm.Show();
            //}
            reader.Close();
        }
    }
}
