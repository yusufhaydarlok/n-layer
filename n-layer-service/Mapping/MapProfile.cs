using AutoMapper;
using n_layer_core.DTOs;
using n_layer_core.Models;

namespace n_layer_service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
