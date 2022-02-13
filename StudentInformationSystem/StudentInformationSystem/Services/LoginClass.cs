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
        int i;
        public int GetById(string UserId,String password )
        {
            ConnectionManager.EnsureConnection();
            //var sql = $"SELECT {nameof(Login.EmailId)},{nameof(Login.Password)},{nameof(Login.UserRole)} FROM {nameof(Login)} WHERE {nameof (Login.EmailId)} = @EmailId AND {nameof(Login.Password)}=@password";
            var sql = $"SELECT EmailId,Password,UserRole FROM LoginTable WHERE Password=@password And EmailId=@EmailId";
            var command=new SqlCommand( sql,ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId",UserId);
            command.Parameters.AddWithValue(@"password", password);
            var reader = command.ExecuteReader();
            var loginn= new Models.Login();
            while (reader.Read())
            {
                loginn.EmailId = reader.GetString(0);
                loginn.Password = reader.GetString(1);
                loginn.UserRole = reader.GetString(2);
            }
            reader.Close();
            if (loginn.UserRole == "Student")
                i = 1;
            if (loginn.UserRole == "Teacher")
                i = 2;
            if (loginn.UserRole == "Admin")
                i = 3;
            return i; 
        }
    }
}
