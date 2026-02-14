using AutoMapper;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;

namespace Mango.Services.CouponAPI
{
    public class MappingConfig //Automapper should be register in Program.cs
    {
        public static MapperConfiguration RegisterMaps()
        {
            //Automappers works automatically if the properties have the same name
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CuoponDto, Cuopon>();
                config.CreateMap<Cuopon, CuoponDto>();
            });
            return mappingConfig;
        }
    }
}
