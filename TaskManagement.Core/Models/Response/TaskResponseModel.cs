using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Response
{
    public class TaskResponseModel
    {
        //common properties
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Remarks { get; set; }

        //for finished tasks
        public DateTime? Completed { get; set; }

        //for unfinished tasks
        public char? Priority { get; set; }
        
    }
}
