using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using School.Migrations;

namespace School.DataAccess
{
    public class SchoolInitializer : MigrateDatabaseToLatestVersion<SchoolContext, Configuration>
    {
        public override void InitializeDatabase(SchoolContext context)
        {
            context.Students.AddOrUpdate(c => new {c.FirstName, c.LastName},
                new Student()
                {
                    EnrollmentDate = DateTime.Today,
                    FirstName = "Moaid",
                    LastName = "Hathot",
                });

            Console.WriteLine("Initializer is running");

            base.InitializeDatabase(context);
        }
    }
}
