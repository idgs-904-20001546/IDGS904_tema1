using FirstApp.Models;
using FirstApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class TranslateController : Controller
    {
        // GET: Translate
        [HttpGet]
        public ActionResult Index()
        {
            /*
            if(TempData.ContainsKey("showTranslations"))
            {
                ViewBag.Translations = TranslateService.GetStringTranslations();
            }*/

            return View();
        }
        [HttpPost]
        public ActionResult Index(Translation translation)
        {
            TranslateService.SaveWord(translation);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Show()
        {
            //TempData["showTranslations"] = true;
            ViewBag.Translations = TranslateService.GetStringTranslations();
            return View("Index");
        }

        [HttpGet]
        public ActionResult Translate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Translate(Translation translation)
        {
            if(translation.Selected == "en")
            {
                Translation word = TranslateService.GetTranslations().Find(x => x.EsWord == translation.Word.ToLower());
                ViewBag.Translation = word?.EnWord ?? "";
            } else
            {
                Translation word = TranslateService.GetTranslations().Find(x => x.EnWord == translation.Word.ToLower());
                ViewBag.Translation = word?.EsWord ?? "";
            }

            return View();
        }
    }
}