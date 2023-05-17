using AutoMapper;
using n_layer_core.DTOs;
using n_layer_core.Models;
using n_layer_core.Repositories;
using n_layer_core.Services;
using n_layer_core.UnitOfWorks;

namespace n_layer_service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithProductsAsync(categoryId);

            var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);

            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDto);
        }
    }
}
