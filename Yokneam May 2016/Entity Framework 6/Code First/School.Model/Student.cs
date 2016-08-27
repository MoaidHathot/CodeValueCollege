using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string Fullname => $"{FirstName} {LastName}";

        public Student()
        {
        }

       public override string ToString() => $"{ID} - {FirstName} {LastName}";
    }
}
