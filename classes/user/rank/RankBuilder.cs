using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.rank
{
    public class RankBuilder : IRankBuilder
    {
        private int id = 0;
        private string name = "";

        public IRankBuilder Id(int id)
        {
            this.id = id;
            return this;
        }

        public IRankBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public Rank Build()
        {
            return new Rank(id, name);
        }
    }
}
