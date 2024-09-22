using AutoMapper;
using LiteThinkingProject.Application.UseCase.Activity.Queries.ActivityGetAllQuery;
using LiteThinkingProject.Application.UseCase.Activity.Queries.ActivityGetByIdQuery;
using LiteThinkingProject.Domain.Entities;

namespace LiteThinkingProject.Application.Commons.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityGetAllQueryValueDto>()
           .ForMember(dest => dest.StateText, opt => opt.MapFrom(src => src.State ? "Completado" : "No completado"));
            CreateMap<Activity, ActivityGetByIdQueryDto>().
            ForMember(dest => dest.StateText, opt => opt.MapFrom(src => src.State ? "Completado" : "No completado"));
            CreateMap<ActivityGetByIdQueryModel, ActivityGetByIdQuery>();
        }
    }
}