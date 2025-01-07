using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using KTK.api;
using KTK.controls;
using KTK.models;

namespace KTK.Pages
{
    public partial class scheduleStudent : Page
    {
        private Schedule _schedule;
        private Dictionary<string, List<ScheduleModel>> _scheduleByDay;

        public scheduleStudent()
        {
            InitializeComponent();
            _scheduleByDay = new Dictionary<string, List<ScheduleModel>>()
            {
                { "Понедельник", new List<ScheduleModel>() },
                { "Вторник", new List<ScheduleModel>() },
                { "Среда", new List<ScheduleModel>() },
                { "Четверг", new List<ScheduleModel>() },
                { "Пятница", new List<ScheduleModel>() },
                { "Суббота", new List<ScheduleModel>() }
            };
            _schedule = new Schedule();
            DataContext = this;
            LoadData();
        }

        public void LoadData()
        {
            var schedules = _schedule.GetInfoOnSchedules($@"
                SELECT DISTINCT 
                    [Group].[name] as group_name, 
                    [User].[fio] as user_name,
                    [Room].[name] as room_name,
                    [Subject].[name] as subject_name,   
                    [day_of_week],
                    [start_time],
                    [end_time],
                    [full_date]
                FROM [Schedule]
                INNER JOIN [Group] ON [Group].id = [Schedule].[group]
                INNER JOIN [User] ON [User].id = [Schedule].[user]
                INNER JOIN [Room] ON [Room].id = [Schedule].[room]
                INNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]
                WHERE [Schedule].[group] = {UserStatic.Group}");

            foreach (var schedule in schedules)
            {
                if (_scheduleByDay.ContainsKey(schedule.DayOfWeek))
                {
                    _scheduleByDay[schedule.DayOfWeek].Add(schedule);
                }
            }

            foreach (var day in _scheduleByDay)
            {
                if (day.Value.Any())
                {
                    var sh = new scheduleModule();
                    sh.CreateScheduleItems(day.Value.First().FullDate, day.Value);

                    scheduleWrapPanel.Children.Add(sh);
                }
            }
        }
    }
}
