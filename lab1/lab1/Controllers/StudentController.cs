using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
using System.Web;

namespace lab1.Controllers
{
    public class StudentController : Controller
    {
        ITIContext context;
        public StudentController(ITIContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.students.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([Bind("St_Name,Address,BirthDate,Email,St_Age") ] Student student)
        {
            if (ModelState.IsValid)
            {
                context.students.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public async Task<ActionResult> Edit(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Student student = await context.students.FindAsync(id);
            //if (student== null)
            //{
            //    return HttpNotFound();
            //}
            
            return View(student);
        }
        [HttpPost]
        public async Task<ActionResult> Edit([Bind("St_Name,Address,BirthDate,Email,St_Age")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.students.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Student student = await context.students.FindAsync(id);
            return View(student);


        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Student student = await context.students.FindAsync(id);

           
                context.students.Remove(student);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
       


        }
        public async Task<IActionResult> Details(int id )
        {
            Student student = await context.students.FindAsync(id);
            return View(student);
        }
    }
    
}