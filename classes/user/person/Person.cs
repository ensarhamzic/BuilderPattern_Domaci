using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.person
{
    public class Person
    {
        public string Jmbg { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }

        public Person() { }

        public Person(string jmbg, string name, string surname, char gender)
        {
            Jmbg = jmbg;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"JMBG: {Jmbg}, Ime: {Name}, Prezime: {Surname}, Pol: {Gender}";
        }
    }
}
