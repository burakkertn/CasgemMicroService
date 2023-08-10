using AutoMapper;
using CasgemMicroservice.Shared.Dtos;
using CasgemMicroService.Service.Discount.Context;
using CasgemMicroService.Service.Discount.Dtos;
using CasgemMicroService.Service.Discount.Models;
using Microsoft.EntityFrameworkCore;

namespace CasgemMicroService.Service.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;

        public DiscountService(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> CreatelDiscountCouponAsync(CreateDiscountDto createDiscountDto)
        {
            var createCoupon = _mapper.Map<DiscountCoupons>(createDiscountDto);
            createCoupon.CreatedTime = DateTime.Now;



            await _dapperContext.DiscountCouponses.AddAsync(createCoupon);
            await _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(201);
        }

        public async Task<Response<NoContent>> DeleteDiscountCouponAsync(int id)
        {
            var result = await _dapperContext.DiscountCouponses.FindAsync(id);

            if (result == null)
            {
                return Response<NoContent>.Fail("Silincek Kupon Bulunamadı", 404);
            }
            _dapperContext.DiscountCouponses.Remove(result);

            await _dapperContext.SaveChangesAsync();
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync()
        {
            var values = await _dapperContext.DiscountCouponses.ToListAsync();
            return Response<List<ResultDiscountDto>>.Success(_mapper.Map<List<ResultDiscountDto>>(values), 200);
        }


        public async Task<Response<ResultDiscountDto>> GetByIdDiscountCouponAsync(int id)
        {
            var values = await _dapperContext.DiscountCouponses.FindAsync();

            return Response<ResultDiscountDto>.Success(_mapper.Map<ResultDiscountDto>(values), 200);
        }

        public async Task<Response<NoContent>> UpdatelDiscountCouponAsync(UpdateDiscountDto updateDiscountDto)
        {
            var existingResponse = await _dapperContext.DiscountCouponses.FindAsync(updateDiscountDto.DiscountCouponsID);

            if (existingResponse == null)
            {
                return Response<NoContent>.Fail("Güncellenecek Kupon Bulunamadı", 404);
            }
            _mapper.Map(updateDiscountDto, existingResponse);
            _dapperContext.DiscountCouponses.Update(existingResponse);

            await _dapperContext.SaveChangesAsync();

            return Response<NoContent>.Success(204);

        }
    }
}