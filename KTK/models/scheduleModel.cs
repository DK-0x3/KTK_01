using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KTK.models
{
    public class ScheduleModel : DependencyObject
    {
        public int Id { get; set; }
        public string Group { get; set; } 
        public string Fio { get; set; }  
        public string Room { get; set; }  
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string DayOfWeek { get; set; }
        public string Subject { get; set; } 
        public DateTime FullDate { get; set; } 
    }
}
