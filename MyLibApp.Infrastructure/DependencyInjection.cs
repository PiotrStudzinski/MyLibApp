﻿using Microsoft.Extensions.DependencyInjection;
using MyLibApp.Domain.Interfaces;
using MyLibApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IAuthorRepository, AuthorRepository>();

            return services;
        }
    }
}
