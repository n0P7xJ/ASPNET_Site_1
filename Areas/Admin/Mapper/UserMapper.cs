using AutoMapper;
using ASPNET_Site_1.Areas.Admin.Models.Users;
using ASPNET_Site_1.Data.Entities.Idenity;

namespace ASPNET_Site_1.Areas.Admin.Mapper;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<UserEntity, UserItemViewModel>()
            .ForMember(x => x.Image, opt => opt.MapFrom(x => x.Image))
            .ReverseMap();

    }
}
