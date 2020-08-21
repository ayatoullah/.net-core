using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models.repository
{
    public interface ICatREpository
    {

        List<Category> GetAll();

        Category GetByID(int id);


        //IActionResult Create();
        void Create(Category category);
        void Edit(Category category);
    
        void Delete(int id);

    }
}
