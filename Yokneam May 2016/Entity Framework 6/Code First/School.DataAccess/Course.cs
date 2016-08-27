using System.Collections.Generic;

namespace School.DataAccess
{
    public class Course
    {
        
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public Course()
        {
            Enrollments = new List<Enrollment>();
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public override string ToString() => $"{Title} ({Credits})";
    }
}
