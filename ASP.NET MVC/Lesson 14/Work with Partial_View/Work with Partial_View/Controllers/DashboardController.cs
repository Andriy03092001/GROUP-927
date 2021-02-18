using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work_with_Partial_View.Models;

namespace Work_with_Partial_View.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            DashboardViewModel model = new DashboardViewModel();
            model.InitList();

             return View(model);
        }



    }
}