using AutoMapper;
using FluentValidation;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Category
{
    public class CategoryNewVm : IMapFrom<MyLibApp.Domain.Models.Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CategoryNewVm, MyLibApp.Domain.Models.Category>().ReverseMap();
        }
    }

    public class CategoryNewValidation : AbstractValidator<CategoryNewVm>
    {
        public CategoryNewValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(15);
        }
    }
}
