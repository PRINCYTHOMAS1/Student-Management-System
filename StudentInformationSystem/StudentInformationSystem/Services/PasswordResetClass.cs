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
    internal class PasswordResetClass
    {
        public Login GetLoginEmail(string email)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM LoginTable WHERE EmailId=@EmailId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", email);
            var reader = command.ExecuteReader();
            Login login = null;
            while (reader.Read())
            {
                login = new Login();
                login.EmailId = reader.GetString(0);
                login.Password = reader.GetString(1);
                login.UserRole = reader.GetString(2);
            }
            reader.Close();
            return login;
        }
        
        public int UpdatePassword(Login login)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"UPDATE LoginTable SET Password=@Password WHERE EmailId=@EmailId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", login.EmailId);
            command.Parameters.AddWithValue("@Password", login.Password);
            int i= command.ExecuteNonQuery();
            return i;
        }
    }
}
