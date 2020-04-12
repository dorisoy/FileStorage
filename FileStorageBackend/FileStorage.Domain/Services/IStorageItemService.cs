﻿using FileStorage.Domain.DataTransferedObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileStorage.Domain.Services
{
    public interface IStorageItemService
    {
        Task<IEnumerable<StorageItemDto>> GetAllStorageItemAsync();
        Task<StorageItemDto> GetStorageItemByIdAsync(Guid id);
    }
}