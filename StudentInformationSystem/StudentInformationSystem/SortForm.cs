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
    public partial class SortForm : Form
    {
        private Form _preWindow;
        public SortForm(Form PreviousWindow)
        {
            InitializeComponent();
            _preWindow = PreviousWindow;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _preWindow.Show();
            Hide();
        }
        private void viewbutton1_Click(object sender, EventArgs e)
        {
            SortingClass sort=new SortingClass();
            StudentDetailsModel []student=new StudentDetailsModel[100];
            if (sortcomboBox.SelectedIndex== -1 && comboBox2.SelectedIndex== -1)
            {
                student = sort.Sorting(depcomboBox.SelectedItem.ToString());
                dataGridView1.DataSource = student;
            }
            if (depcomboBox.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                student = sort.Sorting(sortcomboBox.SelectedItem.ToString());
                dataGridView1.DataSource = student;
            }
            if (depcomboBox.SelectedIndex == -1 && sortcomboBox.SelectedIndex == -1)
            {
                student = sort.Sorting(comboBox2.SelectedItem.ToString());
                dataGridView1.DataSource = student;
            }
            if (depcomboBox.SelectedIndex != -1 && sortcomboBox.SelectedIndex != -1 && comboBox2.SelectedIndex!=-1)
            {
                int sem = Convert.ToInt32(comboBox2.SelectedItem);
                student = sort.Sorting(depcomboBox.SelectedItem.ToString(),sortcomboBox.SelectedItem.ToString(),sem);
                dataGridView1.DataSource = student;
            }

        }
    }
}
