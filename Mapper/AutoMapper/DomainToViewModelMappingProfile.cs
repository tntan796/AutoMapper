using AutoMapper;
using Mapper.Entities;
using Mapper.Entities.OuterSourceWrapper;
using Mapper.Models;
using Mapper.Models.OuterDestWrapper;

namespace Mapper.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AppUser, UserViewModel>();
            // Mapping nested object
            CreateMap<OuterSource, OuterDest>();
            CreateMap<InnerSource, InnerDest>();

            // Projection
            CreateMap<ProjectionCalenderEvent, ProjectionCalenderEventForm>()
            .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
            .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
            .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute));


            // List and arrays
            CreateMap<ListArraySource, ListArrayDestination>();
        }
    }
}
