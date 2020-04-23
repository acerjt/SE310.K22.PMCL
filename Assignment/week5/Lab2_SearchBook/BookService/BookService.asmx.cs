using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BookService
{
    /// <summary>
    /// Summary description for BookService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Book> GetBookList()
        {
            BookDataContext bookData = new BookDataContext();
            return bookData.Books.ToList();
        }
        [WebMethod]
        public void AddBook(Book newBook)
        {
            try
            {
                BookDataContext bookData = new BookDataContext();
                bookData.Books.InsertOnSubmit(newBook);
                bookData.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        [WebMethod]
        public void UpdateBook(Book updateBook)
        {
            try
            {
                BookDataContext bookData = new BookDataContext();
                Book book = bookData.Books.SingleOrDefault(b => b.BookID.Equals(updateBook.BookID));
                book.BookPrice = updateBook.BookPrice;
                book.BookTitle = updateBook.BookTitle;
                book.BookQuantity = updateBook.BookQuantity;
                bookData.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        [WebMethod]
        public void DeleteBook(Book deletebook)
        {
            try
            {
                BookDataContext bookData = new BookDataContext();
                Book book = bookData.Books.SingleOrDefault(b => b.BookID.Equals(deletebook.BookID));
                bookData.Books.DeleteOnSubmit(book);
                bookData.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        [WebMethod]
        public List<Book> SearchBook(Book bookInfo)
        {
            try
            {
                BookDataContext bookData = new BookDataContext();
                var result = from b in bookData.Books
                             where b.BookID.Equals(bookInfo.BookID)
                             orderby b.BookPrice descending
                             select b;
                return result.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
