using AutoMapper;
using ASPNET_Site_1.Data.Entities;
using ASPNET_Site_1.Models.Seeder;

namespace ASPNET_Site_1.Mapper;

public class SeederMapper : Profile
{
    public SeederMapper() 
    {
        CreateMap<SeederCategoryModel, CategoryEntity>()
            .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.Image));
    }
}
