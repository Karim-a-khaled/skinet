using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BasketController : BaseController
{
    private readonly IBasketRepo _basketRepo;

    public BasketController(IBasketRepo basketRepo)
    {
        _basketRepo = basketRepo;
    }

    [HttpGet]
    public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
    {
        var basket = await _basketRepo.GetBasket(id);

        return Ok(basket ?? new CustomerBasket(id));
    }

    [HttpPost]
    public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
    {
        var updatedBasket = await _basketRepo.UpdateBasket(basket);

        return Ok(updatedBasket);
    }

    [HttpDelete]
    public async Task DeleteBasket(string id)
    {
        await _basketRepo.DeleteBasket(id); 
    }
}
