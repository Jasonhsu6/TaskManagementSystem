using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Request
{
    public class PendingTaskRequestModel : TaskRequestModel
    {
        //for unfinished tasks
        public char? Priority { get; set; }
    }
}
