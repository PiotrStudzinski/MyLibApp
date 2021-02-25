using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        int AddAuthor(Author author);

        void DeleteAuthor(int authorId);

        void UpdateAuthor(Author author);

        Author GetAuthorById(int authorId);

        IQueryable<Author> GetAllAuthors();
    }
}
