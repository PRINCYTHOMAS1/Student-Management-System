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
        
        public void DeleteStudentStudentMarksTable( string RegisterNumber)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"DELETE FROM StudentsMarks where RegisterNumber=@RegisterNumber";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@RegisterNumber", RegisterNumber);
            command.ExecuteNonQuery();
              
        }
        public void DeleteStudentStudentDetailsTable(string Emailid)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"DELETE StudentDetails , LoginTable USING StudentDetails INNER JOIN LoginTable ON " +
                $"StudentDetails.Emailid = LoginTable.EmailId WHERE StudentTable.Emailid = @Emailid";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@Emailid", Emailid);
            command.ExecuteNonQuery();
        }
        
    }
}