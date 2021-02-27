using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.Services;
using MyLibApp.Application.ViewModels.Author;
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
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IValidator<AuthorNewVm>, AuthorNewValidation>();

            return services;
        }
    }
}
