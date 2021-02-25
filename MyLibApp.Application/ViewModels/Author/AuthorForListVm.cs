using AutoMapper;
using MyLibApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Author
{
    public class AuthorForListVm : IMapFrom<MyLibApp.Domain.Models.Author>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.Author, AuthorForListVm>();
        }
    }
}
