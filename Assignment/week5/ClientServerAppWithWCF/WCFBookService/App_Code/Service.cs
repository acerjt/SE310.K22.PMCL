using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	string connectionString = "server=.;database=Manager;uid=sa;pwd=123456";
	public void AddBook(Book book)
	{	
		SqlConnection connection = new SqlConnection(connectionString);
		string SQL = "INSERT Books VALUES(@ID,@Title,@Price,@Quantity)";
		SqlCommand command = new SqlCommand(SQL, connection);

		command.Parameters.AddWithValue("@ID", book.BookID);
		command.Parameters.AddWithValue("@Title", book.BookTitle);
		command.Parameters.AddWithValue("@Price", book.BookPrice);
		command.Parameters.AddWithValue("@Quantity", book.BookQuantity);

		try
		{
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

	public void DeleteBook(Book book)
	{
		SqlConnection connection = new SqlConnection(connectionString);
		string SQL = "DELETE Books WHERE BookID = @ID";
		SqlCommand command = new SqlCommand(SQL, connection);

		command.Parameters.AddWithValue("@ID", book.BookID);

		try
		{
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

	public List<Book> GetAllBooks()
	{
		List<Book> bookList = new List<Book>();
		string SQL = "SELECt * FROM Books";
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = new SqlCommand(SQL, connection);
		connection.Open();
		SqlDataReader sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

		if(sqlDataReader.HasRows)
		{
			while(sqlDataReader.Read())
			{
				Book book = new Book()
				{
					BookID = int.Parse(sqlDataReader["BookID"].ToString()),
					BookTitle = sqlDataReader["BookTitle"].ToString(),
					BookPrice = float.Parse(sqlDataReader["BookPrice"].ToString()),
					BookQuantity = int.Parse(sqlDataReader["BookQuantity"].ToString())
				};
				bookList.Add(book);
			}
		}
		return bookList.OrderByDescending(book => book.BookPrice).ToList();
	}


	public void UpdateBook(Book book)
	{
		SqlConnection connection = new SqlConnection(connectionString);
		string SQL = "UPDATE Books SET BookTitle = @Title, BookPrice = @Price, BookQuantity = @Quantity WHERE BookID = @ID";
		SqlCommand command = new SqlCommand(SQL, connection);

		command.Parameters.AddWithValue("@ID", book.BookID);
		command.Parameters.AddWithValue("@Title", book.BookTitle);
		command.Parameters.AddWithValue("@Price", book.BookPrice);
		command.Parameters.AddWithValue("@Quantity", book.BookQuantity);

		try
		{
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
