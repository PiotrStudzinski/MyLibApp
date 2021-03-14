using Microsoft.AspNetCore.Mvc;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.ItemType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibApp.Web.Controllers
{
    public class ItemTypeController : Controller
    {
        private readonly IItemTypeService _itemTypeService;

        public ItemTypeController(IItemTypeService itemTypeService)
        {
            _itemTypeService = itemTypeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _itemTypeService.GetAllItemTypeForList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ItemTypeNewVm());
        }

        [HttpPost]
        public IActionResult Create(ItemTypeNewVm model)
        {
            _itemTypeService.AddItemType(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _itemTypeService.DeleteItemType(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _itemTypeService.GetItemTypeDetails(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = _itemTypeService.GetItemTypeForEdit(id);

            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(ItemTypeNewVm model)
        {
            _itemTypeService.UpdateItemType(model);

            return RedirectToAction("Index");
        }
    }
}
