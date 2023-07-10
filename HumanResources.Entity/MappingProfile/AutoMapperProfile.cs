using AutoMapper;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Language;

namespace HumanResources.Core.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LanguageInsertDto, Language>();
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageUpdateDto, Language>();
        }
    }
}
