using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public interface ITeacherBuilder : IUserBuilderBase<Teacher, ITeacherBuilder>
    {
        ITeacherBuilder Rank(string rank);
        ITeacherBuilder Birthday(DateOnly birthday);
        ITeacherBuilder YearsOfService(int yearsOfService);
    }
}
