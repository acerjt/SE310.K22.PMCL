using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RemoteService.Models;


namespace RemoteService.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Products> Get()
        {
            return ProductData.Products;
        }

        
        // GET api/<controller>/5
        public Products Get(int id)
        {
            Products p = ProductData.Products.SingleOrDefault(x => x.ProductID == id);
            if (p == null)
                return null;
            return p;
        }




        // POST api/<controller>
        public void Post([FromBody] Products p)
        {
            ProductData.Products.Add(p);
        }

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Products p = ProductData.Products.SingleOrDefault(x => x.ProductID == id);
            ProductData.Products.Remove(p);
        }
    }
}