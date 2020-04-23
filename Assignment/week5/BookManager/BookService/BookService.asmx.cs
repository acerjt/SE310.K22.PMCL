using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


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

        string connectionString = "server=.;database=Manager;uid=sa;password=123456";
        public BookService()
        {

        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        
        [WebMethod]
        public DataSet GetBookList()
        {
            DataSet bookList = new DataSet();
            try
            {
                string SQL = "SELECT * FROM Books";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, connectionString);
                dataAdapter.Fill(bookList);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return bookList;
        }

        [WebMethod]
        public void AddBook(int BookID, string BookTitle, float BookPrice, int BookQuantity)
        {
            string SQL = "INSERT Books VALUES(@ID,@TITLE,@PRICE,@QUANTITY)";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", BookID);
            command.Parameters.AddWithValue("@TITLE", BookTitle);
            command.Parameters.AddWithValue("@PRICE", BookPrice);
            command.Parameters.AddWithValue("@QUANTITY", BookQuantity);


            try
            {
                if(connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        [WebMethod]
        public void DeleteBook(int BookID)
        {
            string SQL = "DELETE Books WHERE BookID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", BookID);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        [WebMethod]
        public void UpdateBook(int BookID, string BookTitle, float BookPrice, int BookQuantity)
        {
            string SQL = "UPDAtE Books SET BookTitle=@TITLE, BookPrice=@PRICE, BookQuantity=@QUANTITY WHERE BookID=@ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", BookID);
            command.Parameters.AddWithValue("@TITLE", BookTitle);
            command.Parameters.AddWithValue("@PRICE", BookPrice);
            command.Parameters.AddWithValue("@QUANTITY", BookQuantity);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
