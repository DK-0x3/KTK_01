using KTK.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public (bool isAuth,string role) Authorization(string query)
        {
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (command.ExecuteScalar() != null)
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (true, (string)reader["role"]);
                        }
                    }
                }
            }
            return (false, "");
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

        public Dictionary<string, string> GetDataOnStudentsRole(string query)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string email = reader[0].ToString();
                        string fio = reader[1].ToString();

                        users.Add(email, fio);

                    }
                }
                return users;
            }
        }
        public Dictionary<string, string> GetDataOnTeacheRole(string query)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string email = reader[0].ToString();
                        string fio = reader[1].ToString();

                        users.Add(email, fio);

                    }
                }
                return users;
            }
        }
    }
}
