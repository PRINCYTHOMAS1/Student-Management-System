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
            LoginClass loginobj = new LoginClass();
            loginobj.GetById(useridtxtbox.Text, Passwordtxtbox.Text);
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
