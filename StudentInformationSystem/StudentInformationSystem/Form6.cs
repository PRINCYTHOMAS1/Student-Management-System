using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationSystem.Models;
using StudentInformationSystem.Services;

namespace StudentInformationSystem
{
    public partial class TeacherViewForm : Form
    {
        private readonly string _email;
        private string _RegNo;
        private readonly TeacherViewProfileService _service;
        public TeacherViewForm(string email)
        {
            InitializeComponent();
            _email = email;
            _service = new TeacherViewProfileService();
            var model = _service.TeacherGetByEmail(_email);
            Nametxtbox.Text = model.TeacherName;
            emailtxtbox.Text = model.Emailid;
            try
            {
                phnnotxtbox.Text = model.PhoneNumber.ToString();
            }
            catch (Exception) { }
            dpttxtbox.Text = model.Department;
            branchtxtbox.Text = model.Course;
            teacherIdtxtbox.Text = model.TeacherId;
        }

        private void AddnewStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudent = new AddStudentForm();
            addstudent.Show();
        }

        private void Viewstudentbtn_Click(object sender, EventArgs e)
        {
            _RegNo = RegNoTxtbox.Text;
            EditStudentform form = new EditStudentform(_RegNo);
            form.Show();
        }
    }
}
