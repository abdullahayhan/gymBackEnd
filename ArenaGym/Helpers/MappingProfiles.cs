using ArenaGym.DTOS;
using AutoMapper;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGym.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BlogDTO, Blog>();
            CreateMap<PriceDTO, Price>();
        }
    }
}
