using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class MyBookLibrary
    {

        public List<Book> books = new List<Book>();

      

        public void AddNewBook()
        {
            Book book = new Book();
            book.Input();
	    if(Find(book.ID) == null)
	    {
		books.Add(book);
	    }
	    else
		Console.WriteLine("Book is exist");            	
        }

        public void UpdateBook(string bookID)
        {
            Book book = Find(bookID);
            if(book == null)
            {
                Console.Out.WriteLine("Book does not exist");
            }
            else
            {
                book.Update();
            }
        }

        public void DeleteBook(string bookID)
        {
            Book book = Find(bookID);
            if (book == null)
            {
                Console.Out.WriteLine("Book does not exist");
            }
            else
            {
                books.Remove(book);
            }
        }

        public Book Find(string bookID)
        {
            Book book = books.SingleOrDefault(x => x.ID == bookID);
            return book;
        }

    }
}
