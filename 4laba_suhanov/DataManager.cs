using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4laba_suhanov
{
    internal class DataManager
    {
        private readonly IDatabaseConnection _databaseConnection;

        public DataManager(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public void ExecuteDatabaseQuery(string query)
        {
            _databaseConnection.Connect();
            Console.WriteLine(_databaseConnection.ExecuteQuery(query));
            _databaseConnection.Disconnect();
        }
    }
}
