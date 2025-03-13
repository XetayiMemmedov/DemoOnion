using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Demo.Aplication.DTOs;
using Demo.Domain.Entities;

namespace Demo.Aplication.Services.Contracts
{
    public interface ICategoryService
    {
        CategoryDto GetCategory(Func<Category, bool> predicate);
        List<CategoryDto> GetCategories(Expression<Func<Category, bool>>? predicate = null);
        void AddCategory(CategoryCreateDto category);
        void RemoveCategory(int id);
        void UpdateCategory(int id, Category category);
    }
}
