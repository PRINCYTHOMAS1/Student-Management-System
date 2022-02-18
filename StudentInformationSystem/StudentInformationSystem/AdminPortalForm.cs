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
    public partial class AdminPortalForm : Form
    {
        private  AdminService _service;
        private string _Id;
        
        public AdminPortalForm(string emailId)
        {
            InitializeComponent();
            _service = new AdminService();
            var model = _service.adminGetByEmail(emailId);
            nametxtbox.Text = model.AdminName;
            Qualificationtxtbox.Text = model.Qualification;
            emailidtxtbox.Text = model.EmailId;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            TeacherIdtxtbox.Text = model.TeacherId;
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            new AddTeacher().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void editstudentbutton2_Click(object sender, EventArgs e)
        {
            EditStudentform edit = new EditStudentform(registertextBox.Text);
            edit.Show();
        }

        private void editteacherbutton_Click(object sender, EventArgs e)
        {
            _Id = teacherregistertextbox.Text;
            editteacher form = new editteacher(_Id);
            form.Show();

        }
    }
}
