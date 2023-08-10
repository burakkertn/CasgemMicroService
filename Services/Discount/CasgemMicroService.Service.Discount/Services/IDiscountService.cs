using CasgemMicroservice.Shared.Dtos;
using CasgemMicroService.Service.Discount.Dtos;
using CasgemMicroService.Service.Discount.Models;

namespace CasgemMicroService.Service.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync();

        Task<Response<ResultDiscountDto>> GetByIdDiscountCouponAsync(int id);

        Task<Response<NoContent>> CreatelDiscountCouponAsync(CreateDiscountDto createDiscountDto);
        Task<Response<NoContent>> UpdatelDiscountCouponAsync(UpdateDiscountDto updateDiscountDto);

        Task<Response<NoContent>> DeleteDiscountCouponAsync(int id);
    }
}
