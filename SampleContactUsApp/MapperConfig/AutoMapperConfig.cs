using AutoMapper;
using SampleContactUsApp.Data.Model;
using SampleContactUsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleContactUsApp.MapperConfig
{
    public class AutoMapperConfig
    {/// <summary>
    /// AutoMapper config.
    /// </summary>
    /// <returns></returns>
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContactUsFormViewModel, ContactUsModel>();
            }
           );

            return config;
        }
    }
}