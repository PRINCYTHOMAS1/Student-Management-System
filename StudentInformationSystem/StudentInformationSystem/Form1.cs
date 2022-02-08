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

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label txtbox=new System.Windows.Forms.Label();
            this.Controls.Add(txtbox);
            txtbox.Top = loc*23;
            txtbox.Left = loc * 50;
            txtbox.Width = 250;
            txtbox.Height = 50;
            txtbox.Text = "Password should contain atleast 8 characters\nset a strong password!!";
            
        }
    }
}
