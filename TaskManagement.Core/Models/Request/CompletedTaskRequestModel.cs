using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Request
{
    public class CompletedTaskRequestModel : TaskRequestModel
    {
        //for finished tasks
        public DateTime? Completed { get; set; }
    }
}
