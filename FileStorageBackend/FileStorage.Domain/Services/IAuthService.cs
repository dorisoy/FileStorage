﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileStorage.Domain.DataTransferedObjects;

namespace FileStorage.Domain.Services
{
    public interface IAuthService
    {
        Task<UserForRegisterDto> RegisterAsync(UserForRegisterDto user);
        Task<UserDto> LoginAsync(string username, string password);
        Task<bool> UserExistsAsync(string username);
    }
}