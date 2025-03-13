using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Aplication.Repositories;
using Demo.Domain.Entities;
using Demo.Infrastructure.EfCore;

namespace Demo.Infrastructure.Repositories
{
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
