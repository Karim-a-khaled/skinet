using Core.Entities;

namespace Core.Interfaces;

public interface IBasketRepo
{
    Task<CustomerBasket> GetBasket(string basketId);
    Task<CustomerBasket> UpdateBasket(CustomerBasket basketet);
    Task<bool> DeleteBasket(string basketId);

}

