namespace TaskManagementAPI.DTO.CommentDto
{
    public class GetCommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CommentedDate { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
