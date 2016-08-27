using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeValueLiveWebAPIDemo.Models
{
    public class CompaniesDbContext : DbContext
    {
        public CompaniesDbContext()
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}