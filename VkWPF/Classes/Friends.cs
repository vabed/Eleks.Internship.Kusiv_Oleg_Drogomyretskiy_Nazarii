﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Utils;
namespace VkWPF.Classes
{
    class Friends
    {
        VkApi _vk;

        public VkCollection<VkNet.Model.User> FriendsList{ get; private set;}
        public VkCollection<VkNet.Model.User> GetFriendsListOnline() {
            var temp = FriendsList.Where(x => x.Online == true);
            return new VkCollection<VkNet.Model.User>((ulong)temp.Count(), temp);
        }

        public void UpdateFriends(long id){
            FriendsList = _vk.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams()
                {
                    UserId = id,
                    Fields = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100 | ProfileFields.Online | ProfileFields.Country
                }
            );
        }

        public Friends() {
            _vk = Logining.Vk;
            UpdateFriends(_vk.UserId.Value);
        }

        public Friends(int userId)
        {
            _vk = Logining.Vk;
            UpdateFriends(userId);
        }
    }
}
