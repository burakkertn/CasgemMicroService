using CasgemMicroService.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdAddressQueryRequest : IRequest<ResultAddressDto>
    {
        public GetByIdAddressQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
