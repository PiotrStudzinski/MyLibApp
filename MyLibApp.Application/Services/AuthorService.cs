using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.Author;
using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        
        public int AddAuthor(AuthorNewVm author)
        {
            var newAuthor = _mapper.Map<Author>(author);
            var id = _authorRepository.AddAuthor(newAuthor);

            return id;
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.DeleteAuthor(id);
        }

        public AuthorListVm GetAllAuthorForList()
        {
            var authors = _authorRepository.GetAllAuthors()
                .ProjectTo<AuthorForListVm>(_mapper.ConfigurationProvider).ToList();
            var authorList = new AuthorListVm()
            {
                Authors = authors
            };

            return authorList;
        }

        public AuthorDetailsVm GetAuthorDetails(int authorId)
        {
            var author = _authorRepository.GetAuthorById(authorId);
            var authorVm = _mapper.Map<AuthorDetailsVm>(author);

            return authorVm;
        }

        public AuthorNewVm GetAuthorForEdit(int authorId)
        {
            var author = _authorRepository.GetAuthorById(authorId);
            var authorVm = _mapper.Map<AuthorNewVm>(author);

            return authorVm;
        }

        public void UpdateAuthor(AuthorNewVm model)
        {
            var author = _mapper.Map<Author>(model);
            _authorRepository.UpdateAuthor(author);
        }
    }
}
