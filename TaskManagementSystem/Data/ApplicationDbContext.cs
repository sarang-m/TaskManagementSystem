﻿using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}