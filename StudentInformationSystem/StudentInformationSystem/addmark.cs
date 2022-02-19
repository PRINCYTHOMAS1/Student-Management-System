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
using StudentInformationSystem.Models;
using StudentInformationSystem.Services;

namespace StudentInformationSystem
{
    public partial class addmark : Form
    {
        private int currentsem;
        private Form previouswin;
        private string _course;
        private string _department;
        public addmark(string registerNumber,string currentsemester,Form PreviousWindow,string course,string department)
        {
            InitializeComponent();
            regtextbox.Text= registerNumber;
            currentsem= Convert.ToInt32(currentsemester);
            for(int i=1;i<=currentsem;i++)
            {
                SemcomboBox.Items.Add(i.ToString());
            }
            this.previouswin = PreviousWindow;
            _course= course;
            _department = department;
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
            sub1textBox.Clear();
            sub2textBox.Clear();
            sub3textBox.Clear();
            FetchSubjectName subname=new FetchSubjectName();
            SubjectNameClass newsub=new SubjectNameClass();
            
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 1)
            {
                newsub=subname.GetSubjectNameByRegNo(_course,_department,1);
                sub1textBox.Text = newsub.subjectName1;
                sub2textBox.Text = newsub.subjectName2;
                sub3textBox.Text = newsub.subjectName3;
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 2)
            {
                newsub = subname.GetSubjectNameByRegNo(_course, _department, 2);
                sub1textBox.Text = newsub.subjectName1;
                sub2textBox.Text = newsub.subjectName2;
                sub3textBox.Text = newsub.subjectName3;

            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 3)
            {
                newsub = subname.GetSubjectNameByRegNo(_course, _department, 3);
                sub1textBox.Text = newsub.subjectName1;
                sub2textBox.Text = newsub.subjectName2;
                sub3textBox.Text = newsub.subjectName3;
            }
            if (Convert.ToInt32(SemcomboBox.SelectedItem) == 4)
            {
                newsub = subname.GetSubjectNameByRegNo(_course, _department, 4);
                sub1textBox.Text = newsub.subjectName1;
                sub2textBox.Text = newsub.subjectName2;
                sub3textBox.Text = newsub.subjectName3;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previouswin.Show();
            Hide();
        }
    }
}

