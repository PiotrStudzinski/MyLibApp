using AutoMapper;
using MyLibApp.Application.Mapping;
using MyLibApp.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.ItemType
{
    public class ItemTypeDetailsVm : IMapFrom<MyLibApp.Domain.Models.ItemType>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemForListVm> Items { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.ItemType, ItemTypeDetailsVm>()
                .ForMember(s => s.Items, opt => opt.Ignore());
        }
    }
}
