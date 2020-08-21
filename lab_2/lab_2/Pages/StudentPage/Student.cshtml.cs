using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab_2.Pages.StudentPage
{
    public class StudentModel : PageModel
    {
        ITIDB db;
        public StudentModel(ITIDB _db)
        {
            db = _db;
        }
       
        public List<Student> students { get; set; }

        public Student student { get; set; }
        //public SelectList ls { get; set; }
        //public SelectList ls { get; set; }
        public void OnGet()
        {
            // el method msh bta7'd object mn db el constractor only ,,as we assign it in ctor we can use it on all methods , //sooooorry
            //include for table only not table attr
          students = db.Students.Include(n => n.department).ToList();
            //ls= new SelectList(db.Department.ToList(), "id", "Dept_Name");
            ViewData["ls"] = new SelectList(db.Departments.ToList(),"id","Dept_Name");




        }
        public void OnGetEdit(int id)
        {
            student = db.Students.FirstOrDefault(f => f.St_Id == id);
         
        }
        public IActionResult OnPost() {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("OnGet");

        }
    }
}