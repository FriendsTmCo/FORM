using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection.ConnectionManager
{
    public interface IConnectionManager
    {
        Task<bool> ConnectAsync();
        bool Connect();
    }
}
