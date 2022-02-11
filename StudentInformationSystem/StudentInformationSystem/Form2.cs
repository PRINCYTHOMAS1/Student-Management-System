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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void passwordbtn_Click(object sender, EventArgs e)
        {
            if (emailidtxt.Text == "" || !emailidtxt.Text.Contains("@gmail.com") || emailidtxt.Text.Contains(" "))
            {
                MessageBox.Show("Invalid user id try again");
                return;
            }
            if (passwordtxt.Text != confirmpasswordtxt.Text)
            {
                MessageBox.Show("password doesnt match");
                return ;
            }
            MessageBox.Show("Login with your new password");
            LoginForm loginpage=new LoginForm();
            loginpage.Show();

        }
        int loc = 10;
        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            this.Controls.Add(lbl);
            lbl.Top = loc * 15;
            lbl.Left = loc * 48;
            lbl.Width = 2000;
            lbl.Height = 1000;
            lbl.Text = "Password should contain atleast 8 characters\nIt should contain " +
                "atleast 1 upper Case and 1 special characters\n set a strong password ";
        }
    }
}
