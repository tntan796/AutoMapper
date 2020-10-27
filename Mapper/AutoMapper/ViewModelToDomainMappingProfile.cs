using AutoMapper;
using Mapper.Entities;
using Mapper.Entities.OuterSourceWrapper;
using Mapper.Models;
using Mapper.Models.OuterDestWrapper;

namespace Mapper.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, AppUser>().ForMember(x => x.FullName, option => option.MapFrom(source => source.Name));

            // Mapping nested object
            CreateMap<OuterDest, OuterSource>();
            CreateMap<InnerDest, InnerSource>();

            // Projection

            // List and arrays
            CreateMap<ListArrayDestination, ListArraySource> ();
        }
    }
}
