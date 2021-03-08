using AutoMapper;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.ItemType
{
    public class ItemTypeForListVm : IMapFrom<MyLibApp.Domain.Models.ItemType>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.ItemType, ItemTypeForListVm>();
        }
    }
}
