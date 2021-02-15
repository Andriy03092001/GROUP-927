using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithRoles.Models;

namespace WorkWithRoles.Controllers
{
    public class PostController : Controller
    {
        private ApplicationDbContext _context;

        public PostController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPost()
        {
            var data = _context.Posts.Select(t => new PostViewModel
            {
                Author = t.Author,
                DateRelease = t.DateRelease,
                Id = t.Id,
                Text = t.Text,
                Title = t.Title
            });
            return View(data);
        }
    }
}