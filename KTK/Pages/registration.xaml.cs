using KTK.api;
using KTK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Group = KTK.api.Group;

namespace KTK.Pages
{
    /// <summary>
    /// Interaction logic for registration.xaml
    /// </summary>
    public partial class registration : Page
    {
        private User _user;
        private Group _group;
        public registration()
        {
            InitializeComponent();
            _user = new User();
            _group = new Group();
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


        private bool validate()
        {
            if (loginTextBox.Text.Length>4 && passwordTextBox.Password.Length>6 && emailTextBox.Text!="" && fioTextBox.Text.Length>4 && selectetRoleComboBox.Text!="")
            {
               if (selectetRoleComboBox.Text == UserRole.Student)
                {
                    if (BoxGroup.Text != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        private void GoAuthorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageNavigator.authorization);
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            bool validateUser  = validate();

            if (validateUser)
            {
                int userID = _user.Registration($"INSERT INTO [User] ([email],[fio],[login],[password],[role])" +
                    $" OUTPUT INSERTED.id " +
                    $" VALUES " +
                    $"( N'{emailTextBox.Text}', N'{fioTextBox.Text}', N'{loginTextBox.Text}', N'{passwordTextBox.Password}', N'{selectetRoleComboBox.Text}')");

                if (selectetRoleComboBox.Text == UserRole.Student)
                {
                    bool answer = _group.CheckGroupOnCreated($"Select * FROM [Group] WHERE name = N'{BoxGroup.Text}'");
                    if (answer)
                    {
                        int groupID = _group.GetIdByNameGroup($"Select id FROM [Group] WHERE name = '{BoxGroup.Text}'");
                        _group.MergeGroupAndUser($"INSERT INTO [UserGroup] ([group],[user]) VALUES ({groupID},{userID})");
                    }
                    else
                    {
                        int groupID = _group.AppendGroupForUser(
                        $"INSERT INTO [Group] ([name]) " +
                        $"OUTPUT INSERTED.id" +
                        $" VALUES ('{BoxGroup.Text}')");

                        _group.MergeGroupAndUser($"INSERT INTO [UserGroup] ([group],[user]) VALUES ({groupID},{userID})");
                    }
                }
              

                navigateUser(selectetRoleComboBox.Text);
            }
            else
            {
                MessageBox.Show("Увы введите незаполненые поляяяя");
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


    }
}
