using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Request
{
    public class UserRequestModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}