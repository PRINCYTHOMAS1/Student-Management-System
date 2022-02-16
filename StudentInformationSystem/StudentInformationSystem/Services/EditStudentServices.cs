using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Models;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class EditStudentServices
    {
        public StudentDetailsModel StudentGetByRegisterNumber(string registerNumber)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"SELECT * FROM StudentDetails WHERE RegisterNumber=@RegisterNumber";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"RegisterNumber", registerNumber);
            var reader = command.ExecuteReader();
            StudentDetailsModel studentDetails = null;
            while (reader.Read())
            {
                studentDetails = new StudentDetailsModel();
                studentDetails.StudentName = reader.GetString(0);
                studentDetails.RegisterNumber= reader.GetString(1);
                studentDetails.Emailid = reader.GetString(2);
                studentDetails.PhoneNumber = reader.GetInt64(3);
                studentDetails.Department = reader.GetString(4);
                studentDetails.Course = reader.GetString(5);
                studentDetails.StaffAdvisor = reader.GetString(6);
                studentDetails.CurrentSemester = reader.GetInt32(7);


            }
            reader.Close();
            return studentDetails;
        }

        public void EditStudentService(StudentDetailsModel editstudent)
        {
            ConnectionManager.EnsureConnection();
            var sql = $"UPDATE StudentDetails SET StudentName = @StudentName,RegisterNumber=@RegisterNumber+" +
                $"EmailId = @EmailId,PhoneNumber=@PhoneNumber,Department=@Department,Course=@Course,StaffAdvisor=@StaffAdvisor" +
                $"CurrentSemester=@CurrentSemester WHERE RegisterNumber=@RegisterNumber";
                
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue(@"StudentName", editstudent.StudentName);
            command.Parameters.AddWithValue(@"RegisterNumber", editstudent.RegisterNumber);
            command.Parameters.AddWithValue(@"EmailId", editstudent.Emailid);
            command.Parameters.AddWithValue(@"PhoneNumber", editstudent.PhoneNumber);
            command.Parameters.AddWithValue(@"Department", editstudent.Department);
            command.Parameters.AddWithValue(@"course", editstudent.Course);
            command.Parameters.AddWithValue(@"StaffAdvisor", editstudent.StaffAdvisor);
            command.Parameters.AddWithValue(@"CurrentSemester", editstudent.CurrentSemester);
            command.ExecuteNonQuery();
        }
    }
}
