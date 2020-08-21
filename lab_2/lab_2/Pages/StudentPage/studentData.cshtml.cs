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
    public class studentDataModel : PageModel
    {
        ITIDB db;
        public studentDataModel(ITIDB _db)
        {
            db = _db;
        }

        public List<Student> students { get; set; }
        [BindProperty]
        public Student student { get; set; }
      
        //public SelectList ls { get; set; }
        public void OnGet()
        {
            students = db.Students.Include(n => n.department).ToList();
            //ls= new SelectList(db.Department.ToList(),"id","Dept_Name");
            ViewData["ls"] = new SelectList(db.Departments.ToList(), "id", "Dept_Name");




        }
        public void OnGetEdit(int id)
        {
            student = db.Students.Include(n=>n.department).FirstOrDefault(f => f.St_Id == id);
            students = db.Students.Include(n => n.department).ToList();
            //ls = new SelectList(db.Department.ToList(), "id", "name");
            ViewData["ls"] = new SelectList(db.Departments.ToList(), "id", "Dept_Name");

        }
        public IActionResult OnGetDelete(int id)
        {
            student = db.Students.Include(n => n.department).FirstOrDefault(f => f.St_Id == id);
            db.Entry(student).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("OnGet");

        }
        public IActionResult OnPost()
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("OnGet");

        }
        public IActionResult OnPostEdit()
        {
            db.Entry("student").State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("OnGet");

        }
    }
}