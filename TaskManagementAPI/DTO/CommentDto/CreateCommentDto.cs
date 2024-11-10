using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.DTO.CommentDto
{
    public class CreateCommentDto
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public int TaskId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
