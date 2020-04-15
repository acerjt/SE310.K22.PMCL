using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BookStore
{
    class BookData
    {
        string strConnection;

        public BookData()
        {
            strConnection = getConnectionString();
        }

        public string getConnectionString()
        {
            string strConnection = "server=.;database=Manager;uid=sa;pwd=123456";
            return strConnection;
        }

        public DataTable getBooks()
        {
            string SQL = "SELECT * FROM Books";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(SQL, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataBook = new DataTable();

            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sqlDataAdapter.Fill(dataBook);
            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataBook;
        }

        public bool addNewBook(Book book)
        {
            string sql = "INSERT Books VALUES (@ID,@Title,@Price,@Quantity)";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ID", book.BookID);
            command.Parameters.AddWithValue("@Title", book.BookTitle);
            command.Parameters.AddWithValue("@Quantity", book.BookQuantity);
            command.Parameters.AddWithValue("@Price", book.BookPrice);
            
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int count = command.ExecuteNonQuery();
            return count > 0;
        }
        public bool updateBook(Book book)
        {
            string sql = "UPDAtE Books SET BookTitle =@Title,BookQuantity=@Quantity,BookPrice =@Price WHERE BookID = @ID";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ID", book.BookID);
            command.Parameters.AddWithValue("@Title", book.BookTitle);
            command.Parameters.AddWithValue("@Quantity", book.BookQuantity);
            command.Parameters.AddWithValue("@Price", book.BookPrice);
            
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int count = command.ExecuteNonQuery();
            return count > 0;
        }
        public bool deleteBook(int ID)
        {
            string sql = "DELETE Books WHERE BookID = @ID";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ID", ID);
            
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int count = command.ExecuteNonQuery();
            return count > 0;
        }


    }
}
