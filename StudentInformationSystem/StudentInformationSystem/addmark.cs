using StudentInformationSystem.Models;
using StudentInformationSystem.Services;
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
    public partial class addmark : Form
    {
        private int currentsem;
        private Form previouswin;
        public addmark(string registerNumber,string currentsemester,Form PreviousWindow)
        {
            InitializeComponent();
            regtextbox.Text= registerNumber;
            currentsem= Convert.ToInt32(currentsemester);
            for(int i=1;i<=currentsem;i++)
            {
                SemcomboBox.Items.Add(i.ToString());
            }
            this.previouswin = PreviousWindow;
            
        }

        private void markbutton_Click(object sender, EventArgs e)
        {
            AddMarks mark= new AddMarks();
            mark.RegisterNumber = regtextbox.Text;
            mark.semester = Convert.ToInt32(SemcomboBox.SelectedItem);
            mark.Subject1 = Convert.ToInt32(mark1txtbox.Text);
            mark.Subject2 = Convert.ToInt32(mark2txtbox.Text);
            mark.Subject3 = Convert.ToInt32(mark3txtbox.Text);
            AddMarkService add = new AddMarkService();
            int i= add.AddMarkServices(mark);
            if (i==0)
            {
                string str = $"{regtextbox.Text} with semester {SemcomboBox.SelectedItem} mark already excists";
                MessageBox.Show(str);
            }
             
            if (i != 0)
                MessageBox.Show("marks added!");
        }

        private void SemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 1)
            {
                sub1textBox.Text = "C ++";
                sub2textBox.Text = "Python";
                sub3textBox.Text = "Java";
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 2)
            {
                sub1textBox.Text = "PHP";
                sub2textBox.Text = "HTML";
                sub3textBox.Text = "CSS";
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 3)
            {
                sub1textBox.Text = "C Sharp";
                sub2textBox.Text = "Android";
                sub3textBox.Text = "Java";
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 4)
            {
                sub1textBox.Text = "Cloud Computing";
                sub2textBox.Text = "Android";
                sub3textBox.Text = "Java";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previouswin.Show();
            Hide();
        }
    }
}

