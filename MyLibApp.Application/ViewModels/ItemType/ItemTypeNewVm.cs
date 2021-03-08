using AutoMapper;
using FluentValidation;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.ItemType
{
    public class ItemTypeNewVm : IMapFrom<MyLibApp.Domain.Models.ItemType>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemTypeNewVm, MyLibApp.Domain.Models.ItemType>().ReverseMap();
        }
    }

    public class ItemTypeNewValidation : AbstractValidator<ItemTypeNewVm>
    {
        public ItemTypeNewValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(15);
        }
    }
}
