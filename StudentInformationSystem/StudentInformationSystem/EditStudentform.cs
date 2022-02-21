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
        private string registerno;
        private readonly Form PreviousWindow;

        public EditStudentform (string regno, Form previousWindow)
        {
            InitializeComponent();
            registerno = regno;
            this.PreviousWindow = previousWindow;

        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            StudentDetailsModel studentmodel = new StudentDetailsModel();
            studentmodel.StudentName = nametxtbox.Text;
            studentmodel.RegisterNumber= RegNoTxtbox.Text;
            studentmodel.Emailid= emailidtxtbox.Text;
            studentmodel.PhoneNumber = Convert.ToInt64(phnnotxtbox.Text);
            studentmodel.Department= depcomboBox1.SelectedItem.ToString();
            studentmodel.Course= coursecomboBox2.SelectedItem.ToString();
            studentmodel.StaffAdvisor= staffadvisortxtbox.Text;
            studentmodel.CurrentSemester=Convert.ToInt32(currentsemtxtbox.Text);
            EditStudentServices studentServices = new EditStudentServices();
            int i = studentServices.EditStudentService(studentmodel);
            if (i != 0)
                MessageBox.Show("Student Details Updated");
        }

        private void AddMarksBtn_Click(object sender, EventArgs e)
        {
            new addmark(RegNoTxtbox.Text,currentsemtxtbox.Text,this,coursecomboBox2.SelectedItem.ToString(),depcomboBox1.SelectedItem.ToString()).Show();
             
        }

        private void Deletestudentbtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete this Student", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res==DialogResult.Yes)
            {
                DeleteStudentService studentService = new DeleteStudentService();
                int i = studentService.DeleteStudentStudentMarksTable(RegNoTxtbox.Text, emailidtxtbox.Text);

                if (i != 0)
                    MessageBox.Show($"Student with Register Number {RegNoTxtbox.Text} Deleted!");
            }
            this.Close();
        }

        private void EditStudentform_Load(object sender, EventArgs e)
        {
            EditStudentServices edit = new EditStudentServices();
            model = edit.StudentGetByRegisterNumber(registerno);
            if(model == null)
            {
                MessageBox.Show("Incorrect Sudent Register number");
                Close();
                return;
            }
            nametxtbox.Text = model.StudentName;
            RegNoTxtbox.Text = model.RegisterNumber;
            emailidtxtbox.Text = model.Emailid;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            depcomboBox1.SelectedItem = model.Department;
            if (depcomboBox1.SelectedItem.ToString() == "Computer Science")
            {
                coursecomboBox2.Items.Add("Computer Science and Engineering");
                coursecomboBox2.Items.Add("IT");
            }
            if (depcomboBox1.SelectedItem.ToString() == "Electronics")
            {
                coursecomboBox2.Items.Add("Electronics and Communication Engineering");
                coursecomboBox2.Items.Add("Electrical and Electronics Engineering");
            }
            coursecomboBox2.SelectedItem = model.Course;
            staffadvisortxtbox.Text = model.StaffAdvisor;
            currentsemtxtbox.Text = model.CurrentSemester.ToString();

        }

        private void HOME_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PreviousWindow.Show();
            Hide();
        }

        private void depcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coursecomboBox2.Items.Clear();
            if (depcomboBox1.SelectedItem.ToString() == "Computer Science")
            {
                coursecomboBox2.Items.Add("Computer Science and Engineering");
                coursecomboBox2.Items.Add("IT");
            }
            if (depcomboBox1.SelectedItem.ToString() == "Electronics")
            {
                coursecomboBox2.Items.Add("Electronics and Communication Engineering");
                coursecomboBox2.Items.Add("Electrical and Electronics Engineering");
            }
        }
    }
}
