using KTK.api;
using KTK.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for studentTeacher.xaml
    /// </summary>
    public partial class studentTeacher : Page
    {
        public ObservableCollection<UserModelOnDataGrid> Users { get; set; }
        private User _user;
        public studentTeacher()
        {
            InitializeComponent();
            DataContext = this;
            Users = new ObservableCollection<UserModelOnDataGrid>();
            _user = new User();
            _ = LoadDataOnUsers();
        }

        private async Task LoadDataOnUsers()
        {
            var users = await Task.Run(() => _user.GetDataOnStudentsRole($"SELECT [email],[fio] FROM [User] WHERE [role] = N'{UserRole.Student}'"));

            foreach (var user in users) { 
            
                Users.Add(new UserModelOnDataGrid 
                {
                    Email= user.Key,Name = user.Value 
                });
            }
            infoUserForDataGrid.ItemsSource = Users;
        }



    }
}
