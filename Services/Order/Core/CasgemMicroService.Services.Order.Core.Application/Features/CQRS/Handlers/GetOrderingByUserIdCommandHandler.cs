using AutoMapper;
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


namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{

    public class GetOrderingByUserIdCommandHandler : IRequestHandler<GetOrderingByUserIdQuery, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderingByUserIdCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderingDto>> Handle(GetOrderingByUserIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetOrderById(x => x.UserID == request.Id);
            return _mapper.Map<List<ResultOrderingDto>>(value);
        }
    }
}