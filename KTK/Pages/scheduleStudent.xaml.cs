using System;
using System.Collections.Generic;
using System.Linq;
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
using KTK.controls;
using KTK.models;

namespace KTK.Pages
{
    /// <summary>
    /// Логика взаимодействия для scheduleStudent.xaml
    /// </summary>
    public partial class scheduleStudent : Page
    {
        public scheduleStudent()
        {
            InitializeComponent();
            var scheduleList = new List<scheduleModel>
            {
            new scheduleModel
            {
                StartTime = DateTime.Now.AddMinutes(30),
                EndTime = DateTime.Now.AddMinutes(90),
                Teacher = "Teacher1",
                Name = "MDK XUITA 101",
                Auditorium = "2222"
            },
            new scheduleModel
            {
                StartTime = DateTime.Now.AddHours(2),
                EndTime = DateTime.Now.AddHours(3),
                Teacher = "Teacher2",
                Name = "MDK AI 205",
                Auditorium = "3333"
            },
            new scheduleModel
            {
                StartTime = DateTime.Now.AddMinutes(120),
                EndTime = DateTime.Now.AddMinutes(180),
                Teacher = "Teacher3",
                Name = "MDK Prog 110",
                Auditorium = "4444"
            },
            new scheduleModel
            {
                StartTime = DateTime.Now.AddMinutes(240),
                EndTime = DateTime.Now.AddMinutes(300),
                Teacher = "Teacher4",
                Name = "MDK CyberSecurity 220",
                Auditorium = "5555"
            },
            new scheduleModel
            {
                StartTime = DateTime.Now.AddHours(5),
                EndTime = DateTime.Now.AddHours(6),
                Teacher = "Teacher5",
                Name = "MDK XUITA 300",
                Auditorium = "6666"
            },
            new scheduleModel
            {
                StartTime = DateTime.Now.AddHours(5),
                EndTime = DateTime.Now.AddHours(6),
                Teacher = "Teacher5",
                Name = "MDK XUITA 300",
                Auditorium = "6666"
            }
            };

            var sh = new scheduleModule();
            sh.CreateScheduleItems(DateTime.Now, scheduleList);
            var sh2 = new scheduleModule();
            sh2.CreateScheduleItems(DateTime.Now, scheduleList);
            var sh3 = new scheduleModule();
            sh3.CreateScheduleItems(DateTime.Now, scheduleList);
            var sh4 = new scheduleModule();
            sh4.CreateScheduleItems(DateTime.Now, scheduleList);
            var sh5 = new scheduleModule();
            sh5.CreateScheduleItems(DateTime.Now, scheduleList);
            var sh6 = new scheduleModule();
            sh6.CreateScheduleItems(DateTime.Now, scheduleList);

            scheduleWrapPanel.Children.Add(sh);
            scheduleWrapPanel.Children.Add(sh2);
            scheduleWrapPanel.Children.Add(sh3);
            scheduleWrapPanel.Children.Add(sh4);
            scheduleWrapPanel.Children.Add(sh5);
            scheduleWrapPanel.Children.Add(sh6);
        }
    }
}
