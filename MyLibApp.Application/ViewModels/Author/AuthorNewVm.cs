using AutoMapper;
using FluentValidation;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyLibApp.Application.ViewModels.Author
{
    public class AuthorNewVm : IMapFrom<MyLibApp.Domain.Models.Author>
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AuthorNewVm, MyLibApp.Domain.Models.Author>().ReverseMap();
        }
    }

    public class AuthorNewValidation : AbstractValidator<AuthorNewVm>
    {
        public AuthorNewValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.FirstName).MaximumLength(80);
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.LastName).MaximumLength(100);
        }
    }
}
