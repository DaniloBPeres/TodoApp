using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Api.AutoMapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TaskModel, TaskDto>().ReverseMap();
        }
    }
}
