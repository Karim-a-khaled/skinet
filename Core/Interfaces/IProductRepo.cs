using Core.Entities;

namespace Core.Inerfaces;

public interface IProductRepo
{
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetProductById(int id);
}
