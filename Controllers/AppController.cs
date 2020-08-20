using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTree.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTree.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
            }
            else
            {
                //return errors
            }
            return View();
        }
        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
    }
}
