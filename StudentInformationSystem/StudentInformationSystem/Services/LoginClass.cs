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
        public Login GetByEmailAndPassword(string email, string password)
        {
            ConnectionManager.EnsureConnection();
            //var sql = $"SELECT {nameof(Login.EmailId)},{nameof(Login.Password)},{nameof(Login.UserRole)} FROM {nameof(Login)} WHERE {nameof (Login.EmailId)} = @EmailId AND {nameof(Login.Password)}=@password";
            var sql = $"SELECT EmailId,Password,UserRole FROM LoginTable WHERE Password=@password And EmailId=@EmailId";
            var command=new SqlCommand( sql,ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", email);
            command.Parameters.AddWithValue(@"password", password);
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
    }
}
