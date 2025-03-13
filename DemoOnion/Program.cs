using Demo.Aplication.DTOs;
using Demo.Aplication.Services;
using Demo.Infrastructure.EfCore;
using Demo.Infrastructure.Repositories;

namespace DemoOnion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appDbContext = new AppDbContext();
            CategoryRepository categoryRepository = new CategoryRepository(appDbContext);
            CategoryManager categoryManager = new CategoryManager(categoryRepository);


            ProductRepository productRepository = new ProductRepository(appDbContext);
            ProductManager productManager = new ProductManager(productRepository);
            
            categoryManager.AddCategory(new CategoryCreateDto() { Name = "Elektronika" });
            productManager.AddProduct(new ProductCreateDto() { Name = "Tozsoran Filips", Price = 240, CategoryId = 1 });
            appDbContext.SaveChanges();
            var product = productManager.GetProduct(x=>x.Id==2);
            Console.WriteLine($"{product.Id}.{product.Name} {product.Price} ");
        }
    }
}
