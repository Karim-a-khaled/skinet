using Core.Entities;
using Core.Inerfaces;
using Infrastructue.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class ProductRepo : IProductRepo
{
    private readonly StoreContext _context;

    public ProductRepo(StoreContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Product>> GetProducts()
    {
        var products = await _context.Products
                                    .Include(p => p.ProductType)
                                    .Include(p => p.ProductBrand).ToListAsync();

        if(products is null)
            return null;

        return products;
    }
    public async Task<Product> GetProductById(int id)
    {
        var product = await _context.Products
                                    .Include(p => p.ProductType)
                                    .Include(p => p.ProductBrand).FirstOrDefaultAsync(product => product.Id == id);
                
        if(product is null)
            return null;

        return product;
    }
}

    