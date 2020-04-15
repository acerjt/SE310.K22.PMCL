using System;

namespace ASM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine med = new Medicine();
            med.Accept();
            med.IncreaseQuantity();
            Console.WriteLine("Test the first Print() method");
            med.Print();
            Console.WriteLine("Test the second Print() method");
            med.Print("code");
            Console.WriteLine("Test the third Print() method");
            med.Print("code", "name");
            
        }
    }
}
