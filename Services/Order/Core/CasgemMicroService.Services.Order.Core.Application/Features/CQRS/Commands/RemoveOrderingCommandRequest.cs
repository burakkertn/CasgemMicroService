using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Commands
{

    //MURAT YÜCEDAĞ YAZDI
    public class RemoveOrderDetailCommandRequest : IRequest
    {
        public RemoveOrderDetailCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}