﻿using System;
using System.Threading.Tasks;
using FileStorage.Data.Persistence.Interfaces;

namespace FileStorage.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IStorageItemRepository StorageItems { get; }
        IRolesRepository Roles { get; }
        Task<int> CommitAsync();
    }
}
