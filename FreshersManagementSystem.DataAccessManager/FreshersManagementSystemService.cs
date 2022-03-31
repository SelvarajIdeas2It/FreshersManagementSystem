using FreshersManagementSystem.Model;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FreshersManagementSystem.DataAccessManager
{
    public class FreshersManagementSystemService : IFFreshersManagementSystemService
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataManager dataAccessManager = new DataManager();

        public FreshersManagementSystemControl()
        {
        }

        /// <summary>
        /// Its Gets and add new frehsers details
        /// </summary>
        /// <param name="fresher">The fresher which want to be inseret</param>
        /// <returns></returns>
        public int InsertFresher(Fresher fresher)
        {
            string commandText = $"spSave {fresher.id}, '{fresher.name}',  '{fresher.emailId}'," 
                + $"{fresher.mobileNumber}, '{fresher.qualification}', "
                + $"'{fresher.dateOfBirth:yyyy-MM-dd HH:mm:ss.fff}', '{fresher.address}','INSERT'";
            int affectedRows = 0;
            try
            {
                connection = dataAccessManager.GetConnection();
                connection.Open();
                command = dataAccessManager.GetCommand(commandText, connection);
                affectedRows = command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                affectedRows = 0;
            }
            finally
            {
                connection.Close();
            }
            return affectedRows;
        }

        /// <summary>
        /// Updtae fresher
        /// </summary>
        /// <param name="fresherToUpdate"></param>
        /// <returns></returns>
        public int UpdateFresher(Fresher fresherToUpdate)
        {
            string commandText = $"spSave {fresherToUpdate.id}, '{fresherToUpdate.name}',  '{fresherToUpdate.emailId}'," +
                    $"{fresherToUpdate.mobileNumber}, '{fresherToUpdate.qualification}', '{fresherToUpdate.dateOfBirth}', " +
                    $"'{fresherToUpdate.address}','UPDATE'";
            int affectedRows = 0;
            try
            {
                connection = dataAccessManager.GetConnection();
                connection.Open();
                command = dataAccessManager.GetCommand(commandText, connection);
                affectedRows = command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception);
            }
            finally
            {
                connection.Close();
            }
            return affectedRows;
        }

        /// <summary>
        /// Gets user name and search the frsher according to respective freshers name
        /// </summary>
        /// <param name="freshersName">The frehser name which want to be search</param>
        /// <returns name="freshers">The list of frehsers which want to be search</returns>
        public DataTable SearchFresherByName(string freshersName)
        {
            string commandText = $"spFetchFresherByName '{freshersName}'";
            DataTable freshers = new DataTable();
            try
            {
                connection = dataAccessManager.GetConnection();
                connection.Open();
                var sqlDataAdapter = new SqlDataAdapter(commandText, connection);
                sqlDataAdapter.Fill(freshers);
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error : " + sqlException.Message);
            }
            finally
            {
                connection.Close();
            }
            return freshers;
        }

        /// <summary>
        /// Delete Fresher
        /// </summary>
        /// <param name="fresherId"></param>
        /// <returns></returns>
        public String DeleteFresher(int fresherId)
        {
            int affectedRows = 0;
            string commandText = $"spDeleteFresher {fresherId}";
            try
            {
                connection = dataAccessManager.GetConnection();
                connection.Open();
                command = dataAccessManager.GetCommand(commandText, connection);
                affectedRows = command.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error : " + sqlException.Message);
            }
            finally
            {
                connection.Close();
            }
            return (1 == affectedRows ? "Fresher with id " + fresherId + " Deleted Successfully" 
                : " Error While Delete Fresher with id " + fresherId );
        }

        /// <summary>
        /// Fetch All fresher
        /// </summary>
        /// <returns name="freshers">Which contains all the freshers details</returns>
        public DataTable FetchAllFreshers()
        {
            string commandText = $"spFetchAllFresher";
            DataTable freshers = new DataTable();
            try
            {
                connection = dataAccessManager.GetConnection();
                connection.Open();
                var sqlDataAdapter = new SqlDataAdapter(commandText, connection);
                sqlDataAdapter.Fill(freshers);
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error : " + sqlException.Message);
            }
            finally
            {
                connection.Close();
            }
            return freshers;
        }
    }
}