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
    internal class ViewMarksService
    {
        public AddMarks ViewMarks(string registernumber , int semester)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM StudentsMarks Where RegisterNumber=@registernumber AND Semester=@semester";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"RegisterNumber",registernumber);
            command.Parameters.AddWithValue(@"semester",semester);
            var reader = command.ExecuteReader();
            AddMarks viewmarks = null;
            while (reader.Read())
            {
                viewmarks = new AddMarks();
                viewmarks.semester =reader.GetInt32(1);
                viewmarks.RegisterNumber = reader.GetString(0);
                viewmarks.Subject1 = reader.GetInt32(2);
                viewmarks.Subject2 = reader.GetInt32(3);
                viewmarks.Subject3 = reader.GetInt32(4);
            }
            reader.Close();
            return viewmarks;
        }
    }
    
}
