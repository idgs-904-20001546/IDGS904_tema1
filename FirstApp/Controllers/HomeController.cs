using FirstApp.Models;
using FirstApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.Res = op.Calculate();

            return View(model);
        }

        public ActionResult ShowPuelques()
        {
            var pulques = new ProductService();
            var model = pulques.GetProductos();
            return View(model);
        }
    }
}