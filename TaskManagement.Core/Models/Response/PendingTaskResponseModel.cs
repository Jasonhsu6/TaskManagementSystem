﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Response
{
    public class PendingTaskResponseModel : TaskResponseModel
    {

        //for unfinished tasks
        public char? Priority { get; set; }
    }
}