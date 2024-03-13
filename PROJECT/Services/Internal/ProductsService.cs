using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models.DTOs.Internal.Products;

namespace Services.Internal
{
    public class ProductsService : IProductsService
    {
        BizlabbgIcanContext _ctx;
        public ProductsService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }
        public void Edit(ProductDTO dto)
        {
            
            try
            {
                IcaksSappProduct model = _ctx.IcaksSappProducts.Where(x=>x.Id==dto.Id).First();

                model.Weight = dto.Weight;

                _ctx.SaveChanges();
            } 
            catch (Exception)
            {
                throw new InvalidDataException("errors.invalid-id");
            }

        }

        public ProductDTO Get(int id)
        {
            return (from p in _ctx.IcaksSappProducts
                    join pl in _ctx.IcaksWcProductMetaLookups on p.ProductId equals pl.ProductId
                    where p.Id==id
                    select new ProductDTO
                    {
                        Weight = p.Weight,
                        Id = p.Id,
                        Name = pl.Sku
                    }).AsNoTracking().First();
        }

        public IQueryable<ProductDTO> GetAll()
        {
            return (from p in _ctx.IcaksSappProducts
                    join pl in _ctx.IcaksWcProductMetaLookups on p.ProductId equals pl.ProductId
                    select new ProductDTO
                    {
                        Weight = p.Weight,
                        Id = p.Id,
                        Name = pl.Sku
                    }).AsNoTracking();
        }
    }
}
