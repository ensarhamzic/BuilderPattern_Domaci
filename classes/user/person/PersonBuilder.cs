using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.person
{
    public class PersonBuilder : UserBuilderBase<Person, PersonBuilder>, IPersonBuilder
    {
        public override Person Build()
        {
            return new Person(_jmbg, _name, _surname, _gender);
        }
    }
}
