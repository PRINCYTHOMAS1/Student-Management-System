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
            for(int i=1;i<=Convert.ToInt32(currentsemtxtbox.Text);i++)
            {
                SemcomboBox.Items.Add(i);
            }
        }
        private string registernumber;

        private void button1_Click(object sender, EventArgs e)
        {
            registernumber = RegNoTxtbox.Text;
            ViewMarksService mark = new ViewMarksService();
            AddMarks model = null;
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 1)
            {
                model = new AddMarks();
                sub1textBox.Text = "C ++";
                sub2textBox.Text = "Python";
                sub3textBox.Text = "Java";
                model = mark.ViewMarks(registernumber, 1);
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 2)
            { 
                model = new AddMarks();
                sub1textBox.Text = "PHP";
                sub2textBox.Text = "HTML";
                sub3textBox.Text = "CSS";
                model = mark.ViewMarks(registernumber, 2);
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 3)
            {
                model = new AddMarks();
                sub1textBox.Text = "C Sharp";
                sub2textBox.Text = "Android";
                sub3textBox.Text = "Cloud Computing";
                model = mark.ViewMarks(registernumber, 3);
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 4)
            {
                model = new AddMarks();
                sub1textBox.Text = "Web Development";
                sub2textBox.Text = "DBMS";
                sub3textBox.Text = "DOT NET";
                model = mark.ViewMarks(registernumber, 4);
            }
            if(model == null)
            {
                MessageBox.Show("The mark list is empty.");
                return;
            }
            SemcomboBox.SelectedItem = model.semester.ToString();
            RegNoTxtbox.Text = model.RegisterNumber;
            mark1textBox.Text = model.Subject1.ToString();
            mark2txtbox.Text = model.Subject2.ToString();
            mark3textBox.Text = model.Subject3.ToString();
        }

        private void SemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
