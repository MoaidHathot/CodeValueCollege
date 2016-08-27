using System;
using System.Linq;

namespace School.Model
{
    public interface ISchoolRepository : IDisposable
    {
        Enrollment AddEnrollment(int courseId, int studentId, double grade);
        Course AddCourse(string title, int credits);
        Student AddStudent(string firstName, string lastName, DateTime enrollmentDate);

        IQueryable<Student> Students { get; }
        IQueryable<Course> Courses { get; }
        IQueryable<Enrollment> Enrollments { get; } 

    }
}
