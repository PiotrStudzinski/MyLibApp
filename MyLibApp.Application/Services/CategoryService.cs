using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.Category;
using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public int AddCategory(CategoryNewVm category)
        {
            var newCategory = _mapper.Map<Category>(category);
            var id = _categoryRepository.AddCategory(newCategory);

            return id;
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
        }

        public CategoryListVm GetAllCategoryForList()
        {
            var categories = _categoryRepository.GetAllCategories()
                .ProjectTo<CategoryForListVm>(_mapper.ConfigurationProvider).ToList();
            var categoryList = new CategoryListVm()
            {
                Categories = categories
            };

            return categoryList;
        }

        public CategoryDetailsVm GetCategoryDetails(int categoryId)
        {
            var category = _categoryRepository.GetCategoryById(categoryId);
            var categoryVm = _mapper.Map<CategoryDetailsVm>(category);

            return categoryVm;
        }

        public CategoryNewVm GetCategoryForEdit(int categoryId)
        {
            var category = _categoryRepository.GetCategoryById(categoryId);
            var categoryVm = _mapper.Map<CategoryNewVm>(category);

            return categoryVm;
        }

        public void UpdateCategory(CategoryNewVm model)
        {
            var category = _mapper.Map<Category>(model);

            _categoryRepository.UpdateCategory(category);
        }
    }
}
