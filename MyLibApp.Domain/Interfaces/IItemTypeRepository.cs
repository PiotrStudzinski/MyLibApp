using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Domain.Interfaces
{
    public interface IItemTypeRepository
    {
        int AddItemType(ItemType itemType);

        void DeleteItemType(int itemTypeId);

        void UpdateItemType(ItemType itemType);

        ItemType GetItemTypeById(int itemTypeId);

        IQueryable<ItemType> GetAllItemTypes();
    }
}
