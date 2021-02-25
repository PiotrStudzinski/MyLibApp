using MyLibApp.Application.ViewModels.Author;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.Interfaces
{
    public interface IAuthorService
    {
        AuthorListVm GetAllAuthorForList();
        int AddAuthor(AuthorNewVm author);
        AuthorDetailsVm GetAuthorDetails(int authorId);
    }
}
