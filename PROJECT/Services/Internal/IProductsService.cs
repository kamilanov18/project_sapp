using Models.DTOs.Internal.Products;

namespace Services.Internal
{
    public interface IProductsService
    {
        ProductDTO Get(int id);
        IQueryable<ProductDTO> GetAll();
        void Edit(ProductDTO dto);
    }
}
