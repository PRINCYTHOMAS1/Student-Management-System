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
        private readonly string id;
        private Form previouswindow;
        public editteacher(string id,Form previousWindow)
        {
            InitializeComponent();
            this.id = id;
            this.previouswindow = previousWindow;
        }
        private void updateteacherbtn_Click(object sender, EventArgs e)
        {
            TeacherViewModel model = new TeacherViewModel();
            model.TeacherName = nameteachertxtbox.Text;
            model.TeacherId = IdteacherTxtbox.Text;
            model.Emailid = emailidteachertxtbox.Text;
            model.PhoneNumber = Convert.ToInt64(phnnoteachertxtbox.Text);
            model.Department = comboBox1.SelectedItem.ToString();
            model.Course = coursetxt.Text;
            EditTeacherServices teacherservices = new EditTeacherServices();
            int i = teacherservices.EditTeacherService(model);
            if (i != 0)
                MessageBox.Show("Teacher Details Updated");
        }

        private void Deleteteacherbtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete this Teacher", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                DeleteTeacherService teacherService = new DeleteTeacherService();
                int i = teacherService.DeleteTeacher(emailidteachertxtbox.Text);
                if (i != 0)
                    MessageBox.Show($"Teacher with Teacher Id {IdteacherTxtbox.Text} Deleted!!!!!!!");
                this.Close();
            }
        }

        private void editteacher_Load(object sender, EventArgs e)
        {
            EditTeacherServices edit = new EditTeacherServices();
            model = edit.TeacherGetByRegisterNumber(id);
            if (model == null)
            {
                MessageBox.Show("Incorrect Teacher Id");
                Close();
                return;
            }
            nameteachertxtbox.Text = model.TeacherName;
            IdteacherTxtbox.Text = model.TeacherId;
            phnnoteachertxtbox.Text = model.PhoneNumber.ToString();
            comboBox1.SelectedItem = model.Department;
            emailidteachertxtbox.Text = model.Emailid;
            comboBox1.SelectedItem = model.Department;
            coursetxt.Text = model.Course;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previouswindow.Show();
            Hide();
        }
    }

}

