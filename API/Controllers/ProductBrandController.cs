using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductBrandController : ControllerBase
{
    private readonly IProductBrandRepo _productBrandRepo;

    public ProductBrandController(IProductBrandRepo productBrandRepo)
    {
        _productBrandRepo = productBrandRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductBrand>>> GetProductBrands()
    {
        var productBrand = await _productBrandRepo.GetProductBrands();

        if(productBrand is null)
            return NotFound();

        return Ok(productBrand);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductBrand>> GetProductBrand(int id)
    {
        var productBrands = await _productBrandRepo.GetProductBrandById(id);
                
        if(productBrands is null)
            return NotFound();

        return Ok(productBrands);
    }
}
