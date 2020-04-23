using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteService.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    public static class ProductData
    {
        public static List<Products> Products = new List<Products>()
        {
            new Products { ProductID=1, ProductName="CaPhe", Quantity=10, UnitPrice=20 },
            new Products { ProductID=2, ProductName="Coca", Quantity=20, UnitPrice=30 }
        };
    }
}