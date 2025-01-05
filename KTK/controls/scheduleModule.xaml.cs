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
        public void CreateScheduleItems(DateTime date, List<scheduleModel> scheduleList)
        {
            dateText.Text = date.ToString("dddd, dd.MM.yy", new System.Globalization.CultureInfo("ru-RU"));

            ScheduleStackPanel.Children.Clear();

            foreach (var schedule in scheduleList)
            {
                var innerGrid1 = new Grid
                {
                    Background = (Brush)new BrushConverter().ConvertFrom("#4E4E50"),
                    Height = 15
                };
                innerGrid1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var label1 = new Label
                {
                    Content = schedule.StartTime.ToString("HH:mm"),
                    FontSize = 10,
                    Foreground = Brushes.Wheat,
                    Margin = new Thickness(5, 0, 0, 0)
                };
                Grid.SetColumn(label1, 0);

                var label2 = new Label
                {
                    Content = schedule.EndTime.ToString("HH:mm"),
                    FontSize = 10,
                    Foreground = Brushes.Wheat,
                    Margin = new Thickness(0, 0, 5, 0),
                    HorizontalAlignment = HorizontalAlignment.Right
                };
                Grid.SetColumn(label2, 1);

                innerGrid1.Children.Add(label1);
                innerGrid1.Children.Add(label2);

                ScheduleStackPanel.Children.Add(innerGrid1);

                var innerGrid2 = new Grid
                {
                    Height = 30
                };
                innerGrid2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                innerGrid2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var label3 = new Label
                {
                    Content = schedule.Name,
                    FontSize = 10,
                    Foreground = Brushes.White,
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(5, 0, 0, 0)
                };

                var label4 = new Label
                {
                    Content = schedule.TeacherAndGroup,
                    FontSize = 8,
                    Foreground = (Brush)new BrushConverter().ConvertFrom("#696969"),
                    VerticalAlignment = VerticalAlignment.Top,
                    Margin = new Thickness(5, 0, 0, 0)
                };
                Grid.SetRow(label4, 1);

                var label5 = new Label
                {
                    Content = schedule.Auditorium,
                    FontSize = 10,
                    Foreground = Brushes.White,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Margin = new Thickness(0, 0, 5, 0)
                };
                Grid.SetRowSpan(label5, 2);
                Grid.SetColumn(label5, 1);

                innerGrid2.Children.Add(label3);
                innerGrid2.Children.Add(label4);
                innerGrid2.Children.Add(label5);
                Grid.SetRow(innerGrid2, 2);

                ScheduleStackPanel.Children.Add(innerGrid2);
            }
        }
    }
}
