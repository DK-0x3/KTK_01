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
using KTK.models;

namespace KTK.controls
{
    /// <summary>
    /// Логика взаимодействия для scheduleModule.xaml
    /// </summary>
    public partial class scheduleModule : UserControl
    {
        public scheduleModule()
        {
            InitializeComponent();
        }

        // Метод для создания элементов динамически на основе данных
        public void CreateScheduleItems(DateTime fullDate, List<ScheduleModel> scheduleList)
        {
            foreach (var schedule in scheduleList)
            {
                // Создаем элемент для расписания
                var stackPanel = new StackPanel
                {
                    Background = new SolidColorBrush(Color.FromArgb(255, 78, 78, 80)),
                    Margin = new Thickness(5),
                    Width = 250,
                    MinHeight = 100
                };

                // Добавляем информацию о предмете
                stackPanel.Children.Add(new TextBlock
                {
                    Text = schedule.Subject,
                    Foreground = new SolidColorBrush(Colors.White),
                    FontSize = 14,
                    Margin = new Thickness(0, 5, 0, 5)
                });

                // Добавляем информацию о времени
                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"{schedule.StartTime} - {schedule.EndTime}",
                    Foreground = new SolidColorBrush(Colors.Gray),
                    FontSize = 12,
                    Margin = new Thickness(0, 0, 0, 5)
                });

                // Добавляем информацию о преподавателе
                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"Преподаватель: {schedule.Fio}",
                    Foreground = new SolidColorBrush(Colors.White),
                    FontSize = 12
                });

                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"Кабинет: {schedule.Room}",
                    Foreground = new SolidColorBrush(Colors.White),
                    FontSize = 12
                });

                // Добавляем расписание в панель
                ScheduleWrapPanel.Children.Add(stackPanel);
            }
        }

    }
}
