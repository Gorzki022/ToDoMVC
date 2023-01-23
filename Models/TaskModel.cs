using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{

    public class TaskModel
    {
        public int TaskId { get; set; }
        [DisplayName("Name")]
        public string TaskName { get; set; }
        [DisplayName("Details")]
        public string TaskDesc { get; set; }
        public bool TaskDone { get; set; }
    }
}