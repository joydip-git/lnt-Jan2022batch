﻿using AuthService.Models;
using System.Collections.Generic;

namespace AuthService.Repository.Data
{
    public static class UserRepository
    {
        public static HashSet<UserInfo> Users => new HashSet<UserInfo>
        {
            new UserInfo{UserName="user1", Password="password1"},
            new UserInfo{UserName="user2", Password="password3"},
            new UserInfo{UserName="user3", Password="password3"},
        };
    }
}
