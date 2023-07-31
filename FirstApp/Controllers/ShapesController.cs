using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class ShapesController : Controller
    {
        // GET: Shapes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Shape shape) {
            return View(shape);
        }
    }
}