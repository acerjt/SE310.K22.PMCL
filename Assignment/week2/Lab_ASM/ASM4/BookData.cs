using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASM4
{
    public class BookData
    {
        string strConnection;

        public BookData()
        {
            strConnection = getConnectionString();
        }

        public string getConnectionString()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
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
        public DataTable GettProducts()
        {
            string SQL = "SELECT * FROM Books";
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTableProduct = new DataTable();

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlDataAdapter.Fill(dataTableProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTableProduct;
        }
        public bool addNewBook(Book book)
        {
            string sql = "SET IDENTITY_INSERT Books ON INSERT INTO Books(BookID,BookName,BookPrice) VALUES (@ID,@Name,@Price) SET IDENTITY_INSERT Books OFF";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ID", book.BookID);
            command.Parameters.AddWithValue("@Name", book.BookName);
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
            string sql = "UPDAtE Books SET BookName =@Name,BookPrice =@Price WHERE BookID = @ID";
            SqlConnection connection = new SqlConnection(strConnection);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ID", book.BookID);
            command.Parameters.AddWithValue("@Name", book.BookName);
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
