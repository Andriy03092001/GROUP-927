using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly EFContext _context;

        public StudentController()
        {
            _context = new EFContext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<StudentViewModdel> data = _context.Students.Select(t => new StudentViewModdel()
            {
                Id = t.Id,
                Address = t.Address,
                Age = t.Age,
                FullName = t.FullName,
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
        public ActionResult Create(AddStudentViewModel model)
        {
            _context.Students.Add(new Student
            {
                Address = model.Address,
                Age = model.Age,
                FullName = model.FullName,
                URL_Image = model.URL_Image,
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }



    }
}







