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
    public class CategoryRepository : EfCoreRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
