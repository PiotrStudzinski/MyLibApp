using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        int AddCategory(Category category);

        void DeleteCategory(int categoryId);

        void UpdateCategory(Category category);

        Category GetCategoryById(int categoryId);

        IQueryable<Category> GetAllCategories();
    }
}
