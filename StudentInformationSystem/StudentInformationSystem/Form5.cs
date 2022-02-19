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
    public partial class AddStudentForm : Form
    {
        private string Email;
        private readonly Form previousWindow;

        public AddStudentForm(string email, Form previousWindow)
        {
            InitializeComponent();
            Email = email;
            this.previousWindow = previousWindow;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StudentDetailsModel studentDetailsModel = new StudentDetailsModel();
            studentDetailsModel.StudentName = Nametxtbox.Text;
            studentDetailsModel.RegisterNumber = regnotxtbox.Text;
            studentDetailsModel.Emailid = emailidtxtbox.Text;
            studentDetailsModel.PhoneNumber = Convert.ToInt64(phnnotxtbox.Text);
            studentDetailsModel.Department = depcomboBox.SelectedItem.ToString();
            studentDetailsModel.Course =CoursecomboBox.SelectedItem.ToString();
            studentDetailsModel.StaffAdvisor = staffadvisortxtbox.Text;
            studentDetailsModel.CurrentSemester = Convert.ToInt32(currentsemcomboBox.SelectedItem);


            Login login    = new Login();
            login.EmailId  = emailidtxtbox.Text;
            login.Password = passwordtxtbox.Text;
            login.UserRole = "Student";

            AddStudentService newservice = new AddStudentService();
            newservice.AddDataLoginTable(login);
            newservice.AddStudentServices(studentDetailsModel);
        }

        private void depcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoursecomboBox.Items.Clear();   
            if (depcomboBox.SelectedItem.ToString() == "Computer Science")
            {
                CoursecomboBox.Items.Add("Computer Science and Engineering");
                CoursecomboBox.Items.Add("BSC computer Science");
            }
            if (depcomboBox.SelectedItem.ToString() == "Electronics")
            {
                CoursecomboBox.Items.Add("Electronics and communication Engineering");
                CoursecomboBox.Items.Add("Electrical and Electronics Engineering");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousWindow.Show();
            this.Close();
        }
    }
}
