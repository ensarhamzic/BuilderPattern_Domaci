using GraditeljDomaci.classes.user.rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public class TeacherBuilder : UserBuilderBase<Teacher, TeacherBuilder>, ITeacherBuilder
    {
        public Rank _rank { get; set; } = new Rank(0, "N/A");
        public DateOnly _birthday { get; set; } = new DateOnly(1990, 1, 1);
        public int _yearsOfService { get; set; } = 0;

        public TeacherBuilder Rank(Rank rank)
        {
            _rank = rank;
            return this;
        }

        public TeacherBuilder Birthday(DateOnly birthday)
        {
            _birthday = birthday;
            return this;
        }

        public TeacherBuilder YearsOfService(int yearsOfService)
        {
            _yearsOfService = yearsOfService;
            return this;
        }

        public override Teacher Build()
        {
            return new Teacher(_jmbg, _name, _surname, _gender, _rank, _birthday, _yearsOfService);
        }
    }
}
