using AutoMapper;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Category
{
    public class CategoryForListVm : IMapFrom<MyLibApp.Domain.Models.Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.Category, CategoryForListVm>();
        }
    }
}
