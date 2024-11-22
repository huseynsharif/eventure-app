using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventureApp.Models.dtos
{
    internal class UserSignUpDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }
    }
}
