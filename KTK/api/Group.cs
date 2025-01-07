using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTK.api
{
    public class Group
    {

        private Database _database;
        public Group() {
        _database = new Database();
        }
        public int AppendGroupForUser(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetGroupOnStudnt(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        return (int)reader["group"];

                    }

                }
                return 0;
            }
        }

        public void MergeGroupAndUser(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool CheckGroupOnCreated(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection)) {
            
                connection.Open();

                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int GetIdByNameGroup(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}
