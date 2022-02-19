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
    internal class FetchSubjectName
    {
        public SubjectNameClass GetSubjectNameByRegNo(string Course,string department,int sem)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"Select * from SubjectTable where Department=@department " +
                      $"And CourseName=@Course and Semester=@Semester";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@Course",Course);
            command.Parameters.AddWithValue("@department",department);
            command.Parameters.AddWithValue("@Semester",sem);
            var reader=command.ExecuteReader();
            SubjectNameClass subjectNameClass = null;
            while(reader.Read())
            {
                subjectNameClass = new SubjectNameClass();
                subjectNameClass.Semester = reader.GetInt32(0);
                subjectNameClass.CourseName = reader.GetString(1);
                subjectNameClass.Department = reader.GetString(2);
                subjectNameClass.subjectName1 = reader.GetString(3);
                subjectNameClass.subjectName2 = reader.GetString(4);
                subjectNameClass.subjectName3=reader.GetString(5);
            }
            reader.Close();
            return subjectNameClass;
        }
    }
}
