using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Wine", Category = "Booze", Price = 8.95M },
            new Product { Id = 5, Name = "Beer", Category = "Booze", Price = 6.99M }
        };

        static List<string> data = initList();

        private static List<string> initList()
        {
            var ret = new List<string>();
            ret.Add("valuaue1");
            ret.Add("valau2"); return ret;
        }
        // api/products
        public IEnumerable<Product> GetAllProducts()
        {
            return products; //return products;
        }
        // api/products/2
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        // POST api/products
        public void Post([FromBody]string value) { data.Add(value); }
        // PUT api/products/2
        public void Put(int id, [FromBody] string value) { data[id] = value; }
        // DELETE api/products/3
        public void Delete(int id) { data.RemoveAt(id); }
    }
}
