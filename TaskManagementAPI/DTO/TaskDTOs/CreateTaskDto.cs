using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Core.Enums;
using TaskStatus = TaskManagementSystem.Core.Enums.TaskStatus;


namespace TaskManagementAPI.DTO.TaskDTOs
{
    public class CreateTaskDto
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [EnumDataType(typeof(TaskPriority))]
        public TaskPriority Priority { get; set; } = TaskPriority.Medium; 

        [Required]
        [EnumDataType(typeof(TaskStatus))]
        public TaskStatus Status { get; set; } = TaskStatus.InProgress;

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int AssignedToUserId { get; set; }
    }
}
