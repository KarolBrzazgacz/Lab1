using System;
using System.Data.SqlClient;

namespace Z1_ADONETCORE
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
