using Core.Entities;
using Core.Interfaces;
using Infrastructue.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class ProductBrandRepo : IProductBrandRepo
{
    private readonly StoreContext _context;
    public ProductBrandRepo(StoreContext context)
    {
        _context = context;
    }

    public async Task<ProductBrand> GetProductBrandById(int id)
    {
        var brand = await _context.ProductBrands.FirstOrDefaultAsync(t => t.Id == id);

        if(brand is null)
            return null;

        return brand;
    }
        public async Task<IEnumerable<ProductBrand>> GetProductBrands()
    {
        var brands = await _context.ProductBrands.ToListAsync();
        
        if(brands is null)
            return null;

        return brands;
    }
}
