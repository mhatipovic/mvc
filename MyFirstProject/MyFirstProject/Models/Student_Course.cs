using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class Student_Course
    {
        public int Student_CourseID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }

        public List<Student_Course> GetAllEnrol()
        {
            Student_Course sc1 = new Student_Course();
            sc1.StudentID = 1;
            sc1.CourseID = 1;
            sc1.Grade = 3;
            Student_Course sc2 = new Student_Course();
            sc2.StudentID = 1;
            sc2.CourseID = 2;
            sc2.Grade = 4;
            List<Student_Course> lsc = new List<Student_Course>();
            lsc.Add(sc1);
            lsc.Add(sc2);
            return lsc;
        }
    }
}