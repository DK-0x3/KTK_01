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

namespace KTK.Pages
{
    /// <summary>
    /// Логика взаимодействия для mainTeacher.xaml
    /// </summary>
    public partial class mainTeacher : Page
    {
        public mainTeacher()
        {
            InitializeComponent();
            FrameTeacher.NavigationService.Navigate(PageNavigator.scheduleTeacher);
        }

        private void goScheduleTeacher_Click(object sender, RoutedEventArgs e)
        {
            FrameTeacher.NavigationService.Navigate(PageNavigator.scheduleTeacher);
        }

        private void goStudentTeacher_Click(object sender, RoutedEventArgs e)
        {
            FrameTeacher.NavigationService.Navigate(PageNavigator.studentTeacher);
        }

        private void goExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
