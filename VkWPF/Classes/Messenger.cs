using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VkWPF.Classes
{
    class Messenger
    {
        VkApi _vk;
        User usr;
        public Messenger(User usr)
        {
            _vk = Logining.Vk;
            this.usr = usr;

        }
        public void SendMessage() { }
        public void GetMessages() { }

        public MessagesGetObject GetDialogs()  => _vk.Messages.GetDialogs(     new MessagesDialogsGetParams() { Count = 50, PreviewLength = 50}    );

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
        public bool SendMessage(string mess)
        {
            _vk.Messages.Send(new MessagesSendParams() { UserId = usr.Id, Message = mess });
            return true;
        }
        public MessagesGetObject GetHistoryChat(int count = 20)
        {
            Thread.Sleep(500);
            if (count != 0)
                return _vk.Messages.GetHistory(new MessagesGetHistoryParams() { Count = count, UserId = usr.Id });
            else return null;
        }

        public int CheckMesages() {
            var newMessages = _vk.Messages.GetDialogs(new MessagesDialogsGetParams() { Count = 20 }).Messages.Where(x => x.UserId == usr.Id);
            if (newMessages.Count() > 0)
                return newMessages.Count();
            else return 0;
        }

        public BitmapImage[] GetImages() {
            return new BitmapImage[]{
                new BitmapImage(_vk.Users.Get(_vk.UserId.Value, ProfileFields.Photo50).Photo50),
                new BitmapImage(_vk.Users.Get(usr.Id, ProfileFields.Photo50).Photo50),
            };
        }
    }
}
