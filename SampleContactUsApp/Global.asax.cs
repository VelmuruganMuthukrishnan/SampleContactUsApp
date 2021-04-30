using AutoMapper;
using SampleContactUsApp.Data.Model;
using SampleContactUsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleContactUsApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactUsFormViewModel, ContactUsModel>());
            var mapper = new Mapper(config);
        }
    }
}
