using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Core.Enums;

namespace TaskManagementSystem.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // Role (Admin or User)
        public UserRole Role { get; set; }
        public ICollection<Task>? Tasks { get; set; }
    }
}
