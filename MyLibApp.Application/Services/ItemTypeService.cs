using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyLibApp.Application.Interfaces;
using MyLibApp.Application.ViewModels.ItemType;
using MyLibApp.Domain.Interfaces;
using MyLibApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var newItemType = _mapper.Map<ItemType>(itemType);
            var id = _itemTypeRepository.AddItemType(newItemType);

            return id;
        }

        public void DeleteItemType(int itemTypeId)
        {
            _itemTypeRepository.DeleteItemType(itemTypeId);
        }

        public ItemTypeListVm GetAllItemTypeForList()
        {
            var itemTypes = _itemTypeRepository.GetAllItemTypes()
                .ProjectTo<ItemTypeForListVm>(_mapper.ConfigurationProvider).ToList();
            var itemTypeList = new ItemTypeListVm()
            {
                ItemTypes = itemTypes
            };

            return itemTypeList;
        }

        public ItemTypeDetailsVm GetItemTypeDetails(int itemTypeId)
        {
            var itemType = _itemTypeRepository.GetItemTypeById(itemTypeId);
            var itemTypeVm = _mapper.Map<ItemTypeDetailsVm>(itemType);

            return itemTypeVm;
        }

        public ItemTypeNewVm GetItemTypeForEdit(int itemTypeId)
        {
            var itemType = _itemTypeRepository.GetItemTypeById(itemTypeId);
            var itemTypeVm = _mapper.Map<ItemTypeNewVm>(itemType);

            return itemTypeVm;
        }

        public void UpdateItemType(ItemTypeNewVm model)
        {
            var itemType = _mapper.Map<ItemType>(model);

            _itemTypeRepository.UpdateItemType(itemType);
        }
    }
}
