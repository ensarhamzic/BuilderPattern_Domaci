using GraditeljDomaci.classes.user.person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public class Teacher : Person
    {
        public string Rank { get; set; }
        public DateOnly Birthday { get; set; }
        public int YearsOfService { get; set; }

        public Teacher() { }

        // constructor with all parameters that calls base constructor
        public Teacher(string jmbg, string name, string surname, char gender, string rank) : base(jmbg, name, surname, gender)
        {
            Rank = rank;
        }

        public override string ToString()
        {
            return $"JMBG: {Jmbg}, Ime: {Name}, Prezime: {Surname}, Pol: {Gender}, Pol: {Gender}, Zvanje: {Rank}, Datum rodjenja: {Birthday}, Godine Staza: {YearsOfService}";
        }
    }
}
