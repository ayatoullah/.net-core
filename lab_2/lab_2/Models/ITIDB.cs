using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_2.Models;

namespace lab_2.Models
{
    public class ITIDB:DbContext
    {
        public ITIDB( DbContextOptions option):base(option)
        {

        }
      
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}

