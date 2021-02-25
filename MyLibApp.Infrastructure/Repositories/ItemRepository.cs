using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        
        public ItemRepository(Context context)
        {
            _context = context;
        }

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);

            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public IQueryable<Item> GetAllItems()
        {
            return _context.Items;
        }

        public IQueryable<Item> GetItemByAuthorId(int authorId)
        {
            var items = _context.Items.Where(i => i.AuthorId == authorId);

            return items;
        }

        public IQueryable<Item> GetItemByCategoryId(int categoryId)
        {
            var items = _context.Items.Where(i => i.CategoryId == categoryId);

            return items;
        }

        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);

            return item;
        }

        public IQueryable<Item> GetItemByItemTypeId(int itemTypeId)
        {
            var items = _context.Items.Where(i => i.ItemTypeId == itemTypeId);

            return items;
        }

        public void UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
        }
    }
}
