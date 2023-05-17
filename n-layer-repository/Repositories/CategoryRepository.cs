using Microsoft.EntityFrameworkCore;
using n_layer_core.Models;
using n_layer_core.Repositories;

namespace n_layer_repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
