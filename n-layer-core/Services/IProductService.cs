using n_layer_core.DTOs;
using n_layer_core.Models;

namespace n_layer_core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
