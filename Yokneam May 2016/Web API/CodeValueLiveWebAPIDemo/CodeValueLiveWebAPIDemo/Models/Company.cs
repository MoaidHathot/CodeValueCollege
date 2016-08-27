using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeValueLiveWebAPIDemo.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime FoundationDate { get; set; }
    }
}