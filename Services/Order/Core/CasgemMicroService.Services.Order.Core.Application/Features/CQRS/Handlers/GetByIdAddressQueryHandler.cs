using AutoMapper;
using CasgemMicroService.Services.Core.Domain.Entities;
using CasgemMicroService.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroService.Services.Order.Core.Application.Interfaces;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAddressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetByIdAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultAddressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAddressDto>(value);

        }
    }
}