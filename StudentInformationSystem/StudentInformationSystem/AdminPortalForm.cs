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
    public partial class AdminPortalForm : Form
    {
        private  AdminService _service;
        
        public AdminPortalForm(string emailId)
        {
            InitializeComponent();
            
            _service = new AdminService();
            var model = _service.adminGetByEmail(emailId);
            nametxtbox.Text = model.AdminName;
            Qualificationtxtbox.Text = model.Qualification;
            emailidtxtbox.Text = model.EmailId;
            phnnotxtbox.Text = model.PhoneNumber.ToString();
            TeacherIdtxtbox.Text = model.TeacherId;
           

        }

        
    }
}
