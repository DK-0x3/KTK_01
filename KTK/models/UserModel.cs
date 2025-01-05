using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTK.models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class UserModelOnDataGrid
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }


   public static class UserRole
    {
        public const string Student = "Студент";
        public const string Teacher = "Преподаватель";
    }
}
