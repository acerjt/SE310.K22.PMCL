using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ProductStore
{
    class ProductData
    {
        string strConnection;

        public ProductData()
        {
            getConnectionString();
        }

        public string getConnectionString()
        {
            strConnection = ConfigurationManager.ConnectionStrings["SaleDB"].ConnectionString;

            return strConnection;
        }

        public DataTable GettProducts()
        {
            string SQL = "SELECT * FROM Products";
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
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTableProduct;
        }

        public bool AddProduct(Products products)
        {
            bool result;
            SqlConnection connection = new SqlConnection(strConnection);
            string SQL = "INSERT Products Values(@ID,@Name,@Price,@Quantity)";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ID", products.ProductID);
            command.Parameters.AddWithValue("@Name", products.ProductName);
            command.Parameters.AddWithValue("@Price", products.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", products.Quantity);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                result = command.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return result;
        }
        public bool UpdateProduct(Products products)
        {
            bool result;
            SqlConnection connection = new SqlConnection(strConnection);
            string SQL = "UPDATE Products SET ProductName=@Name,UnitPrice=@Price,Quantity=@Quantity WHERE ProductID=@ID";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ID", products.ProductID);
            command.Parameters.AddWithValue("@Name", products.ProductName);
            command.Parameters.AddWithValue("@Price", products.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", products.Quantity);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                result = command.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return result;
        }
         public bool DeleteProduct(int ProductID)
        {
            bool result;
            SqlConnection connection = new SqlConnection(strConnection);
            string SQL = "DELEtE Products WHERE ProductID=@ID";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ID", ProductID);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                result = command.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return result;
        }
    }
}
