using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
    public class ResultOrderingDto
    {
        public int OrderingID { get; set; }

        public string UserID { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
