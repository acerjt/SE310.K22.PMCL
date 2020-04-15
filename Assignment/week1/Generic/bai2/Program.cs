using System;
using System.Collections.Generic;

namespace bai2
{
    class Customer {
        public string ID {get; set;}
        public string Name {get; set;}
    }
    
    class Student {
        public string ID {get; set;}
        public string Name {get; set;}
    }

    class MyGenClass<T> {
        private List<T> list = new List<T>();
        public void Add(T newElement) {
            list.Add(newElement);
        }

        public void Display() {
            foreach (dynamic item in list)
                Console.WriteLine("ID = {0}, Name = {1}", item.ID, item.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenClass<Customer> customerList = new MyGenClass<Customer>();
            Customer cus001 = new Customer {
                ID = "Cus001",
                Name = "Tom"
            };
            Customer cus002 = new Customer {
                ID = "Cus002",
                Name = "Marry"
            };
            customerList.Add(cus001);
            customerList.Add(cus002);
            customerList.Display();
            

            MyGenClass<Student> studentList = new MyGenClass<Student>();
            Student stu001 = new Student {
                ID = "Stu003",
                Name = "Tomy"
            };
            Student stu002 = new Student {
                ID = "Stu004",
                Name = "Peter"
            };
            studentList.Add(stu001);
            studentList.Add(stu002);
            studentList.Display();
        }
    }
}
