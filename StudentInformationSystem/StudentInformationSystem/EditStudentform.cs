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
        //private EditStudentServices studentServices;

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
        private void nametxtbox_TextChanged(object sender, EventArgs e)
        {
            model.StudentName = nametxtbox.Text;
        }

        private void RegNoTxtbox_TextChanged(object sender, EventArgs e)
        {
            model.RegisterNumber = RegNoTxtbox.Text;
        }

        private void emailidtxtbox_TextChanged(object sender, EventArgs e)
        {
            model.Emailid = emailidtxtbox.Text;
        }

        private void phnnotxtbox_TextChanged(object sender, EventArgs e)
        {
            model.PhoneNumber = Convert.ToInt64(phnnotxtbox.Text) ;
        }

        private void departmenttxtbox_TextChanged(object sender, EventArgs e)
        {
            model.Department = departmenttxtbox.Text;
        }

        private void branchtxtbox_TextChanged(object sender, EventArgs e)
        {
            model.Course=branchtxtbox.Text; 
        }

        private void staffadvisortxtbox_TextChanged(object sender, EventArgs e)
        {
            model.StaffAdvisor=staffadvisortxtbox.Text;
        }

        private void currentsemtxtbox_TextChanged(object sender, EventArgs e)
        {
            model.CurrentSemester=Convert.ToInt32(currentsemtxtbox.Text) ;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {

            EditStudentServices studentServices = new EditStudentServices();
            int i = studentServices.EditStudentService(model);
            if (i != 0)
                MessageBox.Show("Student Details Updated");
        }

    }
}
