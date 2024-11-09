using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Core.Models.Identity;

namespace TaskManagementSystem.Core.Models
{
    public class Comment  
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Content { get; set; }


        public int TaskId { get; set; }
        public Task? Task { get; set; }


        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }



        public DateTime CommentedDate { get; set; } = DateTime.Now;
    }
}
