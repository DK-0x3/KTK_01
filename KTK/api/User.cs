using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTK.api
{
    public class User : Database
    {
        private Database _database;

        public User()
        {
            _database = new Database();
        }
        public bool Authorization(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (command.ExecuteScalar() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
