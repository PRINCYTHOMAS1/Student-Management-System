using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationSystem.Services;
using StudentInformationSystem.Models;

namespace StudentInformationSystem
{
    public partial class StudentPortalForm : Form
    {
        private readonly string _email;
        private readonly StudentDetailsService _service;
        public StudentPortalForm(string email)
        {
            InitializeComponent();
            _email = email;
            _service = new StudentDetailsService();
            var model = _service.GetByEmail(email);
            nametxtbox.Text = model.StudentName;
            RegNoTxtbox.Text = model.RegisterNumber;
            emailidtxtbox.Text = model.Emailid;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            departmenttxtbox.Text = model.Department;
            branchtxtbox.Text = model.Course;
            staffadvisortxtbox.Text = model.StaffAdvisor;
            currentsemtxtbox.Text = model.CurrentSemester.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
