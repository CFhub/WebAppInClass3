using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppInClass3
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public double Credits { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public Student()
        {

        }
        public Student(string studentid,
                        string studentname,
                        double credits,
                        string emergencyphone)
        {
            StudentID = studentid;
            StudentName = studentname;
            Credits = credits;
            EmergencyPhoneNumber = emergencyphone;
        }
    }
}