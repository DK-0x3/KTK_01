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
        public void CreateScheduleItems(DateTime date, List<ScheduleModel> scheduleList)
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
            }
        }
    }
}
