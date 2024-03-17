using Core.Entities;
using Core.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace Infrastructure.Data.Repositories;

public class BasketRepo : IBasketRepo
{
    private readonly IDatabase _db;

    public BasketRepo(IConnectionMultiplexer redis)
    {
        _db = redis.GetDatabase();
    }

    public async Task<bool> DeleteBasket(string basketId)
    {
        return await _db.KeyDeleteAsync(basketId);
    }

    public async Task<CustomerBasket> GetBasket(string basketId)
    {
        var data = await _db.StringGetAsync(basketId);

        return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBasket>(data);
    }

    public async Task<CustomerBasket> UpdateBasket(CustomerBasket basket)
    {
        var created = await _db.StringSetAsync(basket.Id,JsonSerializer.Serialize(basket), TimeSpan.FromDays(30));

        if (!created) return null;

        return await GetBasket(basket.Id);
    }
}

