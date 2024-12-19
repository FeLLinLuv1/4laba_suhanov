using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4laba_suhanov
{
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
        string ExecuteQuery(string query);
    }
}
