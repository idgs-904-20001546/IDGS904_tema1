using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class PointersController : Controller
    {
        // GET: Pointers
        public ActionResult Index()
        {
            string result = "Hola";
            if (TempData.ContainsKey("Result"))
            {
                result = TempData["Result"] as string;
            }
            ViewBag.Result = result;
            return View();
        }

        public ActionResult Calculate(Pointers pointers)
        {
            double result = pointers.GetDistance();
            TempData["Result"] = result + "";
            return RedirectToAction("Index");
        }
    }
}