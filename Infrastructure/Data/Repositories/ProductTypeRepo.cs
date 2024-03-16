using Core.Entities;
using Core.Interfaces;
using Infrastructue.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class ProductTypeRepo : IProductTypeRepo
{
    private readonly StoreContext _context;
    public ProductTypeRepo(StoreContext context)
    {
        _context = context;
        
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        var type = await _context.ProductTypes.FirstOrDefaultAsync(t => t.Id == id);

        if(type is null)
            return null;

        return type;
    }

    public async Task<IEnumerable<ProductType>> GetProductTypes()
    {
        var types = await _context.ProductTypes.ToListAsync();
        
        if(types is null)
            return null;

        return types;
    }
}
