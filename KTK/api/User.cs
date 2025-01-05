using KTK.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KTK.api
{
    public class User : Database
    {
        private Database _database;
        private UserModel _modelUser;

        public User()
        {
            _database = new Database();
            _modelUser = new UserModel();
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

        public int Registration(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
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

        public void MergeGroupAndUser(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
