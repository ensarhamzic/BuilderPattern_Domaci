using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public class ConcreteTeacherBuilder : ConcreteUserBuilderBase, ITeacherBuilder
    {
        public string _rank { get; set; } = "Profesor";
        public DateOnly _birthday { get; set; } = new DateOnly(1990, 1, 1);
        public int _yearsOfService { get; set; } = 0;

        public ITeacherBuilder Rank(string rank)
        {
            _rank = rank;
            return this;
        }
        
        public ITeacherBuilder Birthday(DateOnly birthday)
        {
            _birthday = birthday;
            return this;
        }
        
        public ITeacherBuilder YearsOfService(int yearsOfService)
        {
            _yearsOfService = yearsOfService;
            return this;
        }

        public new ITeacherBuilder Jmbg(string jmbg)
        {
            base.Jmbg(jmbg);
            return this;
        }

        public new ITeacherBuilder Name(string name)
        {
            base.Name(name);
            return this;
        }

        public new ITeacherBuilder Surname(string surname)
        {
            base.Surname(surname);
            return this;
        }

        public new ITeacherBuilder Gender(char gender)
        {
            base.Gender(gender);
            return this;
        }

        public new Teacher Build()
        {
            return new Teacher(_jmbg, _name, _surname, _gender, _rank);
        }

    }
}
