using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1
{
    class DB
    {
        public void Select(SqlConnection connection)
        {
            var sql = "SELECT * FROM Customers";
            var command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
        }
        public void Insert(SqlConnection connection, int id, string regionName)
        {
            var sql = "INSERT INTO  Region(RegionID, RegionDescription) VALUES (@id, '@regionName')";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@regionName", regionName);

            int affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows inserted");
        }
        public void Delete(SqlConnection connection, int id, string regionName)
        {
            var sql = "DELETE FROM Customers WHERE RegionName = 'Bielsko'";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue(id);
            command.Parameters.AddWithValue(regionName);
        }
    }
}
