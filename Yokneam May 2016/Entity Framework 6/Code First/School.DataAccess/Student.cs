using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.DataAccess
{
    public class Student
    {
        [Column("StudentID")]
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [NotMapped]
        public string Fullname => $"{FirstName} {LastName}";

        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public override string ToString() => $"{ID} - {FirstName} {LastName}";
    }
}
