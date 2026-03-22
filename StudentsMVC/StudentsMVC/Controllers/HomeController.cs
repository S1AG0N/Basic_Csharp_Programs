using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
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
            ViewBag.Message = "Contact Page - Academy of Learning";

            return View();
        }
    
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id=1,
                    FirstName="Phillip",
                    LastName="Ziwada"
                },
                new Instructor
                {
                    Id=1,
                    FirstName="Vimbiso",
                    LastName="Ziwada"
                },
                new Instructor
                {
                    Id=1,
                    FirstName="Tayana",
                    LastName="Ziwada"
                },
            };
            return View(instructors);
        }
        public ActionResult Instructor(int id)
        {

            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Phillip",
                LastName = "Ziwada"
            };
            return View(dayTimeInstructor);
        }
    }
}