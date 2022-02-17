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
    internal class AddMarkService
    {
        public int AddMarkServices(AddMarks newstudent)

        {
            ConnectionManager.EnsureConnection();
            var sql = $"INSERT INTO StudentsMarks VALUES (@RegisterNumber,@Semester,@Subject1Mark,@Subject2Mark,@Subject3Mark)";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"RegisterNumber", newstudent.RegisterNumber);
            command.Parameters.AddWithValue("@Semester",newstudent.semester);
            command.Parameters.AddWithValue(@"Subject1Mark", newstudent.Subject1);
            command.Parameters.AddWithValue(@"Subject2Mark", newstudent.Subject2);
            command.Parameters.AddWithValue(@"Subject3Mark", newstudent.Subject3);
            int i= command.ExecuteNonQuery();
            return i;
        }
    }
}
