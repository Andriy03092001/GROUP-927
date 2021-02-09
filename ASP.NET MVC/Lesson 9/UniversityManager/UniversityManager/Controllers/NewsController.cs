using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManager.Models;

namespace UniversityManager.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext _context;
        public NewsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(CreateNewsViewModel model)
        {
            _context.News.Add(new Models.Entity.News
            {
                Description = model.Description,
                ImageURL = model.ImageURL,
                ReleaseDate = model.ReleaseDate,
                Title = model.Title
            });

            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}