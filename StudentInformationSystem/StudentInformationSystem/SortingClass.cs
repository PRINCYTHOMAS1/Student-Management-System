using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Models;
using StudentInformationSystem.Services;
using System.Data;
using System.Data.SqlClient;

namespace StudentInformationSystem
{
    internal class SortingClass
    {
        public StudentDetailsModel[] Sorting(string sort)
        {
            StudentDetailsModel[] students = new StudentDetailsModel[100];
            ConnectionManager.EnsureConnection();
            StudentDetailsModel student = null;
            int i = 0;
            if (sort == "Computer Science" || sort == "Electronics")
            {
                var sql = $"Select * from StudentDetails where Department=@department ";
                var command = new SqlCommand(sql, ConnectionManager.connection);
                command.Parameters.AddWithValue("@department", sort);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    student = new StudentDetailsModel();
                    student.StudentName = reader.GetString(0);
                    student.RegisterNumber = reader.GetString(1);
                    student.Emailid = reader.GetString(2);
                    student.PhoneNumber = reader.GetInt64(3);
                    student.Department = reader.GetString(4);
                    student.Course = reader.GetString(5);
                    student.StaffAdvisor = reader.GetString(6);
                    student.CurrentSemester = reader.GetInt32(7);
                    students[i] = student;
                    i = i + 1;
                }
                reader.Close();
            }
            if (sort == "Computer Science and Engineering" || sort == "IT" || sort == "Electronics and Communication Engineering" || sort == "Electrical and Electronics Engineering")
            {
                var sql = $"Select * from StudentDetails where Course=@Course ";
                var command = new SqlCommand(sql, ConnectionManager.connection);
                command.Parameters.AddWithValue("@Course", sort);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    student = new StudentDetailsModel();
                    student.StudentName = reader.GetString(0);
                    student.RegisterNumber = reader.GetString(1);
                    student.Emailid = reader.GetString(2);
                    student.PhoneNumber = reader.GetInt64(3);
                    student.Department = reader.GetString(4);
                    student.Course = reader.GetString(5);
                    student.StaffAdvisor = reader.GetString(6);
                    student.CurrentSemester = reader.GetInt32(7);
                    students[i] = student;
                    i = i + 1;
                }
                reader.Close();
            }
            if (sort.Contains("1") || sort.Contains("2") || sort.Contains("3") || sort.Contains("4"))
            {
                int sem = Convert.ToInt32(sort);
                var sql = $"Select * from StudentDetails where CurrentSemester=@sem ";
                var command = new SqlCommand(sql, ConnectionManager.connection);
                command.Parameters.AddWithValue("@sem", sem);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    student = new StudentDetailsModel();
                    student.StudentName = reader.GetString(0);
                    student.RegisterNumber = reader.GetString(1);
                    student.Emailid = reader.GetString(2);
                    student.PhoneNumber = reader.GetInt64(3);
                    student.Department = reader.GetString(4);
                    student.Course = reader.GetString(5);
                    student.StaffAdvisor = reader.GetString(6);
                    student.CurrentSemester = reader.GetInt32(7);
                    students[i] = student;
                    i = i + 1;
                }
                reader.Close();
            }
            return students;
        }
        public StudentDetailsModel[] Sorting(string sort1, string sort2, int sort3)
        {
            StudentDetailsModel[] students = new StudentDetailsModel[100];
            ConnectionManager.EnsureConnection();
            StudentDetailsModel student = null;
            int i = 0;

            var sql = $"Select * from StudentDetails where Department=@department and Course=@course and CurrentSemester=@sem;";
            var command = new SqlCommand(sql, ConnectionManager.connection);
            command.Parameters.AddWithValue("@department", sort1);
            command.Parameters.AddWithValue("@course", sort2);
            command.Parameters.AddWithValue("@sem", sort3);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                student = new StudentDetailsModel();
                student.StudentName = reader.GetString(0);
                student.RegisterNumber = reader.GetString(1);
                student.Emailid = reader.GetString(2);
                student.PhoneNumber = reader.GetInt64(3);
                student.Department = reader.GetString(4);
                student.Course = reader.GetString(5);
                student.StaffAdvisor = reader.GetString(6);
                student.CurrentSemester = reader.GetInt32(7);
                students[i] = student;
                i = i + 1;
            }
            reader.Close();
            return students;
        }
    }
}
