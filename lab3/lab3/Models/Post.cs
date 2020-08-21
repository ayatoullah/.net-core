using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Post
    {
        public int id { get; set; }
        [Required(ErrorMessage = "enter post title")]
        public string title { get; set; }
        [Required(ErrorMessage = "enter post description")]

        public string description { get; set; }
        [Required(ErrorMessage = "enter post date")]
        [DataType(DataType.Date)]

        public DateTime date { get; set; }

        public int categoryID { get; set; }
       
    }
}
