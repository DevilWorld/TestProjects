using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Table", Category = "Furniture", Price = 75.0},
            new Product {Id = 2, Name = "Chair", Category = "Furniture", Price = 30.0},
            new Product {Id = 3, Name = "Apples", Category = "Fruits", Price = 7.99}
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(a => a.Id == id);

            if (product != null)
            {
                return Ok(product);
            }

            return NotFound();
        }
    }
}
