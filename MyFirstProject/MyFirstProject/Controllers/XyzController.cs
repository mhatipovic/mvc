using MyFirstProject.Models;
using MyFirstProject.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class XyzController : Controller
    {
        private SchoolContext db = new SchoolContext();
        // GET: Xyz
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Abc()
        //{
        //    Student Alex = new Student();
        //    Alex.FirstName = "alex";
        //    Alex.LastName = "Rod";
        //    return View(Alex);
        //}
        public ActionResult Abc()
        {
            var students = db.Students.ToList();
            return View(students);
            //Course math = new Course();
            //math.CourseName = "Math 101";
            //math.TotalCredits = 4;

            //Student alex = new Student();
            //alex.FirstName = "Alex";
            //alex.LastName = "Rod";
            //alex.Gender = 'm';
            //Student bo = new Student();
            //bo.FirstName = "Bo";
            //bo.LastName = "Kaka";
            //bo.Gender = 'f';
            //Student john = new Student();
            //john.FirstName = "John";
            //john.LastName = "Doe";
            //john.Gender = 'm';
            //List<Student> students = new List<Student>();
            //students.Add(alex);
            //students.Add(bo);
            //students.Add(john);

            //Course_Students obj = new Course_Students();
            //obj.course = math;
            //obj.students = students;

            //return View(obj);
        }
    }
}