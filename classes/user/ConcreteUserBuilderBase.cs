using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraditeljDomaci.classes.user.person;

namespace GraditeljDomaci.classes.user
{
    public abstract class ConcreteUserBuilderBase : IPersonBuilder
    {
        protected string _jmbg { get; set; } = "0000000000000";
        protected string _name { get; set; } = "Ime";
        protected string _surname { get; set; } = "Prezime";
        protected char _gender { get; set; } = 'M';


        public IPersonBuilder Jmbg(string jmbg)
        {
            if (jmbg.Length != 13)
                throw new ArgumentException("JMBG mora biti dužine 13 karaktera.");
            _jmbg = jmbg;
            return this;
        }

        public IPersonBuilder Name(string name)
        {
            if (name.Length < 3 || name.Length > 20)
                throw new ArgumentException("Ime mora biti dužine između 3 i 20 karaktera.");
            _name = name;
            return this;
        }

        public IPersonBuilder Surname(string surname)
        {
            if (surname.Length < 3 || surname.Length > 30)
                throw new ArgumentException("Prezime mora biti dužine između 3 i 20 karaktera.");
            _surname = surname;
            return this;
        }

        public IPersonBuilder Gender(char gender)
        {
            if (gender != 'M' && gender != 'Z')
                throw new ArgumentException("Pol mora biti 'M' ili 'Z'.");
            _gender = gender;
            return this;
        }

        public Person Build()
        {
            return new Person(_jmbg, _name, _surname, _gender);
        }
    }
}
