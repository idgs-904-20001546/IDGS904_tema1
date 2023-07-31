using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var students = new Student() {
                Name = "Eric",
                Age = 21,
                Active = true,
                CreatedAt = new DateTime(2022, 4, 23)
            };
            ViewBag.students = students;
            return View();
        }

        public ActionResult Register()
        {

            return View();
        }

        public ActionResult Temperature()
        {
            return View();
        }

        public ActionResult CalculateTemperature(Temperature temp)
        {
            temp.CalculateCelcius();
            TempData["Result"] = temp.Result + "";
            return RedirectToAction("Temperature");
        }
    }
}