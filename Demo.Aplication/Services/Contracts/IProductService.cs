using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Demo.Aplication.DTOs;
using Demo.Domain.Entities;

namespace Demo.Aplication.Services.Contracts
{
    public interface IProductService
    {
        ProductDto GetProduct(Func<Product, bool> predicate);
        List<ProductDto> GetProducts(Expression<Func<Product, bool>>? predicate = null);
        void AddProduct(ProductCreateDto product);
        void RemoveProduct(int id);
        void UpdateProduct(int id, Product product);
    }
}
