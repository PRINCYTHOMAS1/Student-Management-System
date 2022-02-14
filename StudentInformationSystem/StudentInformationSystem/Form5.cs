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
            studentDetailsModel.Emailid = emailidtxtbox.Text;
            studentDetailsModel.RegisterNumber=regtextbox.Text;
            studentDetailsModel.PhoneNumber =Convert.ToInt64(phonenumbertxtbox.Text);
            studentDetailsModel.Course=bracnchtxtbox.Text;
            studentDetailsModel.CurrentSemester = Convert.ToInt32(currentsemcomboBox.SelectedItem);
            studentDetailsModel.StaffAdvisor=staffadvisortxtbox.Text;


        }
    }
}
