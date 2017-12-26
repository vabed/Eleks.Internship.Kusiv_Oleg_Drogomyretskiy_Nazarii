using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Utils;
namespace VkWPF.Classes
{
    class Friends
    {
        public VkApi _vk;
        long userId;
#region Constructors
        public Friends()
        {
            _vk = Logining.Vk;
            userId = _vk.UserId.Value;
            LoadFriends(userId);
        }
        public Friends(long userId)
        {
            _vk = Logining.Vk;
            this.userId = userId;
            LoadFriends(this.userId);
        }
#endregion

        public VkCollection<User> FriendsList{ get; private set;}

        public VkCollection<User> GetFriendsListOnline() {
            var temp = FriendsList.Where(x => x.Online == true);
            return new VkCollection<User>((ulong)temp.Count(), temp);
        }
        public VkCollection<User> FilterSex(VkNet.Enums.Sex sex)
        {
            var list = FriendsList.Where(x => x.Sex == sex);
            return new VkCollection<User>((ulong)list.Count(), list);
        }
        public VkCollection<User> FilterName(string name) {
            var list = FriendsList.Where(x => (x.FirstName+x.LastName).Contains(name));
            return new VkCollection<User>((ulong)list.Count(), list);
        }
        public VkCollection<User> FilterName(VkCollection<User> vkCollection, string name)
        {
            var list = vkCollection.Where(x => (x.FirstName + x.LastName).Contains(name));
            return new VkCollection<User>((ulong)list.Count(), list);
        }
        public IEnumerable<User> FilterOld(int year) {
            var temp = FriendsList.Where(x => (x.BirthDate != null && x.BirthDate.Length > 5 ));
            int yearTemp;
            string yearStr;
            foreach(var friend in temp)
            {
                yearStr = friend.BirthDate.Substring(friend.BirthDate.Length - 4);
                if (int.TryParse(yearStr, out yearTemp))
                    yield return friend;
            }
        } 

        public void LoadFriends(long id){
            FriendsList = _vk.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams()
                {
                    UserId = id,
                    Fields =ProfileFields.FirstName | ProfileFields.LastName | 
                            ProfileFields.Photo100 | ProfileFields.Online  | ProfileFields.Sex | ProfileFields.BirthDate |
                             ProfileFields.Country | ProfileFields.City | 
                             ProfileFields.Universities | ProfileFields.Schools | ProfileFields.Career
                }
            );
        }

        /// <summary>
        /// Кількість елементів
        /// </summary>
        /// <param name="vkCollection">Якщо параметр рівний null то повертає кількість всіх друзів.</param>
        /// <returns></returns>
        public int Count(IEnumerable<User> vkCollection = null) {
            if (vkCollection == null) return FriendsList.Count();
            else return vkCollection.Count();
        }
        public List<int> GetYears() {
            List<int> years = new List<int>();
            foreach (var user in FriendsList) {
                string yearStr = user.BirthDate.Substring(user.BirthDate.Length - 4);
                int yearTemp;

                if (int.TryParse(yearStr, out yearTemp) && years.Where(x=>x == yearTemp).Count() == 0 )
                {
                    years.Add(yearTemp);
                }
            }
            return years;
        }
        public IEnumerable<User> GetRecent(int count)
        {
            var ids = _vk.Friends.GetRecent(5);
            return _vk.Users.Get(ids);
        }
        public IEnumerable<User> GetOdnoselchans()//ДН XD)
        {
            var moieselo = (_vk.Account.GetProfileInfo().City !=null) ? _vk.Account.GetProfileInfo().City.Title : null ;
            foreach (var friend in FriendsList)
            {
                if(friend.City !=null && friend.City.Title ==moieselo)
                yield return friend;
            }
        }

        /// <summary>
        /// Метод виконує пошук друзів хто навчається або працює з залогіненим користувачем.
        /// </summary>
        /// <returns>Може бути null.</returns>
        public IEnumerable<User> WhoWorkWithMe()
        {
            var user = _vk.Users.Get(_vk.UserId.Value, ProfileFields.Schools | ProfileFields.Universities|ProfileFields.Career);
            var job = (user.Career.Count()!=0) ? user.Career.Last():null;
            var school = (user.Schools.Count() != 0) ? user.Schools.Last() : null;
            var univer = (user.Universities.Count() != 0) ? user.Universities.Last() : null;
            if (job != null)
            {
                foreach (var friend in FriendsList)
                {
                    if (friend.Career.Count != 0 && friend.Career.Last().Company == job.Company)
                        yield return friend;
                }
            }
            else if (univer != null)
            {
                foreach (var friend in FriendsList)
                {
                    if (friend.Universities.Count!=0 && friend.Universities.Last().Name == univer.Name)
                        yield return friend;
                }
            }
            else if (school != null)
            {
                foreach (var friend in FriendsList.Where(x=>x.Schools.Count!=0))
                {
                    if (friend.Schools.Count != 0 && friend.Schools.Last().Name == school.Name)
                        yield return friend;
                }
            }
            else yield return null;  
        }
    }
}
