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
        VkApi _vk;

        public VkCollection<VkNet.Model.User> FriendsList { get; private set; }
        public VkCollection<VkNet.Model.User> getFriendsListOnline() {
            var temp = FriendsList.Where(x => x.Online == true);
            return new VkCollection<VkNet.Model.User>((ulong)temp.Count(), temp);
        }

        public Friends() {
            _vk = Logining.Vk;
            FriendsList = _vk.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams()
                {
                    UserId = _vk.UserId,
                    Fields = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Online
                }
            );
        }

    }
}
