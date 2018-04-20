using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=DB_171;Integrated Security=True";
            string sqlQuery = "CREATE TABLE gruppa ( id int not null, name varchar(255) null)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Создано");
            }
            Console.Read();
        }
    }
}
