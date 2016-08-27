using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using CodeValueLiveWebAPIDemo.Models;

namespace CodeValueLiveWebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Database.SetInitializer(new CompaniesInitializer());

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "Companies",
            //    routeTemplate: "api/companies/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "companies" }
            //);

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
