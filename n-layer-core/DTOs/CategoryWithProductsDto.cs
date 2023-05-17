namespace n_layer_core.DTOs
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
