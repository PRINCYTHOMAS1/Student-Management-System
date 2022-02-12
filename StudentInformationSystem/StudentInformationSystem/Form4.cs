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
    public partial class TeachersPortalForm : Form
    {
        public TeachersPortalForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudent = new AddStudentForm();
            addstudent.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ViewStudentForm editsudent= new ViewStudentForm();  
            editsudent.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
