using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManagementSystem.Core.Enums;
using TaskManagementSystem.Core.Models.Identity;

namespace TaskManagementSystem.Core.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        // "Low", "Medium", "High"
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        // "Pending", "In Progress", "Completed"
        public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.InpProgress;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }


        public int AssignedToUserId { get; set; }
        public ApplicationUser? AssignedToUser { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
