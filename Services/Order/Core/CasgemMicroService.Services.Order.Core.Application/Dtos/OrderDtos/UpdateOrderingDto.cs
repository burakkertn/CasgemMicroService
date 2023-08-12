using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
    public class UpdateOrderingDto
    {
        public int OrderingID { get; set; }

        public int UserID { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
