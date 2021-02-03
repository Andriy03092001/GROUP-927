using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work_with_ImageFile_in_MVC.Entity;
using Work_with_ImageFile_in_MVC.Helper;
using Work_with_ImageFile_in_MVC.Models;

namespace Work_with_ImageFile_in_MVC.Controllers
{
    public class HomeController : Controller
    {
        private EFContext _context;
        public HomeController()
        {
            _context = new EFContext();
        }
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
        public ActionResult CreateGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGame(CreateGameViewModel model, HttpPostedFileBase imageFile)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";

            string image = Server.MapPath(Constants.ImagePath) + "\\" + fileName;
            using (Bitmap img = new Bitmap(imageFile.InputStream))
            {
                Bitmap saveImage = ImageWorker.CreateImage(img, 400, 400);
                if (saveImage != null)
                {
                    saveImage.Save(image, ImageFormat.Jpeg);
                    // Save game with name image in Db
                    _context.Games.Add(new Game
                    {
                        Developer = model.Developer,
                        Image = fileName,
                        Name = model.Name,
                        Price = model.Price
                    });
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Home");
        }



        public ActionResult ListGames()
        {
            var data = _context.Games.Select(t => new GameViewModel
            {
                Developer = t.Developer,
                Image = t.Image,
                Name = t.Name,
                Price = t.Price
            });

            return View(data);
        }




    }
}