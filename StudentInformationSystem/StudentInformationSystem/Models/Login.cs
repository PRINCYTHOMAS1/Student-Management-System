using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Models
{
    internal class Login
    {
        public string EmailId { get; set; } 
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
