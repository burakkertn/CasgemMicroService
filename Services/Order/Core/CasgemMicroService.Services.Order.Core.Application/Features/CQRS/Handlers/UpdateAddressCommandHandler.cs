//using AutoMapper;
using AutoMapper;
using CasgemMicroService.Services.Core.Domain.Entities;
using CasgemMicroService.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Commands;
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
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public UpdateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AddressID);

            values.City = request.City;
            values.District = request.District;
            values.UserID = request.UserID;
            values.Detail = request.Detail;  
            
            await _repository.UpdateAsync(values);
        }
    }

}

