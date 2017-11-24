using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKStatistic.Classes
{
    class Friend : IUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public int Count(SearchStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
