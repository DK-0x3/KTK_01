using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KTK.models
{
    public class scheduleModel : DependencyObject
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public string TeacherAndGroup {  get; set; }
        public string Auditorium { get; set; }
    }
}
