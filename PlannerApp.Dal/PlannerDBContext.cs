using Microsoft.EntityFrameworkCore;
using PlannerApp.Models;
using System;

namespace PlannerApp.Dal
{
    public class PlannerDBContext:DbContext
    {
        public PlannerDBContext(DbContextOptions<PlannerDBContext> options) : base(options)
        {
        }

            public DbSet<Plans> Plans { get; set; }

    
    }
}
