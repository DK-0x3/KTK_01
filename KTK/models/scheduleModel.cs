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
        public int GroupId { get; set; } 
        public int UserId { get; set; }  
        public int RoomId { get; set; }  
        public DateTime ScheduleDate { get; set; } 
        public string DayOfWeek { get; set; }
        public TimeSpan EndTime { get; set; }
        public int SubjectId { get; set; } 
        public DateTime FullDate { get; set; } 
    }
}
