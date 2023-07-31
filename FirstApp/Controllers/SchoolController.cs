using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            // return Content("En un lugar de la mancha de <span class='text-primary'>funes ojos verdes</span>");

            var product = new Product()
            {
                Name = "pulque1",
                Description = "En un lugar de la mancha",
                Quantity = 1,
                Production = new DateTime(2023, 11, 2)
            };


            return Json(product, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult Vista()
        {
            return Redirect("https://google.com");
        }

        public RedirectToRouteResult VistaTwo()
        {
            TempData["Name"] = "Eric";
            return RedirectToAction("IndexTwo", "School");
        }

        public ActionResult IndexTwo()
        {
            ViewBag.Group = "grupo";
            ViewData["Materia"] = "DNI";
            string name = "";
            if (TempData.ContainsKey("Name"))
            {
                name = TempData["Name"] as string;
            }
            ViewBag.value = name;
            return View();
        }
    }
}