using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly StoreContext _context;
    public ProductsController(StoreContext context)
    {
        _context = context;
    }

    [HttpGet]
    public string GetProducts()
    {
        return "This is a list of Products";
    }

    [HttpGet("{id}")]
    public string GetProduct(int id)
    {
        return "This is a Product";
    }
}