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
        
        public int DeleteStudentStudentMarksTable( string RegisterNumber,string EmailId)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"DELETE FROM StudentsMarks where RegisterNumber=@RegisterNumber;" +
                $"delete from StudentDetails where StudentDetails.Emailid=@EmailId;" +
                $"delete from LoginTable where LoginTable.EmailId = @EmailId; ";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@RegisterNumber", RegisterNumber);
            command.Parameters.AddWithValue("@EmailId", EmailId);
            int i=command.ExecuteNonQuery();
            return i;
        }
    }
}