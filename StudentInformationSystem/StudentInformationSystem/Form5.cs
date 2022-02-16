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
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StudentDetailsModel studentDetailsModel = new StudentDetailsModel();
            studentDetailsModel.StudentName = Nametxtbox.Text;
            studentDetailsModel.RegisterNumber = regnotxtbox.Text;
            studentDetailsModel.Emailid = emailidtxtbox.Text;
            try
            {
                studentDetailsModel.PhoneNumber = Convert.ToInt64(emailidtxtbox.Text);
            }
            catch (Exception ) { }
            studentDetailsModel.Department = departmenttxtbox.Text;
            studentDetailsModel.Course = branchtxtbox.Text;
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
    }
}
