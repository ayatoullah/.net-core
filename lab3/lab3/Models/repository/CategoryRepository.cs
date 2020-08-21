using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;





namespace lab3.Models.repository
{
    public class CategoryRepository:ICatREpository
    {
        plogDbContext db;
        public CategoryRepository(plogDbContext _db)
        {
            db = _db;

        }
        Category category;
        List<Category> categorys;

        //public IActionResult Create()
        //{
        //    Categorys=db.categorys.ToList();
        //    db.categorys.Add(category);
        //    db.SaveChanges();
        //    return ViewResult(Categorys);
        //}
        //public List<Category> Create()
        //{
        //    Categorys = db.categorys.ToList();
        //    db.categorys.Add(category);
        //    db.SaveChanges();
        //    return Categorys;
        //}




        //public IActionResult Create()
        //{
        //    return View();
        //}
       
        public void Create([Bind("name")] Category category)
        {
            //if (ModelState.IsValid)
            //{
            categorys=db.categorys.ToList();
            db.categorys.Add(category);
                db.SaveChanges();
            //return RedirectToAction("Index");
            //return categorys;
            //}
            //return View(student);
        }
        public void Delete(int id)
        {
            category = db.categorys.Find(id);
            db.Entry(category).State = EntityState.Deleted;
            db.SaveChanges();


        }
        [HttpPost]

        public void Edit(Category category)
        {
            //category = db.categorys.Find(id);
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();

        }
        public List<Category> GetAll()
        {
            return db.categorys.ToList();
        }

        public Category GetByID(int id)
        {
            category= db.categorys.Find(id);
            return category;


        }
    }
}
