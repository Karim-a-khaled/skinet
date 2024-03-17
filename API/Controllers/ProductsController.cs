using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Core.Inerfaces;
using AutoMapper;
using Core.DTOs;
using API.Errors;

namespace API.Controllers;

public class ProductsController : BaseController
{
    private readonly IProductRepo _productRepo;
    private readonly IMapper _mapper;
    public ProductsController(IProductRepo productRepo, IMapper mapper)
    {
        _mapper = mapper;
        _productRepo = productRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductToReturnDto>>> GetProducts()
    {
        var products = await _productRepo.GetProducts();

        if(products is null)
            return NotFound();

        return Ok(_mapper.Map<IEnumerable<Product>,IEnumerable<ProductToReturnDto>>(products));
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _productRepo.GetProductById(id);
                
        if(product is null)
            return NotFound();

        return Ok(_mapper.Map<Product,ProductToReturnDto>(product));
    }
}