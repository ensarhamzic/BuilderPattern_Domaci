using GraditeljDomaci.classes.user.person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.rank
{
    public static class RankDirector
    {
        public static IRankBuilder Builder()
        {
            return new RankBuilder();
        }
    }
}
