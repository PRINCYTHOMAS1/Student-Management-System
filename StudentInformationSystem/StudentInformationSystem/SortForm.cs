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
            
        }

        private void depcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depcomboBox.SelectedItem.ToString() == "Computer Science")
            {
                sortcomboBox.Items.Add("Computer Science and Engineering");
                sortcomboBox.Items.Add("IT");
            }
            if (depcomboBox.SelectedItem.ToString() == "Electronics")
            {
                sortcomboBox.Items.Add("Electrical and Electronics Engineering");
                sortcomboBox.Items.Add("Electronics and communication Engineering");
            }
        }
    }
}
