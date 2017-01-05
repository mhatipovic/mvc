using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class SchoolInit:DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            Student st = new Student();
            List<Student> listOfStudents = st.GetAllStudents();
            foreach(var s in listOfStudents)
                context.Students.Add(s);
            Course co = new Course();
            List<Course> listOfCourses = co.GetAllCourses();
            foreach (var c in listOfCourses)
                context.Coursess.Add(c);
            Student_Course sc = new Student_Course();
            List<Student_Course> lsc = sc.GetAllEnrol();
            foreach (var e in lsc)
                context.Enrollments.Add(e);

            context.SaveChanges();

        }
    }
}