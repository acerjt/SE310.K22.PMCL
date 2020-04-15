using System;

namespace ASM_6
{
    public class Medicine
    {
        private string code;
        private string name;
        private string manufacturer;
        private int price;
        private int quantity;
        private string date;
        private string expireDate;
        private int batchNumber;

        public Medicine() {
            code = null;
            name = null;
            manufacturer = null;
            price = 0;
            quantity = 0;
            date = null;
            expireDate = null;
            batchNumber = 0;
        }

        public Medicine(string code, string name, string manufacturer, int price,
            int quantity, string date, string expireDate, int batchNumber) {

            this.code = code;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.quantity = quantity;
            this.date = date;
            this.expireDate = expireDate;
            this.batchNumber = batchNumber;       
        }

        public void Accept() {
            do {
                Console.Write("Enter the medicine code: ");
                code = Console.ReadLine();
                Console.Write("Enter the medicine name: ");
                name = Console.ReadLine();
                Console.Write("Enter the manufaturer name: ");
                manufacturer = Console.ReadLine();
                Console.Write("Enter the unit price: ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the quantity on hand: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the manufactured date: ");
                date = Console.ReadLine();
                Console.Write("Enter the expiry date: ");
                expireDate = Console.ReadLine();
                Console.Write("Enter the batch number: ");
                batchNumber = Convert.ToInt32(Console.ReadLine());
            } while(code == null || name == null || manufacturer == null
                || date == null || expireDate == null);
        }
        public void IncreaseQuantity() {
            quantity += 50;
        }

        public void Print() {
            Console.WriteLine("\n******* The Medicine detail ******* ");
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("Medicine name:" + name);
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("Medicine name:" + name);
            Console.WriteLine("Manufacturer name:" + manufacturer);
            Console.WriteLine("The unit price:" + price);
            Console.WriteLine("The quantity on hand:" + quantity);
            Console.WriteLine("The manufactured date:" + date);
            Console.WriteLine("The expiry date:" + expireDate);
            Console.WriteLine("The batch number:" + batchNumber);

        }

        public void Print(string code) {
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("The quantity on hand:" + quantity);
        }

        public void Print(string code, string name) {
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("Medicine name:" + name);
            Console.WriteLine("The expiry date:" + expireDate);
            Console.WriteLine("The manufactured date:" + date);
        }
    }
}
