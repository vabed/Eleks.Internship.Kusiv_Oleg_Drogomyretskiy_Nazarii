using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKStatistic.Classes
{
    class User : IUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        // If you have interfaces, try to return them, code become mire flexible after it
        // It's better to put this methods to special service which will work with VK API
        public Friend[] GetLastVisited() {
            throw new NotImplementedException();
        }
        public Friend[] GetLastVisited(int count) {
            throw new NotImplementedException();
        }

        public int Count(SearchStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
