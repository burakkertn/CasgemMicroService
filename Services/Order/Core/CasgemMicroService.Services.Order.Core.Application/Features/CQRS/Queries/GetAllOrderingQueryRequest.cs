﻿
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllOrderingQueryRequest : IRequest<List<ResultOrderingDto>>
    {
        
    }
}
