using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using KTK.api;
using KTK.controls;
using KTK.models;
using Windows.Globalization;
using Windows.System;

namespace KTK.Pages
{
    /// <summary>
    /// Логика взаимодействия для scheduleStudent.xaml
    /// </summary>
    public partial class scheduleStudent : Page
    {
        private Schedule _schedule;
        private List<ScheduleModel> _scheduleListMonday;
        private List<ScheduleModel> _scheduleListTuesday;
        private List<ScheduleModel> _scheduleListWidnesday;
        private List<ScheduleModel> _scheduleListThursday;
        private List<ScheduleModel> _scheduleListFriday;
        private List<ScheduleModel> _scheduleListSaturday;
        public scheduleStudent()
        {
            InitializeComponent();
            _scheduleListMonday = new List<ScheduleModel>();
            _scheduleListTuesday = new List<ScheduleModel>();
            _scheduleListWidnesday = new List<ScheduleModel>();
            _scheduleListThursday = new List<ScheduleModel>();
            _scheduleListFriday = new List<ScheduleModel>();
            _scheduleListSaturday = new List<ScheduleModel>();
            _schedule = new Schedule();
            LoadData();
        }

        public void LoadData()
        {
            var schedulesMonday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,   \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Понедельник'");
            var schedulesTuesday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,   \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Вторник'");
            var schedulesWidnesday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Среда'");
            var schedulesThursday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Четверг'");
            var schedulesFriday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Пятница'");
            var schedulesSaturday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[group]= {UserStatic.Group} AND [day_of_week] = N'Суббота'");

            foreach (var schedule in schedulesMonday) {
                _scheduleListMonday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListMonday);

                scheduleWrapPanel.Children.Add(sh);
            }

            foreach (var schedule in schedulesTuesday)
            {
                _scheduleListTuesday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListTuesday);

                scheduleWrapPanel.Children.Add(sh);
            }

            foreach (var schedule in schedulesWidnesday)
            {
                _scheduleListWidnesday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListWidnesday);

                scheduleWrapPanel.Children.Add(sh);
            }

            foreach (var schedule in schedulesThursday)
            {
                _scheduleListThursday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListThursday);

                scheduleWrapPanel.Children.Add(sh);
            }

            foreach (var schedule in schedulesFriday)
            {
                _scheduleListFriday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListFriday);

                scheduleWrapPanel.Children.Add(sh);
            }

            foreach (var schedule in schedulesSaturday)
            {
                _scheduleListSaturday.Add(schedule);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedule.FullDate, _scheduleListSaturday);

                scheduleWrapPanel.Children.Add(sh);
            }
        }
    }
}
