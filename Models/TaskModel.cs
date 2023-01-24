using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Task name is required")]
        [MaxLength(50)]
        public string TaskName { get; set; }
        [DisplayName("Details")]
        [MaxLength(2000)]
        public string TaskDesc { get; set; }
        public bool TaskDone { get; set; }
    }
}