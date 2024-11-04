using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        public DateTime CommentedDate { get; set; }
    }
}
