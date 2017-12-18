using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VkWPF.Classes
{
    class Messenger
    {
        VkApi _vk;

        public Messenger() {
            _vk = Logining.Vk;
        }

        public void SendMessage() { }
        public void GetMessages() { }

        public MessagesGetObject GetDialogs() 
            => _vk.Messages.GetDialogs(     new MessagesDialogsGetParams() { Count = 50, PreviewLength = 50}    );


        public IEnumerable<string> GetInfoAboutDialogs()
        {
            var dialogs = GetDialogs().Messages;
            StringBuilder usrInfo = new StringBuilder();
            foreach (var e in dialogs) {
                var usr = _vk.Users.Get(e.UserId.Value);
                usrInfo.Clear().AppendLine($"{usr.FirstName}|{usr.LastName}|{usr.Online}");
                yield return usrInfo.ToString();
            }
        }

    }
}
