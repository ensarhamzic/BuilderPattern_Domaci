using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.rank
{
    public interface IRankBuilder
    {
        IRankBuilder Id(int id);
        IRankBuilder Name(string name);

        Rank Build();
    }
}
