using MyLibApp.Application.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryListVm GetAllCategoryForList();
        int AddCategory(CategoryNewVm category);
        CategoryDetailsVm GetCategoryDetails(int categoryId);
        CategoryNewVm GetCategoryForEdit(int categoryId);
        void UpdateCategory(CategoryNewVm model);
        void DeleteCategory(int categoryId);
    }
}
