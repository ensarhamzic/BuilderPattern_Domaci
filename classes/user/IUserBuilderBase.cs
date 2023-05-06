using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user
{
    public interface IUserBuilderBase<out T, out TBuilder>
        where TBuilder : IUserBuilderBase<T, TBuilder>
    {
        TBuilder Jmbg(string jmbg);
        TBuilder Name(string name);
        TBuilder Surname(string surname);
        TBuilder Gender(char gender);
        T Build();
    }
}
