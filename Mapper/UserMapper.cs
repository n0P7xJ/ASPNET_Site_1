using AutoMapper;
using ASPNET_Site_1.Data.Entities.Idenity;
using ASPNET_Site_1.Models.Account;
namespace ASPNET_Site_1.Mapper;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<UserEntity, UserLinkViewModel>()
            .ForMember(x => x.Name, opt =>
                opt.MapFrom(x => $"{x.LastName} {x.FirstName}"))
            .ForMember(x => x.Image, opt =>
                opt.MapFrom(x => x.Image ?? "default.webp"));

        CreateMap<RegisterViewModel, UserEntity>()
            .ForMember(x => x.Image, opt => opt.Ignore())
            .ForMember(x => x.UserName, opt => opt.MapFrom(x=>x.Email));
    }
}
