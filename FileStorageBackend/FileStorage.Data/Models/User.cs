﻿using System;
using System.Collections.Generic;

namespace FileStorage.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }  
        public StorageFolder UserRootFolder { get; set; }
        public virtual ICollection<StorageFolder> StorageFolders { get; set; }
        public virtual ICollection<StorageFile> StorageFiles { get; set; }
    }
}
