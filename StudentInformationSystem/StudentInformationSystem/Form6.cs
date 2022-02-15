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
    public partial class teacherView : Form
    {
        private readonly string _email;
        private readonly TeacherViewProfile _service;
        public teacherView(string email)
        {
            InitializeComponent();
            _email = email;
            _service = new TeacherViewProfile();
            var model = _service.GetByEmail(email);
            Nametxtbox.Text = model.StudentName;

            emailtxtbox.Text = model.Emailid;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            dpttxtbox.Text = model.Department;
            branchtxtbox.Text = model.Course;
            teacherIdtxtbox.Text = model.TeacherId;


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}
