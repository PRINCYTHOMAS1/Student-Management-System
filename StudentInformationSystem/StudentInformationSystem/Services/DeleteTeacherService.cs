using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class DeleteTeacherService
    {
        public int DeleteTeacher(string EmailId)
        {
            ConnectionManager.EnsureConnection();
            var sql =  $"delete from TeacherDetails where TeacherDetails.EmailId=@EmailId;" +
                      $"delete from LoginTable where LoginTable.EmailId = @EmailId; ";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@EmailId", EmailId);
            int i = command.ExecuteNonQuery();
            return i;
        }
    }
}
