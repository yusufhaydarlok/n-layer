using n_layer_core.DTOs;
using n_layer_core.Models;

namespace n_layer_core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
