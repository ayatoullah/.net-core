using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class plogDbContext:DbContext
    {
        public plogDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> categorys { get; set; }
    }
}
