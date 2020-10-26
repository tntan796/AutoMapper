using AutoMapper;

namespace Mapper.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, AppUser>().ForMember(x => x.FullName, option => option.MapFrom(source => source.Name));
        }
    }
}
