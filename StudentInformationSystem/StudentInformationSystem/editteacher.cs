using StudentInformationSystem.Models;
using StudentInformationSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class editteacher : Form
    {
        private TeacherViewModel model;
        public editteacher(string id)
        {
            InitializeComponent();
            EditTeacherServices edit = new EditTeacherServices();
            model = edit.TeacherGetByRegisterNumber(id);
            nameteachertxtbox.Text = model.TeacherName;
            IdteacherTxtbox.Text = model.TeacherId;
            phnnoteachertxtbox.Text = model.PhoneNumber.ToString();
            emailidteachertxtbox.Text = model.Emailid;
            departmenttxtbox.Text = model.Department;
            coursetxt.Text = model.Course;
        }
        private void updateteacherbtn_Click(object sender, EventArgs e)
        {
            TeacherViewModel model = new TeacherViewModel();
            model.TeacherName = nameteachertxtbox.Text;
            model.TeacherId = IdteacherTxtbox.Text;
            model.Emailid = emailidteachertxtbox.Text;
            model.PhoneNumber = Convert.ToInt64(phnnoteachertxtbox.Text);
            model.Department = departmenttxtbox.Text;
            model.Course = coursetxt.Text;
            EditTeacherServices teacherservices = new EditTeacherServices();
            int i = teacherservices.EditTeacherService(model);
            if (i != 0)
                MessageBox.Show("Student Details Updated");
        }
    }

}

