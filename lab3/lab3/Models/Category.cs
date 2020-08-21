using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int maxsize { get; set; }

        public List<Post> posts { get; set; }
    }
}
