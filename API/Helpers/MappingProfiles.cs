using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product,ProductToReturnDto>()
        .ForMember(d => d.ProductBrand,o => o.MapFrom(p => p.ProductBrand.Name))
        .ForMember(d => d.ProductType,o => o.MapFrom(p => p.ProductType.Name));

        CreateMap<Address, AddressDto>().ReverseMap();
    }
}
