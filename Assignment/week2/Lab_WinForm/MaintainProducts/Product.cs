using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintainProducts
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    public class ProductData
    {
        private List<Product> ProductList = new List<Product>();

        public List<Product> GetProductList
        {
            get
            {
                return ProductList;
            }
        }

        public void AddNew(Product product)
        {
            Product p = Find(product.ProductID);
            if(p == null)
            {
                ProductList.Add(product);
            }
            else
            {
                throw new Exception("Product is already exists");
            }
        }

        public void Remove(int ProductID)
        {
            Product product = Find(ProductID);
            if(product != null)
            {
                ProductList.Remove(product);
            }
            else
            {
                throw new Exception("Product is not already exists");
            }
        }

        public Product Find(int ProductID)
        {
            Product product = ProductList.SingleOrDefault(p => p.ProductID == ProductID);
            return product;
        }
    }

}
