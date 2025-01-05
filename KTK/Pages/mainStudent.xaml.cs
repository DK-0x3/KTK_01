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
    /// Логика взаимодействия для mainStudent.xaml
    /// </summary>
    public partial class mainStudent : Page
    {
        public mainStudent()
        {
            InitializeComponent();
        }

        private void goScheduleStudent_Click(object sender, RoutedEventArgs e)
        {
            FrameStudent.NavigationService.Navigate(PageNavigator.scheduleStudent);
        }
        private void goTeacherStudent_Click(object sender, RoutedEventArgs e)
        {
            FrameStudent.NavigationService.Navigate(PageNavigator.teacherStudent);
        }

        private void goExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
