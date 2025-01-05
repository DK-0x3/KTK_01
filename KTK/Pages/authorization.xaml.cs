using KTK.api;
using KTK.models;
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
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Page
    {
        private User _user;
        public authorization()
        {
            InitializeComponent();
            _user = new User();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {

            bool validateInput = validate();

            if (validateInput) {
                bool answer = _user.Authorization($"SELECT * FROM [User] WHERE [login] = '{loginTextBox.Text}' AND [password] = '{passwordTextBox.Password}'");
                if (answer == true)
                {
                    MessageBox.Show("Вперед и только вперед");
                    NavigationService.Navigate(PageNavigator.mainStudent);
                }
                else
                {
                    MessageBox.Show("Что то тут не так");
                }
            }
            else
            {
                MessageBox.Show("Введите все данные плииииз");
            }
        }

        public void navigateUser(string role)
        {
            if (role == UserRole.Student)
            {
                NavigationService.Navigate(PageNavigator.mainStudent);
            }

            if (role == UserRole.Teacher)
            {
                NavigationService.Navigate(PageNavigator.mainTeacher);
            }
        }

        private bool validate()
        {
            if (loginTextBox.Text!="" && passwordTextBox.Password!="")
            {
                return true;
            }

            return false;
        }
        
        private void GoRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageNavigator.registration);
        }
    }
}
