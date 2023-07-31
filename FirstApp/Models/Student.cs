using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}