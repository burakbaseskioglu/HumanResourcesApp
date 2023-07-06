using AutoMapper;
using HumanResources.Entities;
using HumanResources.Entities.Concrete;

namespace HumanResources.Core.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LanguageInsertDto, Language>();
            CreateMap<Language, LanguageDto>();
        }
    }
}
