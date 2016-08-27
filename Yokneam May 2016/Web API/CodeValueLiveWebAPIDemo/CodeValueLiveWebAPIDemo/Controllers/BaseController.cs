using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeValueLiveWebAPIDemo.Models;

namespace CodeValueLiveWebAPIDemo.Controllers
{
    public abstract class BaseController : ApiController
    {
        private CompaniesDbContext _context;

        public CompaniesDbContext CompaniesDbContext { get; set; }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                _context = null;
            }

            base.Dispose(disposing);
        }
    }
}
