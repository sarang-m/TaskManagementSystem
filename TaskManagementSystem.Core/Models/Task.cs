using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskManagementSystem.Core.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; } // "Low", "Medium", "High"
        public string Status { get; set; } // "Pending", "In Progress", "Completed"
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        //public int AssignedToUserId { get; set; }
        //public User AssignedToUser { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
