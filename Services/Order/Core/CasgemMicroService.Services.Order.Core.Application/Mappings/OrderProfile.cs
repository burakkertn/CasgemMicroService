using AutoMapper;
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDto;
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {

            CreateMap<ResultOrderingDto, Ordering>().ReverseMap();

            CreateMap<CreateOrderingDto, Ordering>().ReverseMap();

            CreateMap<UpdateOrderingDto, Ordering>().ReverseMap();

        

        }
    }
}
