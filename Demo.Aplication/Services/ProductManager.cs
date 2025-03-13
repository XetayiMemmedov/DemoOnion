using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Demo.Aplication.DTOs;
using Demo.Aplication.Repositories;
using Demo.Domain.Entities;

namespace Demo.Aplication.Services
{
    public class ProductManager
    {
        private readonly IProductRepository _repository;

        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(ProductCreateDto createDto)
        {
            var product = new Product
            {
                Name = createDto.Name,
                Price = createDto.Price,
                CategoryId = createDto.CategoryId
            };

            _repository.Add(product);
            
        }

        public ProductDto GetProduct(Func<Product, bool> predicate)
        {
            var product = _repository.Get(predicate);

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };

            return productDto;
        }

        public List<ProductDto> GetProducts(Expression<Func<Product, bool>>? predicate = null)
        {
            var productDtos = new List<ProductDto>();

            foreach (var item in _repository.GetAll(predicate))
            {
                productDtos.Add(new ProductDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    CategoryId = item.CategoryId
                });
            }

            return productDtos;
        }

        public void RemoveProduct(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateProduct(int id, Product product)
        {
            _repository.Update(id, product);
        }
    }
}
