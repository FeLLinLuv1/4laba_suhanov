using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4laba_suhanov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Использование SQL Database
            IDatabaseConnection sqlConnection = new SqlDatabaseConnection();
            DataManager sqlDataManager = new DataManager(sqlConnection);
            sqlDataManager.ExecuteDatabaseQuery("SELECT * FROM Users;");

            Console.WriteLine();

            // Использование NoSQL Database
            IDatabaseConnection noSqlConnection = new NoSqlDatabaseConnection();
            DataManager noSqlDataManager = new DataManager(noSqlConnection);
            noSqlDataManager.ExecuteDatabaseQuery("{ find: 'users' }");

            Console.ReadLine();
        }
    }
}
