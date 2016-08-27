using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Enrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public override string ToString() => $"StudentId: {StudentId}, CourseId: {CourseId}, Grade: '{Grade}'";
    }
}
