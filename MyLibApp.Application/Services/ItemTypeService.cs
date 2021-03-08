using AutoMapper;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.ItemType;
using MyLibApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Application.Services
{
    public class ItemTypeService : IItemTypeService
    {
        private readonly IItemTypeRepository _itemTypeRepository;
        private readonly IMapper _mapper;

        public ItemTypeService(IItemTypeRepository itemTypeRepository, IMapper mapper)
        {
            _itemTypeRepository = itemTypeRepository;
            _mapper = mapper;
        }

        public int AddItemType(ItemTypeNewVm itemType)
        {
            throw new NotImplementedException();
        }

        public void DeleteItemType(int itemTypeId)
        {
            throw new NotImplementedException();
        }

        public ItemTypeListVm GetAllItemTypeForList()
        {
            throw new NotImplementedException();
        }

        public ItemTypeDetailsVm GetItemTypeDetails(int itemTypeId)
        {
            throw new NotImplementedException();
        }

        public ItemTypeNewVm GetItemTypeForEdit(int itemTypeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateItemType(ItemTypeNewVm model)
        {
            throw new NotImplementedException();
        }
    }
}
