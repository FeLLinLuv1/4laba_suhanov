using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4laba_suhanov
{
    public class NoSqlDatabaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Подключение к NoSQL базе данных...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Отключение от NoSQL базы данных...");
        }

        public string ExecuteQuery(string query)
        {
            return $"NoSQL Query executed: {query}";
        }
    }
}
