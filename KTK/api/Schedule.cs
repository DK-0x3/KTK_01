using KTK.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTK.api
{
    public class Schedule:Database
    {
        private Database _database;
        public Schedule()
        {
            _database = new Database();
        }

        public List<ScheduleModel> GetInfoOnSchedules(string query)
        {
            var result = new List<ScheduleModel>();
            using (var connection = new SqlConnection(_database.connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader()) {

                    while (reader.Read()) {

                        var schedule = new ScheduleModel
                        {
                            Group = reader["group_name"].ToString(),
                            Fio = reader["user_name"].ToString(),
                            Room = reader["room_name"].ToString(),
                            StartTime = (TimeSpan)reader["start_time"],
                            DayOfWeek = reader["day_of_week"].ToString(),
                            EndTime = (TimeSpan)reader["end_time"],
                            Subject = reader["subject_name"].ToString(),
                            FullDate = (DateTime)reader["full_date"],
                        };

                        result.Add(schedule);
                    }

                }

                return result;
            }
        }
    }
}
