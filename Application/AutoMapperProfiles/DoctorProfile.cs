using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.AutoMapperProfiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<CreateDoctorDto, Doctor>();
        }
    }
}
