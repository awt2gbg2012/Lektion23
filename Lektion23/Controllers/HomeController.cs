using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion23.Models.Entities;
using Lektion23.Models.Repositories;
using System.Data.Entity;

namespace Lektion23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var categories = (new Repository<Category>()).FindAll();
            var tags = (new Repository<Tag>()).FindAll();
            var newCaption = (new Repository<NewsCaption>()).FindAll();
            var news = (new Repository<News>()).FindAll();
            var news1tags = news.Where(n => n.Title == "News Title 1")
                                .FirstOrDefault().Tags;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
