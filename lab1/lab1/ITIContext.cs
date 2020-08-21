using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using lab1.Models;

namespace lab1
{
    public class ITIContext:DbContext
    {
        public ITIContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<Student> students { set; get; }

    }
}
