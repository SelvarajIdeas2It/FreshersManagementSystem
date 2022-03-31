
namespace FreshersManagementSystem.DataAccessManager
{
    /// <summary>
    /// Its initialize an connection between application and database
    /// </summary>
    public class DataManager
    {
        public DataManager()
        {

        }

        /// <summary>
        /// Its initialize an connection and return it
        /// </summary>
        /// <returns name="sqlConnection"></returns>
        public System.Data.SqlClient.SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-N6LP77Q\\MSSQLSERVER01;Initial Catalog=Freshers_Management_System;Integrated Security=True";
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            return sqlConnection;
        }

        /// <summary>
        /// Gets conection and command and return sql server command for doing database operations
        /// </summary>
        /// <param name="commandText">text formate sql command</param>
        /// <param name="sqlConnection">db connection for creating sql command</param>
        /// <returns></returns>
        public System.Data.SqlClient.SqlCommand GetCommand(string commandText, System.Data.SqlClient.SqlConnection sqlConnection)
        {
            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand(commandText, sqlConnection);
            return sqlCommand;
        }
    }
}
