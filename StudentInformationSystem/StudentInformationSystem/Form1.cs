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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(useridtxtbox.Text =="" || !useridtxtbox.Text.Contains("@gmail.com") || useridtxtbox.Text.Contains(" "))
                MessageBox.Show("Invalid user id try again");
            if (Passwordtxtbox.Text == "")
                MessageBox.Show("you forgot to enter password please enter a password");
            if ((checkBox1.Checked == false && checkBox2.Checked == false)||(checkBox1.Checked == true && checkBox2.Checked == true))
                MessageBox.Show("please select whether you want to login as a student or as a teacher");
            if(checkBox1.Checked==true)
            {
                Form3 StudentView=new Form3();
                StudentView.Show();
            }
            if(checkBox2.Checked==true)
            {
                Form4 TeacherView=new Form4();
                TeacherView.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 forgotpasswordForm = new Form2();
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
