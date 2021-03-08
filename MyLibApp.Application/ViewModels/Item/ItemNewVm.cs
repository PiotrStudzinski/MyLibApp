using AutoMapper;
using FluentValidation;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Item
{
    public class ItemNewVm : IMapFrom<MyLibApp.Domain.Models.Item>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemNewVm, MyLibApp.Domain.Models.Item>().ReverseMap();
        }
    }

    public class ItemNewValidation : AbstractValidator<ItemNewVm>
    {
        public ItemNewValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Title).MaximumLength(30);
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.Description).MaximumLength(2000);
        }
    }
}
