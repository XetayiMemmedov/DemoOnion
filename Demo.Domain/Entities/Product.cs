using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class Category : Entity
    {
        public string ?Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
    public class Product : Entity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

    public class Entity
    {
        public int Id { get; set; }
    }
}
