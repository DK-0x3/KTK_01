using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
    /// Логика взаимодействия для scheduleTeacher.xaml
    /// </summary>
    public partial class scheduleTeacher : Page
    {
        private Schedule _schedule;
        private List<ScheduleModel> _scheduleListMonday;
        private List<ScheduleModel> _scheduleListTuesday;
        private List<ScheduleModel> _scheduleListWidnesday;
        private List<ScheduleModel> _scheduleListThursday;
        private List<ScheduleModel> _scheduleListFriday;
        private List<ScheduleModel> _scheduleListSaturday;
        public scheduleTeacher()
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
            var schedulesMonday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,   \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Понедельник'");
            var schedulesTuesday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,   \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Вторник'");
            var schedulesWidnesday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Среда'");
            var schedulesThursday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Четверг'");
            var schedulesFriday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Пятница'");
            var schedulesSaturday = _schedule.GetInfoOnSchedules($"SELECT DISTINCT  \t[Group].[name] as group_name, \r\n\t[User].[fio] as [user_name],\r\n\t[Room].[name] as room_name,\r\n\t[Subject].[name] as subject_name,  \r\n\t[day_of_week],\r\n\t[start_time],\r\n\t[end_time],\r\n\t[full_date]\r\nFROM [Schedule]\r\nINNER JOIN [Group] ON [Group].id = [Schedule].[group]\r\nINNER JOIN [User] ON [User].id = [Schedule].[user]\r\nINNER JOIN [Room] ON [Room].id = [Schedule].[room]\r\nINNER JOIN [Subject] ON [Subject].id = [Schedule].[subject]\r\nWHERE [Schedule].[user]= {UserStatic.ID} AND [day_of_week] = N'Суббота'");

            if (schedulesMonday.Any())
            {
                _scheduleListMonday.AddRange(schedulesMonday);
                var sh = new scheduleModule();
                sh.CreateScheduleItems(schedulesMonday.First().FullDate, _scheduleListMonday);

                scheduleWrapPanel.Children.Add(sh);
            }

            if (schedulesTuesday.Any())
            {
                _scheduleListTuesday.AddRange(schedulesTuesday);
                var sh1 = new scheduleModule();
                sh1.CreateScheduleItems(schedulesTuesday.First().FullDate, _scheduleListTuesday);

                scheduleWrapPanel.Children.Add(sh1);
            }

            if (schedulesWidnesday.Any())
            {
                _scheduleListWidnesday.AddRange(schedulesWidnesday);
                var sh2 = new scheduleModule();
                sh2.CreateScheduleItems(schedulesWidnesday.First().FullDate, _scheduleListWidnesday);

                scheduleWrapPanel.Children.Add(sh2);
            }

            if (schedulesThursday.Any()) { 
                _scheduleListThursday.AddRange(schedulesThursday);
            var sh3 = new scheduleModule();
            sh3.CreateScheduleItems(schedulesThursday.First().FullDate, _scheduleListThursday);

            scheduleWrapPanel.Children.Add(sh3);
        }

            if (schedulesFriday.Any())
            {
                _scheduleListFriday.AddRange(schedulesFriday);
                var sh4 = new scheduleModule();
                sh4.CreateScheduleItems(schedulesFriday.First().FullDate, _scheduleListFriday);

                scheduleWrapPanel.Children.Add(sh4);
            }

            if (schedulesSaturday.Any())
            {
                _scheduleListSaturday.AddRange(schedulesSaturday);
                var sh5 = new scheduleModule();
                sh5.CreateScheduleItems(schedulesSaturday.First().FullDate, _scheduleListSaturday);

                scheduleWrapPanel.Children.Add(sh5);
            }
        }
    }
}
