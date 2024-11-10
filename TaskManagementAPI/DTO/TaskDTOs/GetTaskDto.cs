using TaskManagementAPI.DTO.CommentDto;
namespace TaskManagementAPI.DTO.TaskDTOs
{
    public class GetTaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string AssignedToUser { get; set; } // To get UserName
        public List<GetCommentDto> Comments { get; set; }

    }
}
