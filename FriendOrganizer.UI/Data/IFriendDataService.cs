﻿using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        //IEnumerable<Friend> GetAll();

        Task<Friend> GetByIdAsync(int friendId);
    }
}