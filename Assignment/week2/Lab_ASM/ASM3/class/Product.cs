using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float SubTottal {
            get
            {
                return UnitPrice * Quantity;
            }
        }

        public Product()
        {
            ProductID = 0;
            ProductName = string.Empty;
            Quantity = 0;
            UnitPrice = 0;
        }

        public Product(int ID, string Name, int pQuantity, float Price)
        {
            ProductID = ID;
            ProductName = Name;
            Quantity = pQuantity;
            UnitPrice = Price;
        }

    }
}
