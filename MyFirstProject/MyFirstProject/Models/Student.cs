using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    [Serializable]
    public class Student
    {
        public int StudentID { get; set; }        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public DateTime? EnrDate { get; set; }
        public ICollection<Student_Course> Enrollments { get; set; }

        public void CreateStudentXML()
        {
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.ConformanceLevel = ConformanceLevel.Auto;
            using (XmlWriter writer = XmlWriter.Create("~/Models/Students.xml", setting))
            {
                writer.WriteStartElement("students");
                foreach(var s in GetAllStudents())
                {
                    writer.WriteStartElement("student");
                    writer.WriteElementString("StudentID", s.StudentID.ToString());
                    writer.WriteElementString("LastName", s.LastName.ToString());
                    writer.WriteElementString("FirstName", s.FirstName.ToString());
                    writer.WriteElementString("Gender", s.Gender.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        public List<Student> GetMaleStudents()
        {          
            IEnumerable<Student> males = this.GetAllStudents().Where(s => s.Gender == "m");
            return (List<Student>)males;
        }

        public List<Student> GetAllStudents()
        {
            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.LastName = "Rodrigez";
            alex.Gender = "m";
            alex.EnrDate = DateTime.Parse("2013-03-01");
            Student bo = new Student();
            bo.FirstName = "Bo";
            bo.LastName = "Kaka";
            bo.Gender = "f";
           bo.EnrDate = DateTime.Parse("2014-02-08");
            Student john = new Student();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Gender = "m";
           john.EnrDate = DateTime.Parse("2013-07-11");
            List<Student> students = new List<Student>();
            students.Add(alex);
            students.Add(bo);
            students.Add(john);

            return students;
        }
    }
}