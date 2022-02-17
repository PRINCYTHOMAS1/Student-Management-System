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
    public partial class EditStudentform : Form
    {
        private StudentDetailsModel model;

        public EditStudentform (string regno)
        {
            InitializeComponent();
            EditStudentServices edit=new EditStudentServices();
            model= edit.StudentGetByRegisterNumber(regno);
            nametxtbox.Text = model.StudentName;
            RegNoTxtbox.Text = model.RegisterNumber;
            emailidtxtbox.Text = model.Emailid;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            departmenttxtbox.Text = model.Department;
            branchtxtbox.Text = model.Course;
            staffadvisortxtbox.Text = model.StaffAdvisor;
            currentsemtxtbox.Text = model.CurrentSemester.ToString();

        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            StudentDetailsModel studentmodel = new StudentDetailsModel();
            studentmodel.StudentName = nametxtbox.Text;
            studentmodel.RegisterNumber= RegNoTxtbox.Text;
            studentmodel.Emailid= emailidtxtbox.Text;
            studentmodel.PhoneNumber = Convert.ToInt64(phnnotxtbox.Text);
            studentmodel.Department= departmenttxtbox.Text;
            studentmodel.Course= branchtxtbox.Text;
            studentmodel.StaffAdvisor= staffadvisortxtbox.Text;
            studentmodel.CurrentSemester=Convert.ToInt32(currentsemtxtbox.Text);
            EditStudentServices studentServices = new EditStudentServices();
            int i = studentServices.EditStudentService(studentmodel);
            if (i != 0)
                MessageBox.Show("Student Details Updated");
        }

        private void AddMarksBtn_Click(object sender, EventArgs e)
        {
            new addmark(RegNoTxtbox.Text).Show();
        }

        private void Deletestudentbtn_Click(object sender, EventArgs e)
        {
            DeleteStudentService studentService = new DeleteStudentService();
            int i= studentService.DeleteStudentStudentMarksTable(RegNoTxtbox.Text,emailidtxtbox.Text);
            if (i != 0)
                MessageBox.Show($"Student with Register Number {RegNoTxtbox.Text} Deleted!!!!!!!");
            this.Close();
        }
    }
}
