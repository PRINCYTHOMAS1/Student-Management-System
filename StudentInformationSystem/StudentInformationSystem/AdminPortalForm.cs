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
            new AddTeacher(this).Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(emailidtxtbox.Text,this);
            addStudentForm.Show();
            
        }

        private void editstudentbutton2_Click(object sender, EventArgs e)
        {
            EditStudentform edit = new EditStudentform(registertextBox.Text,this);
            edit.Show();
            
        }

        private void searchteacherbtn_click(object sender, EventArgs e)
        {
            _Id = teacherregistertextbox.Text;
            editteacher form = new editteacher(_Id,this);
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Log Out.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortForm form = new SortForm(comboBox1.SelectedItem.ToString(),this);
            form.Show();
        }
    }
}
