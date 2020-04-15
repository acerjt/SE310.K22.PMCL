using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Book
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Price { get; set; }


        public void Input()
        {
            Console.Write("Book ID: ");
            ID = Console.ReadLine();
            Console.Out.Write("Book Name: ");
            Name = Console.ReadLine();
            Console.Out.Write("Book Publisher: ");
            Publisher = Console.ReadLine();
            Console.Out.Write("Book Price: ");
            Price = Console.ReadLine();
        }
        public void Output()
        {
            Console.Out.WriteLine("Book ID: {0}", ID);
            Console.Out.WriteLine("Book Name: {0}", Name);
            Console.Out.WriteLine("Book Publisher: {0}", Publisher);
            Console.Out.WriteLine("Book Price: {0}", Price);
        }

        public void Update()
        {
            Console.Out.Write("Book Name: ");
            Name = Console.ReadLine();
            Console.Out.Write("Book Publisher: ");
            Publisher = Console.ReadLine();
            Console.Out.Write("Book Price: ");
            Price = Console.ReadLine();
        }
    }
}
