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
        public string role { get; set; }
    }


   public static class UserRole
    {
        public const string Student = "Студент";
        public const string Teacher = "Преподаватель";
    }
}
