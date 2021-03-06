using Microsoft.AspNetCore.Mvc;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _categoryService.GetAllCategoryForList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CategoryNewVm());
        }

        [HttpPost]
        public IActionResult Create(CategoryNewVm model)
        {
            _categoryService.AddCategory(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategory(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _categoryService.GetCategoryDetails(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _categoryService.GetCategoryForEdit(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryNewVm model)
        {
            _categoryService.UpdateCategory(model);

            return RedirectToAction("Index");
        }
    }
}
