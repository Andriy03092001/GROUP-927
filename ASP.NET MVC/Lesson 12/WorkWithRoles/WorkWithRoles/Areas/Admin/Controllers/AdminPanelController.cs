using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithRoles.Areas.Admin.Models;
using WorkWithRoles.Models;

namespace WorkWithRoles.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPanelController : Controller
    {
        private ApplicationDbContext _context;
        public AdminPanelController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Admin/AdminPanel
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPost(CreatePostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please, enter all data!");
                return View(model);
            }
            else
            {
                _context.Posts.Add(new Entity.Post
                {
                    Author = model.Author,
                    DateRelease = model.DateRelease,
                    Text = model.Text,
                    Title = model.Title
                });
                _context.SaveChanges();
                return RedirectToAction("Dashboard", "AdminPanel", new { area = "Admin" });
            }
        }
        //Enable-migrations
        //Add-migration "ffff"
        //Update-database

    }
}