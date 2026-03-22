using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source = localhost\MSSQLSERVER01; Initial Catalog=Newsletter ;Integrated Security = True; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30";

        public ActionResult Index()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
           
                return View("Success");
            }

        }
    }
}