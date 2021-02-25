using AutoMapper;
using MyLibApp.Application.Mapping;
using MyLibApp.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.ViewModels.Author
{
    public class AuthorDetailsVm : IMapFrom<MyLibApp.Domain.Models.Author>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ItemForListVm> Items { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyLibApp.Domain.Models.Author, AuthorDetailsVm>()
                .ForMember(s => s.Items, opt => opt.Ignore());
        }
    }
}
