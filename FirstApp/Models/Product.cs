﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public DateTime Production { get; set; }
    }
}