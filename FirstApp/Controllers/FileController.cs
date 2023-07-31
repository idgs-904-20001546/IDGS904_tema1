using FirstApp.Models;
using FirstApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Teacher teacher)
        {
            var service = new FileService();
            service.SaveFile(teacher);

            return View();
        }

        public ActionResult Read()
        {
            var service = new FileService();
            ViewBag.Data = service.ReadFile();
            return View();
        }
    }
}