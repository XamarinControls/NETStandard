using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETStandard.Core;

namespace NetStandard.ASPNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            PersonService ps = new PersonService();

            ViewBag.PersonList = ps.GetPersons();

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
