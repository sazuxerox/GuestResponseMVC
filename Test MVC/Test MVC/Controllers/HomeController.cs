using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_MVC.Models;

namespace Test_MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 12)
                @ViewBag.Greeting = "Good Morning, Have a nice day";
            else
                @ViewBag.Greeting = "Good Afternoon, Have a good time";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //ToDo: Email Response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                //There is a validation error
                return View();
            }
        }
    }
}
