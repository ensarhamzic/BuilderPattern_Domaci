using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraditeljDomaci.classes.user.person;

namespace GraditeljDomaci.classes.user
{
    // Implementira interfejs IUserBuilderBas, koji je parametrizovan tipom T i tipom TBuilder
    // T predstavlja tip objekta koji se gradi
    // TBuilder predstavlja tip objekta koji gradi objekat tipa T
    public abstract class UserBuilderBase<T, TBuilder> : IUserBuilderBase<T, TBuilder>
        where TBuilder : UserBuilderBase<T, TBuilder>
    {
        protected string _jmbg { get; set; } = "0000000000000";
        protected string _name { get; set; } = "Ime";
        protected string _surname { get; set; } = "Prezime";
        protected char _gender { get; set; } = 'M';

        public TBuilder Jmbg(string jmbg)
        {
            if (jmbg.Length != 13)
                throw new ArgumentException("JMBG mora biti dužine 13 karaktera.");
            _jmbg = jmbg;
            return (TBuilder)this;
        }

        public TBuilder Name(string name)
        {
            if (name.Length < 3 || name.Length > 20)
                throw new ArgumentException("Ime mora biti dužine između 3 i 20 karaktera.");
            _name = name;
            return (TBuilder)this;
        }

        public TBuilder Surname(string surname)
        {
            if (surname.Length < 3 || surname.Length > 30)
                throw new ArgumentException("Prezime mora biti dužine između 3 i 20 karaktera.");
            _surname = surname;
            return (TBuilder)this;
        }

        public TBuilder Gender(char gender)
        {
            if (gender != 'M' && gender != 'Z')
                throw new ArgumentException("Pol mora biti 'M' ili 'Z'.");
            _gender = gender;
            return (TBuilder)this;
        }

        public abstract T Build();
    }
}
