using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using Blog.DAO;

namespace Blog.Controllers
{
    public class PostController : Controller
    {        
        // Domain/Post/Index
        [HttpGet]
        public IActionResult Index()
        {
            PostDAO dao = new PostDAO();
            var postList = dao.List();
            return View(postList); // Typed view
        }

        // Domain/Post/Form
        [HttpGet]
        public IActionResult Form(Post post)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItemList(Post post)
        {
            PostDAO dao = new PostDAO();
            dao.AddPost(post);
            return RedirectToAction("Index");
        }
    }

}
