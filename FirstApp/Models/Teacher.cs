using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Teacher
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }
        
        public string Email { get; set; }  

        public override string ToString()
        {
            return "";
        }
    }
}