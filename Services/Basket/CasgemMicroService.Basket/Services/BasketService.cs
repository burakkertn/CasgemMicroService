using CasgemMicroservice.Shared.Dtos;
using CasgemMicroService.Basket.Dtos;
using System.Text.Json;

namespace CasgemMicroService.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> DeleteBasket(string UserID)
        {
            var status = await _redisService.GetDb().KeyDeleteAsync(UserID);
            return status ? Response<bool>.Success(204) :

            Response<bool>.Fail("Sepet Bulunmadı", 404);
        }

        public async Task<Response<BasketDto>> GetBasket(string UserID)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(UserID);
            if (String.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDto>.Fail("Sepet Bulunamadı", 404);
            }
            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket), 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketDto)
        {
            var status = await _redisService.GetDb().StringSetAsync(basketDto.UserID, JsonSerializer.Serialize(basketDto));

            return status ? Response<bool>.Success(204) :
                Response<bool>.Fail("Sepet Güncelleme veya Ekleme Yapılamadı", 500);
        }
    }
}
