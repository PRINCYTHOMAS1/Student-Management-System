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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (useridtxtbox.Text == "" || !useridtxtbox.Text.Contains("@gmail.com") || useridtxtbox.Text.Contains(" "))
            {
                MessageBox.Show("Invalid user id try again");
                return;
            }
            if (Passwordtxtbox.Text == "")
            {
                MessageBox.Show("you forgot to enter password please enter a password");
                return ;
            }
            string emailiddd = useridtxtbox.Text;
            LoginClass loginobj = new LoginClass();
            int value=loginobj.GetById(useridtxtbox.Text, Passwordtxtbox.Text);
            if (value == 1)
            {
                StudentPortalForm studentportalform = new StudentPortalForm();
                studentportalform.pass(useridtxtbox.Text);
            }
            if (value == 2)
            {
                TeachersPortalForm teacherportal = new TeachersPortalForm();
                teacherportal.Show();
            }
            if (value == 3)
            {
                AdminPortalForm adminportal= new AdminPortalForm();
                adminportal.Show();
            }
            if (value == 0)
                MessageBox.Show("Incorrect UserId or Password try again!!");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm forgotpasswordForm = new ResetPasswordForm();
            forgotpasswordForm.Show();
        }
        int loc = 10;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl=new System.Windows.Forms.Label();
            this.Controls.Add(lbl);
            lbl.Top = loc * 15;
            lbl.Left = loc * 50;
            lbl.Width = 1000;
            lbl.Text = "Enter your Email Id as your user Id!!! ";
        }
    }
}
