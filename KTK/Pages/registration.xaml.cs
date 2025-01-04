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
    /// Interaction logic for registration.xaml
    /// </summary>
    public partial class registration : Page
    {
        public registration()
        {
            InitializeComponent();
        }

        private void ComboBoxRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox box)
            {
                Console.WriteLine(box.SelectedItem.ToString());
                if (box.SelectedItem is ComboBoxItem selectedItem && selectedItem.Content.ToString() == "Студент")
                {
                    BoxGroup.Visibility = Visibility.Visible;
                } 
                else
                {
                    BoxGroup.Visibility = Visibility.Hidden;
                }
            }
        }

        private void GoAuthorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageNavigator.authorization);
        }
    }
}
