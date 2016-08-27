using System.Data.Entity;

namespace School.DataAccess
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>  Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public SchoolContext()
        {
            
        }
    }
}
