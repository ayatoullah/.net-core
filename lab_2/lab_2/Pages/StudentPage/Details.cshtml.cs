using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_2.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_2.Pages.StudentPage
{
    public class DetailsModel : PageModel
    {
        ITIDB db;
        public DetailsModel(ITIDB _db)
        {
            db = _db;
        }
        public Student student{ get; set; }
        public void OnGet(int id)
        {
            student=db.Students.Include(c=>c.department).FirstOrDefault(n=>n.St_Id==id);
        }
    }
}