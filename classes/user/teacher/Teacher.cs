using GraditeljDomaci.classes.user.person;
using GraditeljDomaci.classes.user.rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public class Teacher : Person
    {
        public Rank Rank { get; set; }
        public DateOnly Birthday { get; set; }
        public int YearsOfService { get; set; }

        // constructor with all parameters that calls base constructor
        public Teacher(string jmbg, string name, string surname, char gender, Rank rank, DateOnly birthday, int yearsOfService) : base(jmbg, name, surname, gender)
        {
            Rank = rank;
            Birthday = birthday;
            YearsOfService = yearsOfService;
        }

        public override string ToString()
        {
            var baseToString = base.ToString();
            return $"{baseToString}Zvanje: {Rank.Name}\nDatum rodjenja: {Birthday}\nGodine Staza: {YearsOfService}\n";
        }
    }
}
