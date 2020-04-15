using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ASM3
{
    public class ProductDB
    {
        private string connectionString;
        public ProductDB()
        {
            connectionString = getConnectionString();
        }

        public string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SaleDB"].ConnectionString;
        }

        public bool AddNewProduct(Product p)
        {
            bool result;
            SqlConnection connection = new SqlConnection(connectionString);
            string SQL = "INSERT Products VALUES(@ProductID,@ProductName,@UnitPrice,@Quantity)";

            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ProductID", p.ProductID);
            command.Parameters.AddWithValue("@ProductName", p.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", p.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", p.Quantity);

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
        public bool RemoveProduct(Product p)
        {
            bool result;
            SqlConnection connection = new SqlConnection(connectionString);
            string SQL = "DELETE Products WHERE ProductID =@ProductID";

            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ProductID", p.ProductID);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                result = command.ExecuteNonQuery() > 0;
            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }

            return result;


        }
        public bool UpdateProduct(Product p)
        {
            bool result;
            SqlConnection connection = new SqlConnection(connectionString);
            string SQL = "UPDATE Products SET ProductName=@ProductName,UnitPrice=@UnitPrice,Quantity=@Quantity WHERE ProductID=@ProductID";

            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@ProductID", p.ProductID);
            command.Parameters.AddWithValue("@ProductName", p.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", p.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", p.Quantity);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                result = command.ExecuteNonQuery() > 0;
            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }

            return result;


        }
        private Product MakeProduct(DataRow row)
        {
            int ProductId = int.Parse(row["ProductID"].ToString());
            string ProductName = row["ProductName"].ToString();
            int Quantity = int.Parse(row["Quantity"].ToString());
            float UnitPrice = float.Parse(row["UnitPrice"].ToString());

            return new Product(ProductId, ProductName, Quantity, UnitPrice);
        }
        public List<Product> GettProducts()
        {
            string SQL = "SELECT * FROM Products";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTableProduct = new DataTable();
            List<Product> products = new List<Product>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlDataAdapter.Fill(dataTableProduct);
                foreach (DataRow row in dataTableProduct.Rows)
                    products.Add(MakeProduct(row));
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return products;
        }
        public Product FindProduct(int ProductID)
        {
            Product product = GettProducts().Find(x => x.ProductID == ProductID);
            return product;
        }
    }
}
