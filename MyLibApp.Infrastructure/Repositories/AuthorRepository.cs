using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly Context _context;
        public AuthorRepository(Context context)
        {
            _context = context;
        }

        public int AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return author.Id;
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Authors.Find(authorId);
            
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return _context.Authors;
        }

        public Author GetAuthorById(int authorId)
        {
            var author = _context.Authors.FirstOrDefault(a => a.Id == authorId);

            return author;
        }

        public void UpdateAuthor(Author author)
        {
            /*_context.Attach(author);
            _context.Entry(author).Property("FirstName").IsModified = true;
            _context.Entry(author).Property("LastName").IsModified = true;*/
            _context.Authors.Update(author);
            _context.SaveChanges();
        }
    }
}
