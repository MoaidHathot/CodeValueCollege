using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.DataAccess;
using School.Migrations;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>());

            //AddStudent("Alan", "Turing", DateTime.Today);
            //AddStudent("Moaid", "Hathot", new DateTime(1988, 09, 30));
            //AddCourse("EF 6", 6);

            var repository = new SchoolRepository();

            foreach (var student in repository.Students)
            {
                Console.WriteLine(student);
            }

            foreach (var course in repository.Courses)
            {
                Console.WriteLine(course);
            }

            foreach (var enrollment in repository.Enrollments)
            {
                Console.WriteLine(enrollment);
            }

            //repository.AddCourse()

            //DisplayStudents();
            //DisplayCourses();
            //AddEnrollment(FindStudent(6), FindCourse(1), 99);
            //DisplayCourses();
            //DisplayStudents();


            //var student = FindStudent(5);
            //Console.WriteLine($"Found student: '{student}'");


            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }

        //static void DisplayStudents()
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        foreach (var student in context.Students)
        //        {
        //            Console.WriteLine(student);
        //        }
        //    }
        //}

        //static void DisplayCourses()
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        foreach (var course in context.Courses)
        //        {
        //            Console.WriteLine(course);
        //        }
        //    }
        //}

        //static void AddCourse(string title, int credits)
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        var course = context.Courses.Add(new Course()
        //        {
        //            Credits = credits,
        //            Title = title
        //        });

        //        context.SaveChanges();
        //    }
        //}

        //static void AddEnrollment(Student student, Course course, double grade)
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        context.Enrollments.Add(new Enrollment()
        //        {
        //            StudentId = student.ID,
        //            CourseId = course.CourseID,
        //            Grade = grade,
        //        });

        //        context.SaveChanges();
        //    }
        //}


        //static void AddStudent(string firstName, string lastName, DateTime enrollmentDate)
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        var student = new Student()
        //        {
        //            LastName = lastName,
        //            EnrollmentDate = enrollmentDate,
        //            FirstName = firstName
        //        };

        //        context.Students.AddOrUpdate(c => new { c.FirstName, c.LastName}, student);

        //        context.SaveChanges();
        //    }
        //}

        //static Student FindStudent(int id)
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        return context.Students.Find(id);
        //    }
        //}

        //static Course FindCourse(int id)
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        return context.Courses.SingleOrDefault(c => c.CourseID == id);
        //    }
        //}

        //internal static class MissingDllHack
        //{
        //    private static SqlProviderServices instance = SqlProviderServices.Instance;
        //}
    }
}
