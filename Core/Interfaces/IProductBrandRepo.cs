using Core.Entities;

namespace Core.Interfaces;

public interface IProductBrandRepo
{
    Task<IEnumerable<ProductBrand>> GetProductBrands();
    Task<ProductBrand> GetProductBrandById(int id);
}
