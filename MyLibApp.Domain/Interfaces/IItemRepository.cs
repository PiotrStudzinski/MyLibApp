using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Domain.Interfaces
{
    public interface IItemRepository
    {
        int AddItem(Item item);

        void DeleteItem(int itemId);

        void UpdateItem(Item item);

        Item GetItemById(int itemId);

        IQueryable<Item> GetAllItems();

        IQueryable<Item> GetItemByAuthorId(int authorId);

        IQueryable<Item> GetItemByCategoryId(int categoryId);

        IQueryable<Item> GetItemByItemTypeId(int itemTypeId);

    }
}
