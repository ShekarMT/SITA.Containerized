using AutoMapper;
using SITA_MultiProject16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SITA_MultiProject16.Api.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Repository.Airline, Airline>().ReverseMap();
config.CreateMap<Repository.Airport, Airport>().ReverseMap();
config.CreateMap<Repository.AllowedAirportToAirlineMapp, AllowedAirportToAirlineMapp>().ReverseMap();
config.CreateMap<Repository.AssignedAirportToAirlineMapp, AssignedAirportToAirlineMapp>().ReverseMap();
config.CreateMap<Repository.Region, Region>().ReverseMap();
                                
            });
        }
    }
}