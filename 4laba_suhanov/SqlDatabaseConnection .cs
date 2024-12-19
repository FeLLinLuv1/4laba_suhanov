using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4laba_suhanov
{
    public class SqlDatabaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Подключение к SQL базе данных...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Отключение от SQL базы данных...");
        }

        public string ExecuteQuery(string query)
        {
            return $"SQL Query executed: {query}";
        }
    }
}
