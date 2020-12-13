using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataBaseConnection.ConnectionManager
{

    /// <summary>
    /// Connection Manager Impelementation
    /// Services
    /// </summary>
    public class ConnectionManager : IConnectionManager
    {
        #region ..::Dependency::..

        private string _connectionString = "";

        public ConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }
       
        #endregion

        #region ::Connectetion Services::

        public async Task<bool> ConnectAsync()
        {
            return await Task.Run(async () =>
            {
                try
                {
                    SqlConnection sqlConnection = new(_connectionString);
                    await sqlConnection.OpenAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }

        public bool Connect()
        {
            try
            {
                SqlConnection sqlConnection = new(_connectionString);
                sqlConnection.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region ::DisConnection Services::

        public async Task<bool> DiConnectAsync()
        {
            return await Task.Run(async () =>
            {
                try
                {
                    SqlConnection sqlConnection = new(_connectionString);
                    await sqlConnection.CloseAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }

        public bool DisConnect()
        {
            try
            {
                SqlConnection sqlConnection = new(_connectionString);
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

    }
}
