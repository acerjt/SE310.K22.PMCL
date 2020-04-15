using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM2;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBookLibrary myBookLibrary = new ASM2.MyBookLibrary();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Add new book");
                Console.WriteLine("2. Update a book");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. List all book");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");

                int choice = Int32.Parse(Console.ReadLine());
                string bookID;
                switch(choice)
                {
                    case 1:
                        myBookLibrary.AddNewBook();
                        break;
                    case 2:
                        Console.Write("Book ID to update: ");
                        bookID = Console.ReadLine();
                        myBookLibrary.UpdateBook(bookID);
                        break;
                    case 3:
                        Console.Write("Book ID to delete");
                        bookID = Console.ReadLine();
                        myBookLibrary.DeleteBook(bookID);
                        break;
                    case 4:
                        myBookLibrary.books.ForEach(
                            x => x.Output()
                            );
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
