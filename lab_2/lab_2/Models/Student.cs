using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lab_2.Models
{
    public class Student
    {
        [Key]
        public int St_Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = " length between 3 and 25 character")]
        public string St_Name { get; set; }

        [Range(18, 35, ErrorMessage = "age must be between 18 and 35")]
        public int St_Age { get; set; }

        [Required(ErrorMessage = "*")]
        public string Address { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression(@"[a-zA-Z0-9]+@[A-Za-z]+.[a-zA-Z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
     //   [ForeignKey("Department")]
        public int departmentID { get; set; }
        public Department department { get; set; }

    }
}
