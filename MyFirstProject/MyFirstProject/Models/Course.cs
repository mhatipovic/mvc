using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }  
        public int TotalCredits { get; set; }
        public ICollection<Student_Course> Enrollments { get; set; }

        public List<Course> GetAllCourses()
        {
            Course m = new Course();
            m.CourseName = "math";
            m.TotalCredits = 15;
            Course j = new Course();
            j.CourseName = "java";
            j.TotalCredits = 10;
            List<Course> all = new List<Course>();
            all.Add(m);
            all.Add(j);
            return all;
        }
    }
}