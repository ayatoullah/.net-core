using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_2.Models;

namespace lab_2.Models
{
    public class Department
    {
        public int id { get; set; }
        public string Dept_Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
