using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;
using lab3.Models.repository;

namespace lab3.Controllers
{

    
    public class PostController : Controller
    {
        IPostRepository pr;
        public PostController(IPostRepository _pr)
        {
            pr = _pr;
        }
        public List<Post> Index()
        {
            List<Post> posts = pr.GetAll();
            return posts;
        }
    }
}