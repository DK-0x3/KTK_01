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
    /// Логика взаимодействия для scheduleTeacher.xaml
    /// </summary>
    public partial class scheduleTeacher : Page
    {
        public scheduleTeacher()
        {
            InitializeComponent();
            var scheduleList = new List<ScheduleModel>();
          }
    }
}
