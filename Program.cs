using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "";      //ta nazwa
            using var connection = new SqlConnection(connectionString);
            var db = new DB();
            connection.Open();

            db.Select(connection);
            db.Insert(connection, 10, "Bielsko");
            db.Delete(connection, 10, "Bielsko");

            connection.Close();
        }
    }
}
