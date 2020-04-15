using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

using ASM4;
namespace ASM4
{
    public class LoginDB
    {
        private string connectionString;

        public LoginDB()
        {
            connectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
            return connectionString;
        }


        public bool Login(ref Employee employee)
        {
            bool result = false;
            string SQL = "SELECT * FROM Employee WHERE EmpID = @ID AND EmpPassword=@Password";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", employee.ID);
            command.Parameters.AddWithValue("@Password", employee.Password);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        employee.ID = reader.GetString(0);
                        employee.Password = reader.GetString(1);

                        employee.Role = reader.GetBoolean(2);


                    }
                    result = true;
                }

            }
            return result;
        }
        public bool ChangePass(ref Employee employee)
        {
            bool result = false;
            string SQL = "UPDATE Employee SET EmpPassword = @Password, EmpRole=@Role WHERE EmpID=@ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", employee.ID);
            command.Parameters.AddWithValue("@Password", employee.Password);
            command.Parameters.AddWithValue("@Role", employee.Role);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

                result = command.ExecuteNonQuery() > 0;

            }
            employee.Role = false;
            return result;
        }
        public bool Registry(Employee employee)
        {
            bool result = false;
            string SQL = "INSERT Employee VALUES(@ID,@Password,@Role)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            command.Parameters.AddWithValue("@ID", employee.ID);
            command.Parameters.AddWithValue("@Password", employee.Password);
            command.Parameters.AddWithValue("@Role", employee.Role);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

                result = command.ExecuteNonQuery() > 0;

            }
            return result;
        }
    }
}
