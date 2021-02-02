using First_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Project.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult List()
        {
            List<NewsViewModel> model = new List<NewsViewModel>();
            model.Add(new NewsViewModel()
            {
                Title = "Group 927 starting learn ASP.NET",
                Description = "Group 927 starting learn ASP.NET",
                Image = "https://media-exp1.licdn.com/dms/image/C510BAQEyfKQsdWriRg/company-logo_200_200/0/1519915199980?e=2159024400&v=beta&t=4Z1tWKcs3owEoiGxvGxJfMKqx6YlWMfhIBBX4gzZoj4"
            });

            model.Add(new NewsViewModel()
            {
                Title = "Group 927 starting learn ASP.NET",
                Description = "Group 927 starting learn ASP.NET",
                Image = "https://media-exp1.licdn.com/dms/image/C510BAQEyfKQsdWriRg/company-logo_200_200/0/1519915199980?e=2159024400&v=beta&t=4Z1tWKcs3owEoiGxvGxJfMKqx6YlWMfhIBBX4gzZoj4"
            });

            model.Add(new NewsViewModel()
            {
                Title = "Group 927 starting learn ASP.NET",
                Description = "Group 927 starting learn ASP.NET",
                Image = "https://media-exp1.licdn.com/dms/image/C510BAQEyfKQsdWriRg/company-logo_200_200/0/1519915199980?e=2159024400&v=beta&t=4Z1tWKcs3owEoiGxvGxJfMKqx6YlWMfhIBBX4gzZoj4"
            });

            return View(model);
        }
    }
}