﻿using System;
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
    public partial class TeachersPortalForm : Form
    {
        private string email;
        public TeachersPortalForm(string _email)
        {
            InitializeComponent();
            email = _email;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudent=new AddStudentForm();
            addstudent.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            TeacherViewForm teachersView = new TeacherViewForm(email);
            teachersView.Show();
        }
    }
}
