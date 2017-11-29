using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKStatistic.Classes
{
    interface IUser
    {
        string Name { get; set; }
        string SurName { get; set; }
        int Age { get; set; }

        int Count(SearchStatus status);
    }
}
