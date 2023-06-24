using AutoMapper;

using RestoFlow.Core.Models;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<UserDTO, ApplicationUser>();
            // Add more mappings as needed
        }
    }
}
