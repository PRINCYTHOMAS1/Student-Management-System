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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherViewModel TeacherViewModel = new TeacherViewModel();
            TeacherViewModel.TeacherName = Nametxtbox.Text;
            TeacherViewModel.TeacherId = teacheridtxtbox.Text;
            TeacherViewModel.Emailid = emailidtxtbox.Text;
            TeacherViewModel.PhoneNumber = phnnotxtbox.Text;
            TeacherViewModel.Department = departmenttxtbox.Text;
            TeacherViewModel.Course = course.Text;

        }
    }
}
