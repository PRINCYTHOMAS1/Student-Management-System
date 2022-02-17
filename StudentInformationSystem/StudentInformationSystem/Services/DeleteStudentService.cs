using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Models;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class DeleteStudentService
    {
        
        public void DeleteStudentServices()
        {
            ConnectionManager.EnsureConnection();
            var sql = $"DELETE FROM StudentDetails WHERE RegisterNumber=@RegisterNumber ";
            var command = new SqlCommand(sql, ConnectionManager.connection);

            command.ExecuteNonQuery();
              
        }
    }
}