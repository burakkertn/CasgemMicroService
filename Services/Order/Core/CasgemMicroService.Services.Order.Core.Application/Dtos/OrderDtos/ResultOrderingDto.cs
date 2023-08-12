using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
    public class ResultOrderingDto
    {
        public int OrderID { get; set; }

        public int UserID { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
