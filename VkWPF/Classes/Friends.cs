using System;
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
        public VkCollection<VkNet.Model.User> FriendsList { get; private set; }
        public Friends(VkNet.VkApi vk) {
            FriendsList = vk.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams()
                {
                    UserId = vk.UserId,
                    Fields = ProfileFields.FirstName | ProfileFields.LastName
                }
            );
        }
    }
}
