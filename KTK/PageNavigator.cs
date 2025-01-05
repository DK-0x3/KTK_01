using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTK.Pages;

namespace KTK
{
    public static class PageNavigator
    {
        private static registration Registration;
        public static registration registration
        {
            get
            {
                if (Registration == null)
                {
                    Registration = new registration();
                    return Registration;
                }
                else
                {
                    return Registration;
                }
            }
        }

        private static authorization Authorization;
        public static authorization authorization
        {
            get
            {
                if (Authorization == null)
                {
                    Authorization = new authorization();
                    return Authorization;
                }
                else
                {
                    return Authorization;
                }
            }
        }

        private static mainStudent MainStudent;
        public static mainStudent mainStudent
        {
            get
            {
                if (MainStudent == null)
                {
                    MainStudent = new mainStudent();
                    return MainStudent;
                }
                else
                {
                    return MainStudent;
                }
            }
        }

        private static mainTeacher MainTeacher;
        public static mainTeacher mainTeacher
        {
            get
            {
                if (MainTeacher == null)
                {
                    MainTeacher = new mainTeacher();
                    return MainTeacher;
                }
                else
                {
                    return MainTeacher;
                }
            }
        }

        private static mainAdmin MainAdmin;
        public static mainAdmin mainAdmin
        {
            get
            {
                if (MainAdmin == null)
                {
                    MainAdmin = new mainAdmin();
                    return MainAdmin;
                }
                else
                {
                    return MainAdmin;
                }
            }
        }

        private static scheduleStudent ScheduleStudent;
        public static scheduleStudent scheduleStudent
        {
            get
            {
                if (ScheduleStudent == null)
                {
                    ScheduleStudent = new scheduleStudent();
                    return ScheduleStudent;
                }
                else
                {
                    return ScheduleStudent;
                }
            }
        }


        private static scheduleTeacher ScheduleTeacher;
        public static scheduleTeacher scheduleTeacher
        {
            get
            {
                if (ScheduleTeacher == null)
                {
                    ScheduleTeacher = new scheduleTeacher();
                    return ScheduleTeacher;
                }
                else
                {
                    return ScheduleTeacher;
                }
            }
        }

        private static studentTeacher StudentTeacher;
        public static studentTeacher studentTeacher
        {
            get
            {
                if (StudentTeacher == null)
                {
                    StudentTeacher = new studentTeacher();
                    return StudentTeacher;
                }
                else
                {
                    return StudentTeacher;
                }
            }
        }

        private static teacherStudent TeacherStudent;
        public static teacherStudent teacherStudent
        {
            get
            {
                if (TeacherStudent == null)
                {
                    TeacherStudent = new teacherStudent();
                    return TeacherStudent;
                }
                else
                {
                    return TeacherStudent;
                }
            }
        }
    }
}
