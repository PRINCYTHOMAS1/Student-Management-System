using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Models;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class AdminService
    {
        public AdminDetails adminGetByEmail(string email)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM AdminTable WHERE EmailId=@EmailId";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"EmailId", email);
            var reader = command.ExecuteReader();
            AdminDetails adminDetails = null;
            while (reader.Read())
            {
                adminDetails = new AdminDetails();
                adminDetails.AdminName = reader.GetString(0);
                adminDetails.EmailId = reader.GetString(1);
                adminDetails.TeacherId = reader.GetString(2);
                adminDetails.PhoneNumber = reader.GetInt64(3);
                adminDetails.Qualification = reader.GetString(4);


            }
            reader.Close();
            return adminDetails;
        }
    }
}
