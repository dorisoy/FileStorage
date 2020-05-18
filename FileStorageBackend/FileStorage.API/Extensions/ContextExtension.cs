﻿using Microsoft.AspNetCore.Http;
using FileStorage.Domain.DataTransferredObjects.UserModels;

namespace FileStorage.API.Extensions
{
    public static class ContextExtension
    {
        public static UserDto GetUserFromContext(this HttpContext context, 
            string userParamKey)
        {
            return (UserDto)context.Items[userParamKey];
        }
    }
}
