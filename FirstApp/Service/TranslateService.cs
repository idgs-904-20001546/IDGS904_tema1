using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast;
using WebGrease.Css.Ast.Selectors;

namespace FirstApp.Service
{
    public class TranslateService
    {

        public static void SaveWord(Translation translation)
        {
            var path = HttpContext.Current.Server.MapPath("~/App_Data/translations.txt");
            File.AppendAllText(path, translation.ToString());
        }

        public static List<Translation> GetTranslations()
        {
            var path = HttpContext.Current.Server.MapPath("~/App_Data/translations.txt");
            var list = new List<Translation>();
            if (File.Exists(path))
            {
                var arrTerms = File.ReadAllLines(path);
                foreach ( var term in arrTerms )
                {
                    list.Add(Translation.GetTranstionsFrom(term));
                }
            }
            return list;
        }

        public static Array GetStringTranslations()
        {
            var path = HttpContext.Current.Server.MapPath("~/App_Data/translations.txt");
            Array translationsStrings = null;
            if (File.Exists(path))
            {
                translationsStrings = File.ReadAllLines(path);
                
            }

            return translationsStrings;
        }
    }
}