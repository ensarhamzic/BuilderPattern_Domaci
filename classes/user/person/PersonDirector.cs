using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.person
{
    public static class PersonDirector
    {
        public static IPersonBuilder PersonBuilder()
        {
            return new ConcretePersonBuilder();
        }
    }
}
