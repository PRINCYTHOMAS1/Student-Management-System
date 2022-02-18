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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherViewModel TeacherViewModel = new TeacherViewModel();
            TeacherViewModel.TeacherName= Nametxtbox.Text;
            TeacherViewModel.TeacherId = teacheridtxtbox.Text;
            TeacherViewModel.Emailid = emailidtxtbox.Text;
            TeacherViewModel.PhoneNumber =Convert.ToInt64(phnnotxtbox.Text);
            TeacherViewModel.Department = departmenttxtbox.Text;
            TeacherViewModel.Course = course.Text;
            AddTeacherService addteacher=new AddTeacherService();
            int i = addteacher.AddTeacherServices(TeacherViewModel,passwordtextBox.Text);
            if(i!=0)
            {
                MessageBox.Show("Teacher Profile Added");
            }
            this.Close();
        }
    }
}
