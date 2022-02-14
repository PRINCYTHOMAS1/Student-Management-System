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
        public StudentPortalForm()
        {
            InitializeComponent();
            //StudentPortalForm_Load(object, EventArgs );
            
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        string password;
        public void pass(string userid)
        {
            password=userid;
        }
       
        private void StudentPortalForm_Load(object sender, EventArgs e)
        {
            
            StudentPortalService obj = new StudentPortalService();
            StudentDetailsModel model = new StudentDetailsModel();
            model=obj.studentdetails(password);
            StudentPortalForm form = new StudentPortalForm();
            form.nametxtbox.Text = model.StudentName;
            form.RegNoTxtbox.Text = model.RegisterNumber;
            form.emailidtxtbox.Text = model.Emailid;
            form.phnnotxtbox.Text = model.PhoneNumber.ToString();
            form.departmenttxtbox.Text = model.Department;
            form.branchtxtbox.Text = model.Course;
            form.staffadvisortxtbox.Text = model.StaffAdvisor;
            form.currentsemtxtbox.Text = model.CurrentSemester.ToString();
        }
       
    }
}
