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
    public partial class SortForm : Form
    {
        private string _sortby;
        private Form _preWindow;
        public SortForm( string sortby,Form PreviousWindow)
        {
            InitializeComponent();
            _preWindow = PreviousWindow;
            _sortby = sortby;
            if (_sortby == "Department")
                Sortlabel.Text = "Department Name:";
            if (_sortby == "Course")
                Sortlabel.Text = "Course Name";
            if (_sortby == "Semester")
                Sortlabel.Text = "Semester ";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _preWindow.Show();
            Hide();
        }
    }
}
