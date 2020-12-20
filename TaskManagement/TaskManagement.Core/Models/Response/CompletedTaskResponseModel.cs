using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Response
{
    public class CompletedTaskResponseModel : TaskResponseModel
    {
        //for finished tasks
        public DateTime? Completed { get; set; }
    }
}
