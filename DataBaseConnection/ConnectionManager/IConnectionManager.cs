using System.Threading.Tasks;

namespace DataBaseConnection.ConnectionManager
{
    /// <summary>
    /// Connection Manager 
    /// Connection Rules
    /// </summary>
    public interface IConnectionManager
    {
        /// <summary>
        /// Open Data Base Connection Async
        /// </summary>
        /// <returns></returns>
        Task<bool> ConnectAsync();

        /// <summary>
        /// Close Data Base Connection Async
        /// </summary>
        /// <returns></returns>
        Task<bool> DiConnectAsync();

        /// <summary>
        /// Open Data Base Connection
        /// </summary>
        /// <returns></returns>
        bool DisConnect();

        /// <summary>
        ///  Close Data Base Connection
        /// </summary>
        /// <returns></returns>
        bool Connect();
    }
}
