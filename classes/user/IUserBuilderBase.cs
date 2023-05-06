using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user
{
    // Koristim generički tip TBuilder kako bih mogao da vratim tip koji implementira ovaj interfejs
    // Kako bi i Person i Teacher mogli da implementiraju ovaj interfejs, a da svaki od njih ima povratni builder tip
    // Ovako se izbegava ponavljanje koda, jer bi u suprotnom morao da overridujem sve metode ispod u klasi Teacher
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
