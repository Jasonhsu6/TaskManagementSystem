﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Response
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}
