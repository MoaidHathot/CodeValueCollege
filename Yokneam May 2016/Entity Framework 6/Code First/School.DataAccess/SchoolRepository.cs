using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Model;

namespace School.DataAccess
{
    public class SchoolRepository : ISchoolRepository
    {
        private SchoolContext _context = new SchoolContext();

        public Model.Course AddCourse(string title, int credits)
        {
            var course = _context.Courses.Add(new Course()
            {
                Credits = credits,
                Title = title
            });

            return new Model.Course()
            {
                Credits = course.Credits,
                Title = course.Title,
                ID = course.CourseID
            };
        }

        public Model.Student AddStudent(string firstName, string lastName, DateTime enrollmentDate)
        {

            var student = _context.Students.Add(new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                EnrollmentDate = enrollmentDate,
            });

            _context.SaveChanges();

            return new Model.Student()
            {
                LastName = student.LastName,
                FirstName = student.FirstName,
                EnrollmentDate = student.EnrollmentDate,
                ID = student.ID
            };
        }

        public IQueryable<Model.Student> Students => _context.Students.Select(
            s => new Model.Student() {FirstName = s.FirstName, LastName = s.LastName, ID = s.ID});

        public IQueryable<Model.Course> Courses => _context.Courses.Select(
            c => new Model.Course() {ID = c.CourseID, Credits = c.Credits, Title = c.Title});

        public IQueryable<Model.Enrollment> Enrollments => _context.Enrollments.Select(
                    e => new Model.Enrollment() {CourseId = e.CourseId, StudentId = e.StudentId, Grade = e.Grade});

        public Model.Enrollment AddEnrollment(int courseId, int studentId, double grade)
        {
            var enrollment = _context.Enrollments.Add(new Enrollment()
            {
                CourseId = courseId,
                StudentId = studentId,
                Grade = grade
            });

            return new Model.Enrollment()
            {
                StudentId = enrollment.StudentId,
                CourseId = enrollment.CourseId,
                Grade = enrollment.Grade
            };
        }


        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                _context = null;
            }
        }
    }
}
