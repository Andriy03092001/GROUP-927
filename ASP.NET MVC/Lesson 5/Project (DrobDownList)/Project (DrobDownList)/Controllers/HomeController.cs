using Project__DrobDownList_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project__DrobDownList_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            StudentViewModel model = new StudentViewModel();
            model.Genders = new List<SelectListItem>();
            model.Groups = new List<SelectListItem>();
            
            model.Genders.Add(new SelectListItem
            {
                Value = "MALE",
                Text = "MALE"

            });
            model.Genders.Add(new SelectListItem
            {
                Value = "FEMALE",
                Text = "FEMALE"
            });

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateStudent(StudentViewModel model)
        {

            if(model.Gender == "FEMALE")
            {

            }

            return RedirectToAction("Index", "Home");
        }

    }
}