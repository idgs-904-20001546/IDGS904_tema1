using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Producto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Quantity { get; set; }

        public DateTime Production { get; set; }
    }
}