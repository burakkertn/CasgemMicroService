﻿using AutoMapper;
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
    public class GetByIdOrderingQueryHandler : IRequestHandler<GetByIdOrderingQueryRequest, ResultOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        public async Task<ResultOrderingDto> Handle(GetByIdOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderingDto>(value);
        }
    }
}
