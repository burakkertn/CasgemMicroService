
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Infra.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemOrderDb;User=sa;Password=123456Aa*");
        }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Ordering> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
     

    }
}
