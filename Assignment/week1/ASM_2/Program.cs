using System;

namespace ASM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            uint age;
            String gender;
            DateTime birthday;
            string address;
            string email;
            string fatherName;
            string motherName;

            Console.WriteLine("Enter information: ");
            Console.WriteLine("---------------****---------------");
            Console.Write("Enter student name:");
            name = Console.ReadLine();
            Console.Write("Enter gender (male / female): ");
            gender = Console.ReadLine();
            Console.Write("Enter age:");
            age = uint.Parse(Console.ReadLine());
            Console.Write("Enter birthday (MM/dd/yyyy): ");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter address: ");
            address = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();
            Console.Write("Enter father's name: ");
            fatherName = Console.ReadLine();
            Console.Write("Enter mother's name: ");
            motherName = Console.ReadLine();

            Console.WriteLine("*** Student Information ***\n");
            Console.WriteLine("Student Name: "+ name);
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("Student Gender: " +gender);
            Console.WriteLine("Date of Birth: {0:D}", birthday);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Student's father name: " + fatherName);
            Console.WriteLine("Student's mother name: " + motherName);

            Console.ReadLine();
        }
    }
}
