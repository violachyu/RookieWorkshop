using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RookieWorkshop.DataAccess;
using RookieWorkshop.Entities;

namespace RookieWorkshop.Crosslayer.Mappers
{
    public class DataEntityMapperProfile : Profile
    {
        public DataEntityMapperProfile()
        {
            CreateMap<Data, DataEntity>()
                .ForMember(i => i.Id, s => s.MapFrom(src => src.Data_Id))
                .ForMember(i => i.Input, s => s.MapFrom(src => src.Data_Input))
                .ForMember(i => i.Result, s => s.MapFrom(src => src.Data_Result.ToUpper()));
        }

    }
}
