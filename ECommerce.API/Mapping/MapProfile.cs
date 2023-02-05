using AutoMapper;
using ECommerce.API.DTOs;
using ECommerce.EntityLayer.Concrete;

namespace ECommerce.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product,ProductListDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
        }
    }
}
