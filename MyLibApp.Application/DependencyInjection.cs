using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.Services;
using MyLibApp.Application.ViewModels.Author;
using MyLibApp.Application.ViewModels.Category;
using MyLibApp.Application.ViewModels.Item;
using MyLibApp.Application.ViewModels.ItemType;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IItemTypeService, ItemTypeService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IValidator<AuthorNewVm>, AuthorNewValidation>();
            services.AddTransient<IValidator<CategoryNewVm>, CategoryNewValidation>();
            services.AddTransient<IValidator<ItemNewVm>, ItemNewValidation>();
            services.AddTransient<IValidator<ItemTypeNewVm>, ItemTypeNewValidation>();

            return services;
        }
    }
}
