using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Service
{
    public class ProductService
    {
        public List<Product> GetProductos()
        {
            var product = new Product()
            {
                Name = "Puelque",
                Description = "En un lugar de la mancha",
                Quantity = 38,
                Production = new DateTime(2023, 11, 5)
            };

            return new List<Product> {  product };
        }
    }
}