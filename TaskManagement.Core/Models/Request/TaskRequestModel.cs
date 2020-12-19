using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Core.Models.Request
{
    public class TaskRequestModel
    {
        //common properties
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Remarks { get; set; }
    }
}
