using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibApp.Infrastructure.Repositories
{
    public class ItemTypeRepository : IItemTypeRepository
    {
        private readonly Context _context;

        public ItemTypeRepository(Context context)
        {
            _context = context;
        }
        
        public int AddItemType(ItemType itemType)
        {
            _context.ItemTypes.Add(itemType);
            _context.SaveChanges();

            return itemType.Id;
        }

        public void DeleteItemType(int itemTypeId)
        {
            var itemType = _context.ItemTypes.Find(itemTypeId);

            if (itemType != null)
            {
                _context.ItemTypes.Remove(itemType);
                _context.SaveChanges();
            }
        }

        public IQueryable<ItemType> GetAllItemTypes()
        {
            return _context.ItemTypes;
        }

        public ItemType GetItemTypeById(int itemTypeId)
        {
            var itemType = _context.ItemTypes.FirstOrDefault(i => i.Id == itemTypeId);

            return itemType;
        }

        public void UpdateItemType(ItemType itemType)
        {
            _context.ItemTypes.Update(itemType);
            _context.SaveChanges();
        }
    }
}
