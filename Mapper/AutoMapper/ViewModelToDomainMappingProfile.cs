using AutoMapper;
using Mapper.Entities.OuterSourceWrapper;
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

            //Projection
        }
    }
}
