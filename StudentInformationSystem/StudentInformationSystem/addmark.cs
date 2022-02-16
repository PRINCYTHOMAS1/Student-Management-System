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
        public addmark()
        {
            InitializeComponent();
        }

        private void markbutton_Click(object sender, EventArgs e)
        {
            AddMarks mark= new AddMarks();
            mark.RegisterNumber = regtext.Text;
            mark.Subject1 = Convert.ToInt32(mark1.Text);
            mark.Subject2 = Convert.ToInt32(mark2.Text);
            mark.Subject3 = Convert.ToInt32(mark3.Text);
            AddMarkService add = new AddMarkService();
            add.AddMarkServices(mark); 
               
        }
   }
}

