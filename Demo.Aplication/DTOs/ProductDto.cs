using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Entities;

namespace Demo.Aplication.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category ?Category { get; set; }
    }
}
