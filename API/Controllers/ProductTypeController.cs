using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeRepo _productTypeRepo;
    public ProductTypeController(IProductTypeRepo productTypeRepo)
    {
        _productTypeRepo = productTypeRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductType>>> GetProductTypes()
    {
        var productTypes = await _productTypeRepo.GetProductTypes();

        if(productTypes is null)
            return NotFound();

        return Ok(productTypes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductType>> GetProductType(int id)
    {
        var productType = await _productTypeRepo.GetProductTypeById(id);
                
        if(productType is null)
            return NotFound();

        return Ok(productType);
    }
}