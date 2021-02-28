using AutoMapper;
using MyLibApp.Application.Mapping;
using MyLibApp.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Category
{
    public class CategoryDetailsVm : IMapFrom<MyLibApp.Domain.Models.Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemForListVm> Items { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.Category, CategoryDetailsVm>()
                .ForMember(s => s.Items, opt => opt.Ignore());
        }
    }
}
