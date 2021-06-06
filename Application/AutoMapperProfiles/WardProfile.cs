using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.AutoMapperProfiles
{
    class WardProfile : Profile
    {
        public WardProfile()
        {
            CreateMap<Ward, WardDto>();
        }
    }
}
