using FirstApp.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace FirstApp.Service
{
    public class FileService
    {
        public void SaveFile(Teacher teacher)
        {
            var name = teacher.Name;
            var lastname = teacher.Lastname;
            var age = teacher.Age;
            var email = teacher.Email;
            var data = name  + ", " + lastname + ", " + age + ", " + email + Environment.NewLine;

            var dataPath = HttpContext.Current.Server.MapPath("~/App_Data/data.txt");
            //File.WriteAllText(dataPath, data);
            File.AppendAllText(dataPath, data);
        }

        public Array ReadFile()
        {
            Array data = null;
            var path = HttpContext.Current.Server.MapPath("~/App_Data/data.txt");
            
            if(File.Exists(path))
            {
                data = File.ReadAllLines(path);
            }

            return data;
        }
    }
}