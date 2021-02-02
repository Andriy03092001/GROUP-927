using Atrr_Validation.Entity;
using Atrr_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atrr_Validation.Controllers
{
    public class GameController : Controller
    {
        private EFContext _context;
        public GameController()
        {
            _context = new EFContext();
        }

        public ActionResult Index()
        {
            var data = _context.Games.Select(t => new GameViewModel
            {
                Id = t.Id,
                Name = t.Name,
                DateRelease = t.DateRelease,
                Description = t.Description,
                Developer = t.Developer,
                Price = t.Price,
                URL_Image = t.URL_Image
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateGameViewModel model)
        {
            _context.Games.Add(new Games { 
                Name = model.Name,
                DateRelease = model.DateRelease,
                URL_Image = model.URL_Image,
                Developer = model.Developer,
                Price = model.Price,
                Description = model.Description
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Game");
        }


    }
}