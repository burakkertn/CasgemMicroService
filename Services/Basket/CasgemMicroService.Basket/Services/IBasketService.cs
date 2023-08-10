using CasgemMicroservice.Shared.Dtos;
using CasgemMicroService.Basket.Dtos;

namespace CasgemMicroService.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string UserID);

        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> DeleteBasket(string UserID);
    }
}
