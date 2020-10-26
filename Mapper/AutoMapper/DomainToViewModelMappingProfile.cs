using AutoMapper;

namespace Mapper.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AppUser, UserViewModel>();
        }
    }
}
