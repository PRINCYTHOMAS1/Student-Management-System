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
        public addmark(string registerNumber)
        {
            InitializeComponent();
            regtextbox.Text= registerNumber;
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
                MessageBox.Show("marks added!!!!!");
            this.Close();
        }
   }
}

