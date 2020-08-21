using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;
using lab3.Models.repository;
//using Microsoft.NET.Sdk.Web;


namespace lab3.Controllers
{
    public class CategoryController : Controller
    {
        ICatREpository cr;
        Category category;
        List<Category> Categorys;
        public CategoryController(ICatREpository _cr)
        {
            cr = _cr;
        }
        public IActionResult CategoryHome()
        {
            List<Category> categorys = cr.GetAll().ToList();
            return View(categorys);
            
        }

        public IActionResult Create()
        {
            //List<Category> categorys = cr.GetAll().ToList();
            //return View(categorys);
            return View();

        }
        [HttpPost]
        public IActionResult Create([Bind("name")] Category category)
        {
            cr.Create(category);

           
            return RedirectToAction("CategoryHome");
           
        }
        public IActionResult Delete(int id)
        {
            cr.Delete(id);
            return RedirectToAction("CategoryHome");
        }

        public  IActionResult Edit(int id)
        {
            category=cr.GetByID(id);
            return View(category);

        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            cr.Edit(category);
            return RedirectToAction("CategoryHome");
        }
        //public Category GetByID(int id)
        //{
        //    return cr.
        //}

    }
}