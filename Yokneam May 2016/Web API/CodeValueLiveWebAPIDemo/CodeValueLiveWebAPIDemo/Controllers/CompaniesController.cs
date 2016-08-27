using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeValueLiveWebAPIDemo.Models;

namespace CodeValueLiveWebAPIDemo.Controllers
{
    [RoutePrefix("api/companies")]
    public class CompaniesController : BaseController
    {

        // GET: api/Companies
        [Route("")]
        public IEnumerable<Company> Get()
        {
            
            return new[]
            {
                new Company()
                {
                    FoundationDate = new DateTime(2010, 01, 01),
                    CompanyName = "CodeValue",
                    CompanyId = 1
                }
            };
        }

        // GET: api/Companies/5
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            if (id != 1)
            {
                return NotFound();
            }

            var company = new Company()
            {
                FoundationDate = new DateTime(2010, 01, 01),
                CompanyName = "CodeValue",
                CompanyId = 1
            };

            return Ok(company);
        }

        [Route("{id:alpha}")]
        public IHttpActionResult Get(string id)
        {
            

            var company = new Company()
            {
                FoundationDate = new DateTime(2010, 01, 01),
                CompanyName = "CodeValue",
                CompanyId = 1
            };

            return Ok(company);
        }

        // POST: api/Companies
        [Route("")]
        public string Post([FromBody]string value)
        {
            return $"I got the value {value}";
        }

        // PUT: api/Companies/5
        [Route("")]
        public string Put([FromBody]string companyName)
        {
            return $"I got the put id and company name {companyName}";
        }

        // DELETE: api/Companies/5
        public void Delete(int id)
        {
        }

 
    }
}
