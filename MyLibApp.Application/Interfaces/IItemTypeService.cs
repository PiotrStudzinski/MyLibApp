using MyLibApp.Application.ViewModels.ItemType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.Interfaces
{
    public interface IItemTypeService
    {
        ItemTypeListVm GetAllItemTypeForList();
        int AddItemType(ItemTypeNewVm itemType);
        ItemTypeDetailsVm GetItemTypeDetails(int itemTypeId);
        ItemTypeNewVm GetItemTypeForEdit(int itemTypeId);
        void UpdateItemType(ItemTypeNewVm model);
        void DeleteItemType(int itemTypeId);
    }
}
