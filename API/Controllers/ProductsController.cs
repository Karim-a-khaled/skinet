using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Core.Inerfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepo _productRepo;
    public ProductsController(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        var products = await _productRepo.GetProducts();

        if(products is null)
            return NotFound();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _productRepo.GetProductById(id);
                
        if(product is null)
            return NotFound();

        return Ok(product);
    }
}