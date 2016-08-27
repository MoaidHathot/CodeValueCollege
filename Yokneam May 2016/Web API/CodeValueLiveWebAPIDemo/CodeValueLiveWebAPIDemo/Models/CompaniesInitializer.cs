using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using CodeValueLiveWebAPIDemo.Migrations;

namespace CodeValueLiveWebAPIDemo.Models
{
    public class CompaniesInitializer : MigrateDatabaseToLatestVersion<CompaniesDbContext, Configuration>
    {
        public override void InitializeDatabase(CompaniesDbContext context)
        {
            context.Companies.AddOrUpdate(c => c.CompanyName, new Company()
            {
                CompanyName = "CodeValue",
                FoundationDate = new DateTime(2010, 01, 01)
            });

            base.InitializeDatabase(context);
        }
    }
    
}