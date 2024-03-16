using Core.Entities;

namespace Core.Interfaces;
public interface IProductTypeRepo
{
    Task<IEnumerable<ProductType>> GetProductTypes();
    Task<ProductType> GetProductTypeById(int id);
}
