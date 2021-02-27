using Microsoft.AspNetCore.Mvc;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibApp.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _authorService.GetAllAuthorForList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new AuthorNewVm());
        }

        [HttpPost]
        public IActionResult Create(AuthorNewVm model)
        {
            _authorService.AddAuthor(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _authorService.DeleteAuthor(id);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _authorService.GetAuthorDetails(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = _authorService.GetAuthorForEdit(id);
            
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(AuthorNewVm model)
        {
            _authorService.UpdateAuthor(model);

            return RedirectToAction("Index");
        }
    }
}
